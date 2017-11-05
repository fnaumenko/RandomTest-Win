//#define DEVELOPMENT

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

using System.Windows.Forms.DataVisualization.Charting;

namespace RandomTest
{
    public static class RandomGen
    {
        const byte FIRST_IND_CSH = 4;   // first C# index in first parameter in Init() 
        const byte  BASED_ON_C = 0,     // RNG based on C
                    BASED_ON_SCH_STRONG = 1,   // C# strong RNG
                    BASED_ON_CSH = 2;    // C# stdandard RNG

        const byte  GAUSS_ABRAM = 0,    // Abramowitz and Stegun generator index
                    GAUSS_CLT = 1,      // Central Limit Theorem generator index
                    GAUSS_FOG = 2,      // Fog generator index
                    GAUSS_MARS = 3,     // Marsaglia generator index
                    GAUSS_CSH = 4;      // C# generator index

        /// <summary>Keeps library on which the random generator is based.</summary>
        static byte Library;
        static Chart chart = new Chart();
        static StatisticFormula statFormula = chart.DataManipulator.Statistics;
        static int Sigma = 0;
        static int Mean = 0;
        static int LnFactor;
        static float LnTerm;
        static int SzSelSigma = 0;
        //static int SzSelMean = 0;

        static int ValDevMin;
        static int ValDevMax;

        //static bool IsCsharpStrong = false;
        /// <summary>True if lognorm generation should be performed.</summary>
        static bool IsExp;

        delegate double RandomGenDlg();

        /// <summary>Random number generator.</summary>
        static RandomGenDlg RandomNumb;
        /// <summary>Random distribution generator.</summary>
        static RandomGenDlg Distrib;

        static Random rand = new Random();
        static System.Security.Cryptography.RNGCryptoServiceProvider rngCsp =
            new System.Security.Cryptography.RNGCryptoServiceProvider();

        static double U = 0, V = 0, S = 0, Trig = 0;
        static double normal_x2;    // Gauss by Fog
        static int phase = 0;
        static bool zeroPhase = true;
        const int NSUM = 25;

        static int RGenCount;

        /// <summary>Represents collection of cryptographicly strong random numbers.</summary>
        class CshStrongRandomGen
        {
            static int _Multiplier;

            /// <summary>Takes account of Gauss generater.</summary>
            /// <param name="gaussGenInd">Gauss generater index</param>
            public static void RecordGaussGen(int gaussGenInd)
            {
                // These generators call GetRandom() from 3 to 4 times,
                // so the total random numbers collection should be increased
                if (gaussGenInd == GAUSS_CLT || gaussGenInd == GAUSS_FOG || gaussGenInd == GAUSS_CLT)
                    _Multiplier = 3;
                else
                    _Multiplier = 1;
            }

            byte[] _numbers;
            int _counter;

            /// <summary>Creates and fill a collection of cryptographicly strong random numbers.</summary>
            /// <param name="cnt">The length of collection.</param>
            public CshStrongRandomGen(int cnt)
            {
                _numbers = new byte[cnt * _Multiplier];   // increase volume for selected Gauss generators
                rngCsp.GetNonZeroBytes(_numbers);
                _counter = 0;
            }

            /// <summary>Returns next random number.</summary>
            /// <returns></returns>
            public double GetNext()
            {
                double numb = (double)_numbers[_counter] / Byte.MaxValue;
                if (++_counter >= _numbers.Length) 
                    _counter = 0;
                return numb;
            }
        }

        /// <summary>Initializes of RandomGenerator.</summary>
        /// <param name="randGen">Type of random generator: 
        /// 0 Mersenne Twister, 1 O'Neill, 2 C std, 3 XorShift, 4 C# std, 5 C# strong.</param>
        /// <param name="normGen">Type of Gauss generator: 
        /// -1 no generator, 0 Abramowitz and Stegun, 1 Central Limit Theorem, 
        /// 2 Fog, 3Marsaglia, 4 C/C# std</param>
        /// <param name="isExp">True if include lognorm generation</param>
        /// <param name="isStdLogNorm">True if use C++ standard lognorm generation</param>
        /// <param name="mean">Gauss mean</param>
        /// <param name="sigma">Gauss sigma</param>
        /// <param name="lnFactor">Lognorm factor</param>
        /// <param name="lnTerm">Lognorm term</param>
        /// <returns>False if extern CRandom dll is not found, otherwise true</returns>
        public static bool Init(int randGen, int normGen, bool isExp, bool isStdLogNorm,
            int mean, int sigma, int lnFactor, float lnTerm,
            int szSelMean, int szSelSigma, int dev)
        {
            Library = randGen < FIRST_IND_CSH ? BASED_ON_C : (randGen == FIRST_IND_CSH+1 ? BASED_ON_SCH_STRONG : BASED_ON_CSH);
            IsExp = isExp;
            Mean = mean;
            Sigma = sigma;
            LnFactor = lnFactor;
            LnTerm = lnTerm;
            if (normGen == -1)
            {
                Sigma = 1000;
                Mean = 0;
            }

            if (Library == BASED_ON_C)
                if (System.IO.File.Exists(CRandom.FullDllFile))
                    CRandom.Init(randGen, normGen, isExp, isStdLogNorm, Mean, Sigma, LnFactor, LnTerm);
                else
                    return false;
            else
            {
                RandomNumb = GetRandom;
                CshStrongRandomGen.RecordGaussGen(normGen);
                SzSelSigma = szSelSigma;
                ValDevMin = szSelMean - dev;
                ValDevMax = szSelMean + dev;
                switch (normGen)
                {
                    case -1: Distrib = GetRandom; break;
                    case 0: Distrib = GaussAS; break;
                    case 1: Distrib = GaussCLT; break;
                    case 2: Distrib = GaussFog; break;
                    case 3: Distrib = GaussM; break;
                    case 4: Distrib = GaussCshStd; break;
                }
            }
            return true;
        }

