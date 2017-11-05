using System;
using System.Diagnostics;

using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RandomTest
{
    public partial class MainForm : Form
    {
        const string titleX = "Value", titleY = "Frequency";
        Numbers numbers;
        Plot.Modes[] modes = { Plot.Modes.Histogram, Plot.Modes.Graph };
        Stopwatch stopwatch = new Stopwatch();
        /// <summary>the MainForm width without Plot</summary>
        int npGraphWidth;
        /// <summary>keeps the initial MainForm Minimum Size Width  to restore after shrinking</summary>
        int minWidth;

        public MainForm()
        {
            InitializeComponent();

            #region Members initialize
            npGraphWidth = Width - Graph.Width;
            minWidth = this.MinimumSize.Width;
            #endregion
            #region Controls initialize

            tabView.Initialize();
            chkBoxSpline.Enabled = rBtnGraph.Checked;
            pnlNormalEnabled = chkBoxNorm.Checked;
            cmbBoxRandGen.SelectedIndex = 3;
            cmbBoxNormCode.SelectedIndex = 2;
            pnlExpEnabled = chkBoxExp.Checked;
            NormDistPanelAutoEnabled();
            LognormDistPanelAutoEnabled();
            tabNmrLimitsEnabled = !chkBoxAutoLimit.Checked;
            ClearLabels();
            
            #endregion
            #region Graph initialize

            Graph.Init(titleX, titleY, "m^2", "s^2");
            Graph.LowPowerX = 2;
            Graph.PenWidth = 4;
            Graph.Mode = rBtnHist.Checked ? Plot.Modes.Histogram : Plot.Modes.Graph;
            Graph.ShowBorder = true;
            Graph.ShowGrid = chkBoxGrid.Checked;
            Graph.IsSpline = chkBoxSpline.Checked;
            if (!chkBoxAutoLimit.Checked)
                PlotSetLimits(false);
            //Graph.ShowLegend = chkBoxLegend.Checked = chkBoxAccumGraph.Checked;
            #endregion
        }

        public new void Dispose()
        {
            Graph.Dispose();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            # region Initialize Random Generator

            if (!RandomGen.Init(
                cmbBoxRandGen.SelectedIndex,
                chkBoxNorm.Checked ? cmbBoxNormCode.SelectedIndex : -1,
                chkBoxExp.Checked,
                chkBoxStdLogNorm.Checked,
                (int)nmrMean.Value,
                (int)nmrSigma.Value,
                (int)nmrDivisor.Value,
                (float)nmrAdd.Value,
                (int)nmrSzSelMean.Value,
                (int)nmrSzSelSigma.Value,
                (int)nmrDev.Value
                ))
            {
                MessageBoxShow(String.Format(
                    "Extern C-library {0} is not found.\nYou should use C# random generator only.", CRandom.DllFile),
                    "Missing " + CRandom.DllFile);
                goto end;
            }
            #endregion
            #region Froze controls
            ClearLabels();
            AllControlsEnabled = false;
            txtBoxResult.Clear();
            if (!chkBoxAccumGraph.Checked)
                Graph.Clear();
            #endregion
            #region Allocate numbers array

            int count = (int)(nmrCountBase.Value * (int)Math.Pow(10, Convert.ToDouble(nmrCountPower.Value)));
            int randGenCnt = count;
            if (chkBoxGraph.Checked)
            {
                try { numbers = new Numbers(count); }
                catch (OutOfMemoryException)
                {
                    MessageBoxShow(String.Format(
                        "Not enough memory to visualize {0:0.###E0} cycles.\nTurn off Graphics and try again.", count),
                        "Out of memory");
                    goto end;
                }
                Graph.DrawScreenSaver("generate...");
            }
            else
                numbers = null;
            #endregion
            
            stopwatch.Reset();
            stopwatch.Start();
            float average = RandomGen.GetDistrib(numbers, ref randGenCnt);
            stopwatch.Stop();

            #region Timer output
            TimeSpan ts = stopwatch.Elapsed;
            LblOutput(lblTickerVal, (ts.Ticks / (count / 10)).ToString());
            LblOutput(lblTimerVal, ts.ToString(@"mm\:ss\.ff"));
            LblOutput(lblLnMeanVal, average.ToString("0.##"));
            LblOutput(lblRGenCalls, randGenCnt > 0 ?
                ((float)randGenCnt / count).ToString("0.##") : "undef");
            #endregion

            if (chkBoxGraph.Checked)
            {
                #region Fill Result text box
                Graph.DrawScreenSaver("prepaire output...");

                int freqsCnt = numbers.Freqs.Length;
                string[] lines = new string[freqsCnt + 2];
                lines[0] = titleX + "\tFreq";
                int i = 2;
                float maxY = 0;
                foreach (PointF p in numbers.Freqs)
                {
                    lines[i++] = p.X.ToString() + '\t' + p.Y.ToString();
                    if (maxY < p.Y)
                        maxY = p.Y;
                }
                txtBoxResult.Lines = lines;
                lblXmax.Text = numbers.Freqs[freqsCnt - 1].X.ToString();
                lblYmax.Text = maxY.ToString();
                #endregion

                try
                {
                    Graph.DrawPlot(numbers.Freqs, count.ToString(count > 1000 ? "0.###e+0" : "G") + " cycles");// + testNumb++.ToString());
                }
                catch (ApplicationException exc)
                {
                    Graph.DrawScreenSaver(string.Empty);
                    MessageBoxShow(exc.Message, "Bad distribution");
                    goto end;
                }
                
                if (chkBoxAutoLimit.Checked)
                {
                    nmrXMin.Value = (decimal)Graph.MinXValue;
                    nmrYMin.Value = (decimal)Graph.MinYValue;
                    nmrXMax.Value = (decimal)Graph.MaxXValue;
                    nmrYMax.Value = (decimal)Graph.MaxYValue;
                }
            }
end:        AllControlsEnabled = true;
        }

        void MessageBoxShow(string msg, string caption)
        {
            MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #region Panel enabling managment

        private bool AllControlsEnabled
        {
            set
            {
                grpGenerator.Enabled = value;
                pnlNormal.Enabled = value;
                pnlExp.Enabled = value;
                tabView.Enabled = value;
                lblCount.Enabled = lblCountPower.Enabled = value;
                nmrCountBase.Enabled = nmrCountPower.Enabled = value;
                chkBoxGraph.Enabled = chkBoxAccumGraph.Enabled = value;
                btnStart.Enabled = value;
                this.Cursor = value ? Cursors.Default : Cursors.WaitCursor;
            }
        }

        void ClearLabels()
        {
            lblLnMeanVal.Text = lblXmax.Text = lblYmax.Text = lblRGenCalls.Text = lblTickerVal.Text = lblTimerVal.Text = string.Empty;
        }

        private void LblOutput(Label lblBox, string msg)
        {
            lblBox.Text = msg;
            lblBox.Refresh();
        }

        private bool pnlNormalEnabled
        {
            set
            {
                cmbBoxNormCode.Enabled =
                nmrSigma.Enabled =
                nmrMean.Enabled = value;
            }
        }

        private bool pnlExpEnabled
        {
            set
            {
                nmrDivisor.Enabled = nmrAdd.Enabled = chkBoxStdLogNorm.Enabled = value;
            }
        }

        private bool pnlSzSelEnabled
        {
            set
            {
                nmrSzSelMean.Enabled = nmrSzSelSigma.Enabled = nmrDev.Enabled = value;
            }
        }

        /// <summary>Sets Enabled property of all control in "normal distr panel".</summary>
        /// <remarks>"Normal distr panel" is not a control, but the conditional group of controls.</remarks>
        private void NormDistPanelAutoEnabled()
        {
            if (cmbBoxNormCode.SelectedIndex == 4)  // Std Gauss code
                cmbBoxRandGen.SelectedIndex = 2;
        }

        /// <summary>Sets Enabled property of all control in "lognormal distr panel".</summary>
        /// <remarks>"Lognormal distr panel" is not a control, but the conditional group of controls.</remarks>
        private void LognormDistPanelAutoEnabled()
        {
            if (chkBoxStdLogNorm.Checked)
                cmbBoxRandGen.SelectedIndex = 1;
            cmbBoxRandGen.Enabled =
            chkBoxNorm.Enabled =
            cmbBoxNormCode.Enabled = !chkBoxStdLogNorm.Checked;
        }

        #endregion
        #region Plot management

        /// <summary>Refreshes the plot if there is some data.</summary>
        private void PlotRefresh()
        {
            if (numbers != null)
                Graph.Refresh();
        }
        #endregion
        #region Driving controls

        private void chkBoxNorm_CheckedChanged(object sender, EventArgs e)
        {
            pnlNormalEnabled = chkBoxNorm.Checked;
        }

        private void chkBoxExp_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkBoxExp.Checked)
                chkBoxStdLogNorm.Checked = false;
            pnlExpEnabled = chkBoxExp.Checked;
        }

        private void chkBoxGrid_CheckedChanged(object sender, EventArgs e)
        {
            Graph.ShowGrid = chkBoxGrid.Checked;
        }

        private void rBtnStd_CheckedChanged(object sender, EventArgs e)
        {
            NormDistPanelAutoEnabled();
        }

        private void chkBoxStdLogNorm_CheckedChanged(object sender, EventArgs e)
        {
            LognormDistPanelAutoEnabled();
        }

        private void chkBoxSizeSelect_CheckedChanged(object sender, EventArgs e)
        {
            pnlSzSelEnabled = chkBoxSizeSelect.Checked;
        }

        #endregion
        #region Limits controls

        bool nmrXLimitsEnabled
        {
            set { nmrXMin.Enabled = nmrXMax.Enabled = value; }
        }

        bool nmrYLimitsEnabled
        {
            set { nmrYMin.Enabled = nmrYMax.Enabled = value; }
        }

        bool tabNmrLimitsEnabled
        {
            set
            {
                chkBoxXLimit.Enabled = chkBoxYLimit.Enabled = value;
                if (value)
                {
                    nmrXLimitsEnabled = !chkBoxXLimit.Checked;
                    nmrYLimitsEnabled = !chkBoxYLimit.Checked;
                }
                else
                    nmrXLimitsEnabled = nmrYLimitsEnabled = false;
            }
        }

        /// <summary>Sets plot limits.</summary>
        /// <param name="refresh">True if Plot shuld be refreshed after limits seting.</param>
        /// <returns>True if limits are validated.</returns>
        bool PlotSetLimits(bool refresh)
        {
            //try
            //{
                Graph.SetLimits(
                    nmrXMin.Enabled ? (int)nmrXMin.Value : Plot.Limits.AutoLimit,
                    nmrXMax.Enabled ? (int)nmrXMax.Value : Plot.Limits.AutoLimit,
                    nmrYMin.Enabled ? (int)nmrYMin.Value : Plot.Limits.AutoLimit,
                    nmrYMax.Enabled ? (int)nmrYMax.Value : Plot.Limits.AutoLimit
                );
            //}
            //catch (ArgumentException exc)
            //{
            //    MessageBoxShow(exc.Message, "Wrong axis limit");
            //    return false;
            //}
            if(refresh)     PlotRefresh();
            return true;
        }

        private void chkBoxAutoLimit_CheckedChanged(object sender, EventArgs e)
        {
            tabNmrLimitsEnabled = !chkBoxAutoLimit.Checked;
            PlotSetLimits(true);
        }

        private void chkBoxXLimit_CheckedChanged(object sender, EventArgs e)
        {
            nmrXLimitsEnabled = !chkBoxXLimit.Checked;
            PlotSetLimits(true);
        }

        private void chkBoxYLimit_CheckedChanged(object sender, EventArgs e)
        {
            nmrYLimitsEnabled = !chkBoxYLimit.Checked;
            PlotSetLimits(true);
        }

        /// <summary>Gets NumericUpDown control from tabPgLimits by TabIndex.</summary>
        /// <param name="index">Tab index</param>
        /// <returns>NumericUpDown control or null.</returns>
        NumericUpDown GetNmrUpDownByTabIndex(int index)
        {
            return tabPgLimits.Controls
                    .Cast<Control>()    // or .OfType<Control>()
                    .Where(r => r.TabIndex == index).First() as NumericUpDown;
        }

        void PlayNotify()
        {
            System.Media.SoundPlayer simpleSound = new System.Media.SoundPlayer(
                @"c:\Windows\Media\notify.wav");
            simpleSound.Play();
        }

        /// <summary>The minimal allowed difference between min/max limits.</summary>
        const int MIN_LIM_RANGE = 2;

        private void nmrlimit_Changed(object sender, EventArgs e)
        {
            // numerics should have even TabIndex for min limit, and uneven for max one!
            NumericUpDown nmr1 = sender as NumericUpDown;
            if (nmr1.Enabled)
            {
                // check that the minimum limit is always less than the maximum one by at least MIN_LIM_RANGE
                NumericUpDown[] nmrs = new NumericUpDown[2];
                int ind = nmr1.TabIndex % 2;  // ind=0: min limit, ind=1: max limit
                nmrs[ind] = nmr1;
                nmrs[1-ind] = GetNmrUpDownByTabIndex(nmr1.TabIndex - 2*ind + 1);
                // check and correct the user-entered value
                if (nmrs[0].Value > nmrs[1].Value - MIN_LIM_RANGE)
                {
                    nmrs[ind].Value = nmrs[1-ind].Value + MIN_LIM_RANGE * (2*ind - 1);
                    PlayNotify();
                }
                PlotSetLimits(true);
            }
        }

        #endregion
        #region View controls

        private void rBtnGraphs_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                Graph.Mode = modes[((RadioButton)sender).TabIndex];
                PlotRefresh();
            }
            chkBoxSpline.Enabled = rBtnGraph.Checked;
        }

        private void chkBoxSpline_CheckedChanged(object sender, EventArgs e)
        {
            Graph.IsSpline = ((CheckBox)sender).Checked;
            PlotRefresh();
        }

        private void chkBoxLegend_CheckedChanged(object sender, EventArgs e)
        {
            Graph.ShowLegend = chkBoxLegend.Checked;
            PlotRefresh();
        }
         
        //private void chkBoxAccumGraph_CheckedChanged(object sender, EventArgs e)
        //{
        //    chkBoxLegend.Checked = chkBoxAccumGraph.Checked;
        //}

        #endregion

        Size SetSize(int newWidth)
        {
            Size sz = MinimumSize;
            sz.Width = newWidth;
            MinimumSize = sz;
            Width = newWidth;
            return sz;
        }

        private void chkBoxGraph_CheckedChanged(object sender, EventArgs e)
        {
            tabView.Enabled = chkBoxAccumGraph.Enabled = chkBoxGraph.Checked;
            if (chkBoxGraph.Checked)
            {
                MaximumSize = Size.Empty;
                SetSize(minWidth);
            }
            else
                MaximumSize = SetSize(npGraphWidth);
        }
 
        #region BackgroundWorker: commented
        //private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    // Do not access the form's BackgroundWorker reference directly.
        //    // Instead, use the reference provided by the sender parameter.
        //    BackgroundWorker bw = sender as BackgroundWorker;

        //    e.Result = Make(bw);

        //    // If the operation was canceled by the user, set the DoWorkEventArgs.Cancel property to true.
        //    if (bw.CancellationPending)
        //        e.Cancel = true;
        //}

        //private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        //{
        //    //Console.Beep();
        //    //if (e.Cancelled)            // The user canceled the operation.
        //    //{
        //    //    AllControlsEnabled = true;
        //    //}
        //    //else
        //    //{
        //    //    if (e.Error == null)    // The operation completed normally.
        //    //    {
        //    //        AllControlsEnabled = true;
        //    //    }
        //    //    // if the process was canceled by the user, e.Result has not a string value
        //    //    //stsBarPnlStatus.Text = e.Result as string;
        //    //}
        //    AllControlsEnabled = true;
        //}
        #endregion
    }
}
