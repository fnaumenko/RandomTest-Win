
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
        const byte  ON_C = 0,           // RNG based on C
                    ON_SCH_STRONG = 1,  // C# strong RNG
                    ON_CSH = 2;         // C# stdandard RNG

        const byte  GS_ABRAM = 0,    // Abramowitz and Stegun generator index
                    GS_CLT = 1,      // Central Limit Theorem generator index
                    GS_FOG = 2,      // Fog generator index
                    GS_MARS = 3,     // Marsaglia generator index
                    GS_CSH = 4;      // C# generator index

        /// <summary>Keeps library on which the random generator is based.</summary>
        static byte Library;
        static Chart chart = new Chart();
        static StatisticFormula statFormula = chart.DataManipulator.Statistics;
        /// <summary>Array containing mean and sigma of normal or lognormal distribution</summary>
        static float[] DistVars;
        /// <summary>Size sel mean or 0 if size sel is unable</summary>
        static int ssMean;
        /// <summary>Doubled variance 2*sigma^2 in the size sel normal distribution</summary>
        //static double ssDVariance;
        /// <summary>Factor sigma*sqr(2PI) in the size sel normal distribution</summary>
        //static double ssFactor;
        /// <summary>Size sel normal distribution aligning up ratio</summary>
        //static double ssAlignRatio;
        /// <summary>Factor sigma*sqr(2) in the size sel normal distribution</summary>
        static float ssFactor0;
        /// <summary>Factor 2.5/sqr(2PI) in the size sel normal distribution</summary>
        static float ssFactor1;

        //static bool IsCsharpStrong = false;
        /// <summary>True if lognorm generation should be performed.</summary>
        static bool IsExp;

        delegate double RandomGenDlg();

        /// <summary>Random number generator.</summary>
        static RandomGenDlg RandomNumb;
        /// <summary>Current distribution RNG.</summary>
        static RandomGenDlg Distrib;
        /// <summary>All distribution RNGs.</summary>
        static RandomGenDlg[] Distribs =
        {
                    GetRandom,  // plain RNG
                    GaussAS,
                    GaussCLT,
                    GaussFog,
                    GaussM,
                    GaussCshStd,
        };

    static Random rand = new Random();
        static System.Security.Cryptography.RNGCryptoServiceProvider rngCsp =
            new System.Security.Cryptography.RNGCryptoServiceProvider();

        static double U = 0, V = 0, S = 0, Trig = 0;
        static double normal_x2;     // Gauss by Fog
        static int phase = 0;
        static bool zeroPhase = true;
        const int NSUM = 25;

        static int GenCallCnt;

        //static bool isTest;

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
                _Multiplier = gaussGenInd == GS_CLT || gaussGenInd == GS_FOG ? 3 : 1;
            }

            readonly byte[] _numbers;
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
        /// <param name="distVars">Gauss or lognorm mean and sigma</param>
        /// <param name="ssVars">Size selection distribution mean and sigma, or null if size selection is inactive</param>
        /// <returns>False if extern CRandom dll is not found, otherwise true</returns>
        public static bool Init(int randGen, int normGen, bool isExp, bool isStdLogNorm,
            float[] distVars, int[] ssVars)
        {
            Library = randGen < FIRST_IND_CSH ? ON_C : (randGen == FIRST_IND_CSH + 1 ? ON_SCH_STRONG : ON_CSH);
            IsExp = isExp;
            DistVars = distVars;
            if (normGen == -1 && !isExp) { DistVars[0] = 0; DistVars[1] = 1000; }

            if (Library == ON_C)
                if (System.IO.File.Exists(CRandom.FullDllFile))
                    CRandom.Init(randGen, normGen, isExp, isStdLogNorm, distVars, ssVars);
                else
                    return false;
            else
            {
                RandomNumb = GetRandom;
                CshStrongRandomGen.RecordGaussGen(normGen);
                Distrib = Distribs[normGen + 1];
            }
            if (ssVars != null)     // size selection is able
            {
                ssMean = ssVars[0];
                //ssDVariance = 2 * ssVars[1] * ssVars[1];
                //ssFactor = ssVars[1] * Math.Sqrt(2 * Math.PI);
                //ssAlignRatio = 2.5 * ssVars[1];

                ssFactor0 = (float)(ssVars[1] * Math.Sqrt(2));
                ssFactor1 = 2.5f / (float)Math.Sqrt(2 * Math.PI);
            }
            else ssMean = 0;

            return true;
        }

        /// <summary>Fills data by current distribution.</summary>
        /// <param name="numbers">Data that should be filled</param>
        /// <param name="cnt">Number or repetitions. Returned the number of random generator calls.</param>
        /// <returns>Average Y value.</returns>
        public static float GetDistrib(Numbers numbers, ref int cnt)		
        {
            GenCallCnt = 0;
            if (Library == ON_C)
            {
                float res = CRandom.GetDistrib(
                    numbers != null ? numbers.Data : null, ref cnt, ref GenCallCnt);
                cnt = GenCallCnt;
                return res;
            }
            else if (Library == ON_SCH_STRONG)
            {
                CshStrongRandomGen gen = new CshStrongRandomGen(cnt);
                RandomNumb = gen.GetNext;
            }
            decimal sum = 0;
            int val;
            int actualCnt = 0;
            double dval;
            float ssDev;  // result of inverse normal distrib
            int min, max;

            for (int i = 0; i < cnt; i++)
            {
                dval = Distrib() * DistVars[1] + DistVars[0];
                if (IsExp)  // lognorm is able
                {
                    val = (int)Math.Exp(dval);

                    if(ssMean > 0) {			// size selection is able
				        // === simple method
                        //if (GetRandom() > ssAlignRatio *
                        //    Math.Exp(-Math.Pow(dval - ssMean, 2) / ssDVariance) / ssFactor)
                        //    continue;		// filter by size selection

				        // === method with using min and max
                        ssDev = ssFactor0 * (float)Math.Sqrt(Math.Log(ssFactor1 / GetRandom()));
                        min = (int)(ssMean - ssDev);
                        max = (int)(ssMean + ssDev);
				        if(val < min || val > max)	
					        continue;		// filter by size selection
                    }
                }
                else // lognorm is disable
                {
                    val = (int)dval;
                    // round up val: otherwise all values will be round down during casting to int.
                    // in this case the distribution will not only be inaccurate,
                    // but worse - values less than 1 will be rounded to 0,
                    // which leads to a falsely large number of zero points.
                    // The variant val = (int)Math.Round(dval, 0) is much slower
                    if (dval > 0) { if (dval - val >= 0.5) val++; }	// round up positives
                    else { if (dval - val <= -0.5) val--; }	// round up negatieves
                }
                sum += val;
                if (numbers != null)
                    numbers.Data[actualCnt] = val;
                actualCnt++;
            }
            cnt = GenCallCnt;
            return (float)sum / actualCnt;
        }


        /// <summary>C# standard random double generator.</summary>
        /// <returns>Random double.</returns>
        static double GetRandom()
        {
            GenCallCnt++;
            return rand.NextDouble();
            //return (double)rand.Next() / int.MaxValue;    // this is a very little slower
        }

        /// <summary>C# standard random int generator.</summary>
        /// <returns>Random double.</returns>
        static int GetIRandom()
        {
            GenCallCnt++;
            return rand.Next();
        }

        # region Gaussian generators

        /// <summary>Gauss generator used Abramowitz and Stegun method.</summary>
        /// <returns></returns>
        /// <see cref="http://c-faq.com/lib/gaussian.html"/>
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

        /// <summary>Gauss generator exploits the Central Limit Theorem.</summary>
        /// <returns></returns>
        /// <see cref="http://c-faq.com/lib/gaussian.html"/>
        static double GaussCLT()
        {
            double x = 0;
            for (int i = 0; i < NSUM; i++)
                x += RandomNumb();
            x -= NSUM / 2.0;
            return x / Math.Sqrt(NSUM / 12.0);
        }

        /// <summary>Gauss generator used modified A. Fog method.</summary>
        /// <returns>alue with gaussian likelihood between about -5 and +5</returns>
        /// <see cref="http://www.esapubs.org/archive/ecol/E094/228/SupplementS1/stoc1.cpp"/>
        /// <see cref="http://www.agner.org/random/"/>
        /// <see cref="http://www.agner.org/random/sampmet.pdf"/>
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

        /// <summary>Gauss generator used Marsaglia method.</summary>
        /// <returns></returns>
        /// <see cref="http://c-faq.com/lib/gaussian.html"/>
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

        // https://www.seehuhn.de/pages/ziggurat.html


        /// <summary>Standard C# Gauss generator.</summary>
        /// <returns></returns>
        static double GaussCshStd()
        {
            return statFormula.InverseNormalDistribution((double)rand.Next(1, int.MaxValue - 1) / int.MaxValue);
            //return statFormula.InverseNormalDistribution(GetRandom()); - doesn't woark because of index exceeding
        }

        #endregion
    }

    /// <summary>Wrapper of random renerator written on C</summary>
    public static class CRandom
    {
        public const string DllFile = "CRandomGen.dll";
        public const string FullDllFile = 
#if DEBUG
        @"..\Release\" + DllFile;
#else
        DllFile;
#endif

        [DllImport(FullDllFile, CallingConvention = CallingConvention.Cdecl)]
        public extern static void Init(int randInd, int normInd, bool isExp,
            bool isStdLogNorm, float[] distVars, int[] ssVars);

        [DllImport(FullDllFile, CallingConvention = CallingConvention.Cdecl)]
        public extern unsafe static float GetDistrib(
            int[] data, ref int cnt, ref int genCallCnt);
    }
}