        /// <summary>Fills data by current distribution.</summary>
        /// <param name="numbers">Data that should be filled</param>
        /// <param name="cnt">Number or repetitions. Returned the number of rendom generator calls.</param>
        /// <returns>Average Y value.</returns>
        public static float GetDistrib(Numbers numbers, ref int cnt)		
        {
            RGenCount = 0;
            if (Library == BASED_ON_C)
                return CRandom.GetDistrib(numbers != null ? numbers.Data : null, ref cnt);
            else if (Library == BASED_ON_SCH_STRONG)
            {
                CshStrongRandomGen gen = new CshStrongRandomGen(cnt);
                RandomNumb = gen.GetNext;
            }
            decimal sum = 0;
            double dres;
            short res;
            for (int i = 0; i < cnt; i++)
            {
                dres = Distrib() * Sigma + Mean;
                if (IsExp)
                    dres = Math.Exp(dres / LnFactor + LnTerm);
                res = (short)dres;

                // round up res: otherwise all values will be round down during casting to short.
                // in this case the distribution will not only be inaccurate,
                // but worse - values less than 1 will be rounded to 0,
                // which leads to a falsely large number of zero points.
                // The variant res = (short)Math.Round(dres, 0) is much slower
                if (dres > 0) { if (dres - res >= 0.5) res++; }	// round up positives
                else { if (dres - res <= -0.5) res--; }	// round up negatieves
                
                if(numbers!=null)
                    numbers.Data[i] = res;
                sum += res;
            }
            float average = (float)sum / cnt;
            cnt = RGenCount;
            return average;
        }


        /// <summary>C# standard random double generator.</summary>
        /// <returns>Random double.</returns>
        static double GetRandom()
        {
            RGenCount++;
            return rand.NextDouble();
            //return (double)rand.Next() / int.MaxValue;    // this is a very little slower
        }

        /// <summary>C# standard random int generator.</summary>
        /// <returns>Random double.</returns>
        static int GetIRandom()
        {
            RGenCount++;
            return rand.Next();
        }

        # region Gaussian generators

        /// <summary>Based on C# random Gauss generator used Abramowitz and Stegun method.</summary>
        /// <returns></returns>
        static double GaussAS()
        {
            double Trig;

            if (phase == 0)
            {
                U = (GetIRandom() + 1) / ((double)Int32.MaxValue + 2);
                V = GetIRandom() / ((double)Int32.MaxValue + 1);
                Trig = Math.Sin(2 * Math.PI * V);
            }
            else
                Trig = Math.Cos(2 * Math.PI * V);
            phase = 1 - phase;

            return Trig * Math.Sqrt(-2 * Math.Log(U));
        }

        /// <summary>Based on C# random Gauss generator exploits the Central Limit Theorem.</summary>
        /// <returns></returns>
        static double GaussCLT()
        {
            double x = 0;
            for (int i = 0; i < NSUM; i++)
                x += RandomNumb();
            x -= NSUM / 2.0;
            x /= Math.Sqrt(NSUM / 12.0);
            return x;
        }

        /// <summary>Based on C# random Gauss generator used A. Fog method.</summary>
        /// <returns></returns>
        static double GaussFog()
        {
            double normal_x1;		// first random coordinate (normal_x2 is member of class)
            double w;				// radius

            if (zeroPhase)
            {			// we have a valid result from last call
                zeroPhase = false;
                return normal_x2;
            }
            do
            {					// make two normally distributed variates by Box-Muller transformation
                normal_x1 = 2 * RandomNumb() - 1;
                normal_x2 = 2 * RandomNumb() - 1;
                w = normal_x1 * normal_x1 + normal_x2 * normal_x2;
            } while (w >= 1 || w < 1E-30);
            w = Math.Sqrt(Math.Log(w) * (-2 / w));
            zeroPhase = true;
            normal_x2 *= w;    // normal_x1 and normal_x2 are independent normally distributed variates
            return normal_x1 * w;
        }

        /// <summary>Based on C# random Gauss generator used Marsaglia method.</summary>
        /// <returns></returns>
        static double GaussM()
        {
	        if(phase == 0)
            {
		        do
                {
                    U = 2 * RandomNumb() - 1;
                    V = 2 * RandomNumb() - 1;
                    S = U * U + V * V;
		        } while(S >= 1 || S == 0);
                Trig = U;
	        } 
	        else
                Trig = V;
	        phase = 1 - phase;

            return Trig * Math.Sqrt(-2 * Math.Log(S) / S);
        }

        /// <summary>Standard C# random Gauss generator.</summary>
        /// <returns></returns>
        static double GaussCshStd()
        {
            return statFormula.InverseNormalDistribution((double)rand.Next(1, short.MaxValue - 1) / short.MaxValue);
            //return statFormula.InverseNormalDistribution(GetRandom()); - doesn't woark because of index exceeding
        }

        #endregion
    }

    /// <summary>Wrapper of random renerator written on C</summary>
    public static class CRandom
    {
        public const string DllFile = "CRandomGen.dll";
        public const string FullDllFile = 
#if DEVELOPMENT
        @"\Documents\Visual Studio 2010\Projects\CRandomGen\Release\" + DllFile;
#else
        DllFile;
#endif

        [DllImport(FullDllFile, CallingConvention = CallingConvention.Cdecl)]
        public extern static void Init(int randInd, int normInd, bool isExp, bool isStdLogNorm, int mean, int sigma, int lnFactor, float lnTerm);

        [DllImport(FullDllFile, CallingConvention = CallingConvention.Cdecl)]
        public extern unsafe static float GetDistrib(short[] data, ref int cnt);
    }
}
