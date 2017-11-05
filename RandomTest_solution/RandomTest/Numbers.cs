using System;

namespace RandomTest
{
    /// <summary>
    /// Collection of numbers, supplied with the method returned numbers frequencies.
    /// </summary>
    public class Numbers
    {
        System.Drawing.PointF[] _pts = null;    // numbers frequencies
        public short[] Data;

        public Numbers(int count)
        {
            Data = new short[count];
        }

        /// <summary>
        /// Gets the array of floating-points represented collection of points, 
        /// where each point represents a value (X) and its frequency (Y).
        /// </summary>
        public System.Drawing.PointF[] Freqs
        {
            get
            {
                if (_pts == null)
                    SetPoints();
                return _pts;
            }
        }

         /// <summary>Sets Points collection.</summary>
        void SetPoints()
        {
            Array.Sort(Data);

            int i, startInd = 0, ind = 0, amount;
            short currVal, prevVal;

            // get precise size of point array
            for (i = amount = 0; i < Data.Length - 1; i++)
                //if (Data[i] == 0)     // exclude zero values
                //    startInd++;
                //else
                    if (Data[i] != Data[i + 1])
                        amount++;
            _pts = new System.Drawing.PointF[amount+1];

            // fill point array, excluding point with zero X
            prevVal = Data[startInd];
            amount = 1;
            for (i = startInd+1; i < Data.Length; amount++, i++)
                if ((currVal=Data[i]) != prevVal)
                {
                    SetPoint(ind++, prevVal, amount);
                    amount = 0;
                    prevVal = currVal;
                }
            SetPoint(ind, prevVal, amount);   // finally the last Point
        }

        /// <summary>Set Point and _maxYValue.</summary>
        /// <param name="ptIndex">Point index in _pts</param>
        /// <param name="X">X-value.</param>
        /// <param name="Y">Y-value.</param>
        void SetPoint(int ptIndex, float X, int Y)
        {
            _pts[ptIndex].X = X;
            _pts[ptIndex].Y = Y;
        }
    }
}
