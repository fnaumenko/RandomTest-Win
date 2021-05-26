namespace RandomTest
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                tabView.Dispose();
                Graph.Dispose();
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.chkBoxNorm = new System.Windows.Forms.CheckBox();
            this.nmrCountPower = new System.Windows.Forms.NumericUpDown();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.nmrSigma = new System.Windows.Forms.NumericUpDown();
            this.lblSigma = new System.Windows.Forms.Label();
            this.nmrMean = new System.Windows.Forms.NumericUpDown();
            this.lblMean = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblTicker = new System.Windows.Forms.Label();
            this.lblTickerVal = new System.Windows.Forms.Label();
            this.chkBoxLognorm = new System.Windows.Forms.CheckBox();
            this.lblLnM = new System.Windows.Forms.Label();
            this.nmrLnMean = new System.Windows.Forms.NumericUpDown();
            this.lblLnSigma = new System.Windows.Forms.Label();
            this.lblLnMean = new System.Windows.Forms.Label();
            this.lblLnMeanVal = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblXmaxVal = new System.Windows.Forms.Label();
            this.lblTimerVal = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.grpGenerator = new System.Windows.Forms.GroupBox();
            this.cmbBoxRNG = new System.Windows.Forms.ComboBox();
            this.pnlNormal = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBoxNormGen = new System.Windows.Forms.ComboBox();
            this.pnlExp = new System.Windows.Forms.Panel();
            this.nmrLnSigma = new System.Windows.Forms.NumericUpDown();
            this.chkBoxStdLogNorm = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chkBoxAccumGraph = new System.Windows.Forms.CheckBox();
            this.nmrSzSelSigma = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nmrSzSelMean = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.lblModeVal = new System.Windows.Forms.Label();
            this.lblRGenCalls = new System.Windows.Forms.Label();
            this.Graph = new Plot.Plot();
            this.nmrCountBase = new System.Windows.Forms.NumericUpDown();
            this.chkBoxSizeSel = new System.Windows.Forms.CheckBox();
            this.chkBoxGraph = new System.Windows.Forms.CheckBox();
            this.lblMode = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkBoxYLimit = new System.Windows.Forms.CheckBox();
            this.nmrYMin = new System.Windows.Forms.NumericUpDown();
            this.chkBoxXLimit = new System.Windows.Forms.CheckBox();
            this.nmrXMax = new System.Windows.Forms.NumericUpDown();
            this.chkBoxAutoLimit = new System.Windows.Forms.CheckBox();
            this.nmrXMin = new System.Windows.Forms.NumericUpDown();
            this.nmrYMax = new System.Windows.Forms.NumericUpDown();
            this.chkBoxLegend = new System.Windows.Forms.CheckBox();
            this.rBtnGraph = new System.Windows.Forms.RadioButton();
            this.chkBoxGrid = new System.Windows.Forms.CheckBox();
            this.chkBoxSpline = new System.Windows.Forms.CheckBox();
            this.rBtnHist = new System.Windows.Forms.RadioButton();
            this.lblCountPower = new System.Windows.Forms.Label();
            this.pnlSizeSelect = new System.Windows.Forms.Panel();
            this.lsViewResult = new System.Windows.Forms.ListView();
            this.clmn1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmn2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabView = new RandomTest.NeatTabControl();
            this.tabPgLimits = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPgView = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCountPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrLnMean)).BeginInit();
            this.grpGenerator.SuspendLayout();
            this.pnlNormal.SuspendLayout();
            this.pnlExp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrLnSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSzSelSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSzSelMean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCountBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrYMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrXMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrXMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrYMax)).BeginInit();
            this.pnlSizeSelect.SuspendLayout();
            this.tabView.SuspendLayout();
            this.tabPgLimits.SuspendLayout();
            this.tabPgView.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkBoxNorm
            // 
            this.chkBoxNorm.AutoSize = true;
            this.chkBoxNorm.Checked = true;
            this.chkBoxNorm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxNorm.Location = new System.Drawing.Point(5, 2);
            this.chkBoxNorm.Margin = new System.Windows.Forms.Padding(2);
            this.chkBoxNorm.Name = "chkBoxNorm";
            this.chkBoxNorm.Size = new System.Drawing.Size(51, 17);
            this.chkBoxNorm.TabIndex = 103;
            this.chkBoxNorm.Text = "Norm";
            this.toolTip1.SetToolTip(this.chkBoxNorm, "Turn on/off normal distribution");
            this.chkBoxNorm.UseVisualStyleBackColor = true;
            this.chkBoxNorm.CheckedChanged += new System.EventHandler(this.chkBoxNorm_CheckedChanged);
            // 
            // nmrCountPower
            // 
            this.nmrCountPower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nmrCountPower.Location = new System.Drawing.Point(112, 347);
            this.nmrCountPower.Margin = new System.Windows.Forms.Padding(2);
            this.nmrCountPower.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nmrCountPower.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrCountPower.Name = "nmrCountPower";
            this.nmrCountPower.Size = new System.Drawing.Size(28, 20);
            this.nmrCountPower.TabIndex = 14;
            this.toolTip1.SetToolTip(this.nmrCountPower, "Number of cycles: exponent in scientific notation");
            this.nmrCountPower.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(9, 348);
            this.lblCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(41, 13);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "Cycles:";
            this.toolTip1.SetToolTip(this.lblCount, "Number of cycles in scientific notation");
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.Location = new System.Drawing.Point(16, 393);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(125, 34);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Go!";
            this.toolTip1.SetToolTip(this.btnStart, "Start generation");
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // nmrSigma
            // 
            this.nmrSigma.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmrSigma.Location = new System.Drawing.Point(88, 24);
            this.nmrSigma.Margin = new System.Windows.Forms.Padding(2);
            this.nmrSigma.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.nmrSigma.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrSigma.Name = "nmrSigma";
            this.nmrSigma.Size = new System.Drawing.Size(42, 20);
            this.nmrSigma.TabIndex = 2;
            this.toolTip1.SetToolTip(this.nmrSigma, "Standard deviation of the based normal distribution ");
            this.nmrSigma.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // lblSigma
            // 
            this.lblSigma.AutoSize = true;
            this.lblSigma.Location = new System.Drawing.Point(71, 26);
            this.lblSigma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSigma.Name = "lblSigma";
            this.lblSigma.Size = new System.Drawing.Size(18, 13);
            this.lblSigma.TabIndex = 106;
            this.lblSigma.Text = "sd";
            this.toolTip1.SetToolTip(this.lblSigma, "Sigma in normal distribution");
            // 
            // nmrMean
            // 
            this.nmrMean.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmrMean.Location = new System.Drawing.Point(21, 24);
            this.nmrMean.Margin = new System.Windows.Forms.Padding(2);
            this.nmrMean.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.nmrMean.Name = "nmrMean";
            this.nmrMean.Size = new System.Drawing.Size(42, 20);
            this.nmrMean.TabIndex = 1;
            this.toolTip1.SetToolTip(this.nmrMean, "Expectation of the based normal distribution");
            this.nmrMean.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // lblMean
            // 
            this.lblMean.AutoSize = true;
            this.lblMean.Location = new System.Drawing.Point(4, 26);
            this.lblMean.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMean.Name = "lblMean";
            this.lblMean.Size = new System.Drawing.Size(15, 13);
            this.lblMean.TabIndex = 8;
            this.lblMean.Text = "m";
            this.toolTip1.SetToolTip(this.lblMean, "Mean in normal distribution");
            // 
            // lblTicker
            // 
            this.lblTicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTicker.AutoSize = true;
            this.lblTicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTicker.Location = new System.Drawing.Point(4, 453);
            this.lblTicker.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTicker.Name = "lblTicker";
            this.lblTicker.Size = new System.Drawing.Size(78, 13);
            this.lblTicker.TabIndex = 13;
            this.lblTicker.Text = "Ticks/cycle:";
            this.toolTip1.SetToolTip(this.lblTicker, "Number of ticks per cycles");
            // 
            // lblTickerVal
            // 
            this.lblTickerVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTickerVal.AutoSize = true;
            this.lblTickerVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTickerVal.Location = new System.Drawing.Point(80, 451);
            this.lblTickerVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTickerVal.Name = "lblTickerVal";
            this.lblTickerVal.Size = new System.Drawing.Size(17, 17);
            this.lblTickerVal.TabIndex = 14;
            this.lblTickerVal.Text = "0";
            this.toolTip1.SetToolTip(this.lblTickerVal, "Number of ticks per 10 cycles");
            // 
            // chkBoxLognorm
            // 
            this.chkBoxLognorm.AutoSize = true;
            this.chkBoxLognorm.Checked = true;
            this.chkBoxLognorm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxLognorm.Location = new System.Drawing.Point(4, 2);
            this.chkBoxLognorm.Margin = new System.Windows.Forms.Padding(2);
            this.chkBoxLognorm.Name = "chkBoxLognorm";
            this.chkBoxLognorm.Size = new System.Drawing.Size(67, 17);
            this.chkBoxLognorm.TabIndex = 15;
            this.chkBoxLognorm.Text = "Lognorm";
            this.toolTip1.SetToolTip(this.chkBoxLognorm, "Turn on/off lognormal distribution");
            this.chkBoxLognorm.UseVisualStyleBackColor = true;
            this.chkBoxLognorm.CheckedChanged += new System.EventHandler(this.chkBoxLognorm_CheckedChanged);
            // 
            // lblLnM
            // 
            this.lblLnM.AutoSize = true;
            this.lblLnM.Location = new System.Drawing.Point(2, 25);
            this.lblLnM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLnM.Name = "lblLnM";
            this.lblLnM.Size = new System.Drawing.Size(15, 13);
            this.lblLnM.TabIndex = 16;
            this.lblLnM.Text = "m";
            // 
            // nmrLnMean
            // 
            this.nmrLnMean.DecimalPlaces = 2;
            this.nmrLnMean.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nmrLnMean.Location = new System.Drawing.Point(19, 24);
            this.nmrLnMean.Margin = new System.Windows.Forms.Padding(2);
            this.nmrLnMean.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmrLnMean.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrLnMean.Name = "nmrLnMean";
            this.nmrLnMean.Size = new System.Drawing.Size(42, 20);
            this.nmrLnMean.TabIndex = 3;
            this.toolTip1.SetToolTip(this.nmrLnMean, "Power multiplication factor in lognormal distribution ");
            this.nmrLnMean.Value = new decimal(new int[] {
            546,
            0,
            0,
            131072});
            // 
            // lblLnSigma
            // 
            this.lblLnSigma.AutoSize = true;
            this.lblLnSigma.Location = new System.Drawing.Point(66, 25);
            this.lblLnSigma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLnSigma.Name = "lblLnSigma";
            this.lblLnSigma.Size = new System.Drawing.Size(18, 13);
            this.lblLnSigma.TabIndex = 18;
            this.lblLnSigma.Text = "sd";
            // 
            // lblLnMean
            // 
            this.lblLnMean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLnMean.AutoSize = true;
            this.lblLnMean.Location = new System.Drawing.Point(150, 453);
            this.lblLnMean.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLnMean.Name = "lblLnMean";
            this.lblLnMean.Size = new System.Drawing.Size(37, 13);
            this.lblLnMean.TabIndex = 22;
            this.lblLnMean.Text = "Mean:";
            this.toolTip1.SetToolTip(this.lblLnMean, "Expectation (mean X-value)");
            // 
            // lblLnMeanVal
            // 
            this.lblLnMeanVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLnMeanVal.AutoSize = true;
            this.lblLnMeanVal.Location = new System.Drawing.Point(184, 453);
            this.lblLnMeanVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLnMeanVal.Name = "lblLnMeanVal";
            this.lblLnMeanVal.Size = new System.Drawing.Size(13, 13);
            this.lblLnMeanVal.TabIndex = 23;
            this.lblLnMeanVal.Text = "0";
            this.toolTip1.SetToolTip(this.lblLnMeanVal, "Expectation");
            // 
            // lbl1
            // 
            this.lbl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(150, 472);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(39, 13);
            this.lbl1.TabIndex = 24;
            this.lbl1.Text = "X max:";
            this.toolTip1.SetToolTip(this.lbl1, "Maximum X-value");
            // 
            // lblXmaxVal
            // 
            this.lblXmaxVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblXmaxVal.AutoSize = true;
            this.lblXmaxVal.Location = new System.Drawing.Point(184, 472);
            this.lblXmaxVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblXmaxVal.Name = "lblXmaxVal";
            this.lblXmaxVal.Size = new System.Drawing.Size(13, 13);
            this.lblXmaxVal.TabIndex = 25;
            this.lblXmaxVal.Text = "0";
            this.toolTip1.SetToolTip(this.lblXmaxVal, "Maximum Y value");
            // 
            // lblTimerVal
            // 
            this.lblTimerVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTimerVal.AutoSize = true;
            this.lblTimerVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimerVal.Location = new System.Drawing.Point(80, 470);
            this.lblTimerVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimerVal.Name = "lblTimerVal";
            this.lblTimerVal.Size = new System.Drawing.Size(17, 17);
            this.lblTimerVal.TabIndex = 26;
            this.lblTimerVal.Text = "0";
            this.toolTip1.SetToolTip(this.lblTimerVal, "Total generation time in sec");
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimer.Location = new System.Drawing.Point(4, 472);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(76, 13);
            this.lblTimer.TabIndex = 27;
            this.lblTimer.Text = "Gener. time:";
            this.toolTip1.SetToolTip(this.lblTimer, "Total generation time in sec");
            // 
            // grpGenerator
            // 
            this.grpGenerator.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpGenerator.Controls.Add(this.cmbBoxRNG);
            this.grpGenerator.Location = new System.Drawing.Point(7, 10);
            this.grpGenerator.Margin = new System.Windows.Forms.Padding(2);
            this.grpGenerator.Name = "grpGenerator";
            this.grpGenerator.Padding = new System.Windows.Forms.Padding(2);
            this.grpGenerator.Size = new System.Drawing.Size(141, 44);
            this.grpGenerator.TabIndex = 128;
            this.grpGenerator.TabStop = false;
            this.grpGenerator.Text = "Random generator";
            // 
            // cmbBoxRNG
            // 
            this.cmbBoxRNG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxRNG.FormattingEnabled = true;
            this.cmbBoxRNG.Items.AddRange(new object[] {
            "C Mersenne twister",
            "C PCG (O\'Neill)",
            "C std",
            "C XorShift",
            "C# std",
            "C# crypt strong"});
            this.cmbBoxRNG.Location = new System.Drawing.Point(12, 17);
            this.cmbBoxRNG.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBoxRNG.Name = "cmbBoxRNG";
            this.cmbBoxRNG.Size = new System.Drawing.Size(120, 21);
            this.cmbBoxRNG.TabIndex = 102;
            this.toolTip1.SetToolTip(this.cmbBoxRNG, "Select random gen implementation");
            // 
            // pnlNormal
            // 
            this.pnlNormal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlNormal.Controls.Add(this.label2);
            this.pnlNormal.Controls.Add(this.cmbBoxNormGen);
            this.pnlNormal.Controls.Add(this.chkBoxNorm);
            this.pnlNormal.Controls.Add(this.nmrSigma);
            this.pnlNormal.Controls.Add(this.lblMean);
            this.pnlNormal.Controls.Add(this.nmrMean);
            this.pnlNormal.Controls.Add(this.lblSigma);
            this.pnlNormal.Location = new System.Drawing.Point(7, 58);
            this.pnlNormal.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNormal.Name = "pnlNormal";
            this.pnlNormal.Size = new System.Drawing.Size(141, 76);
            this.pnlNormal.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "method";
            // 
            // cmbBoxNormGen
            // 
            this.cmbBoxNormGen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxNormGen.FormattingEnabled = true;
            this.cmbBoxNormGen.Items.AddRange(new object[] {
            "Abramowitz",
            "Central Limit",
            "Fog",
            "Marsaglia",
            "C/C# std"});
            this.cmbBoxNormGen.Location = new System.Drawing.Point(48, 50);
            this.cmbBoxNormGen.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBoxNormGen.Name = "cmbBoxNormGen";
            this.cmbBoxNormGen.Size = new System.Drawing.Size(84, 21);
            this.cmbBoxNormGen.TabIndex = 10;
            this.toolTip1.SetToolTip(this.cmbBoxNormGen, "Select normal distribution implementation");
            // 
            // pnlExp
            // 
            this.pnlExp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlExp.Controls.Add(this.nmrLnSigma);
            this.pnlExp.Controls.Add(this.chkBoxStdLogNorm);
            this.pnlExp.Controls.Add(this.nmrLnMean);
            this.pnlExp.Controls.Add(this.lblLnSigma);
            this.pnlExp.Controls.Add(this.chkBoxLognorm);
            this.pnlExp.Controls.Add(this.lblLnM);
            this.pnlExp.Location = new System.Drawing.Point(7, 137);
            this.pnlExp.Margin = new System.Windows.Forms.Padding(2);
            this.pnlExp.Name = "pnlExp";
            this.pnlExp.Size = new System.Drawing.Size(141, 49);
            this.pnlExp.TabIndex = 32;
            // 
            // nmrLnSigma
            // 
            this.nmrLnSigma.DecimalPlaces = 2;
            this.nmrLnSigma.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nmrLnSigma.Location = new System.Drawing.Point(83, 24);
            this.nmrLnSigma.Margin = new System.Windows.Forms.Padding(2);
            this.nmrLnSigma.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nmrLnSigma.Name = "nmrLnSigma";
            this.nmrLnSigma.Size = new System.Drawing.Size(42, 20);
            this.nmrLnSigma.TabIndex = 22;
            this.toolTip1.SetToolTip(this.nmrLnSigma, "Power summand in lognormal distribution ");
            this.nmrLnSigma.Value = new decimal(new int[] {
            4,
            0,
            0,
            65536});
            // 
            // chkBoxStdLogNorm
            // 
            this.chkBoxStdLogNorm.AutoSize = true;
            this.chkBoxStdLogNorm.Location = new System.Drawing.Point(71, 2);
            this.chkBoxStdLogNorm.Margin = new System.Windows.Forms.Padding(2);
            this.chkBoxStdLogNorm.Name = "chkBoxStdLogNorm";
            this.chkBoxStdLogNorm.Size = new System.Drawing.Size(50, 17);
            this.chkBoxStdLogNorm.TabIndex = 21;
            this.chkBoxStdLogNorm.Text = "C std";
            this.toolTip1.SetToolTip(this.chkBoxStdLogNorm, "Turn on/off C build-in implementation of lognormal distribution");
            this.chkBoxStdLogNorm.UseVisualStyleBackColor = true;
            this.chkBoxStdLogNorm.CheckedChanged += new System.EventHandler(this.chkBoxStdLogNorm_CheckedChanged);
            // 
            // chkBoxAccumGraph
            // 
            this.chkBoxAccumGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkBoxAccumGraph.AutoSize = true;
            this.chkBoxAccumGraph.Checked = true;
            this.chkBoxAccumGraph.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxAccumGraph.Location = new System.Drawing.Point(15, 370);
            this.chkBoxAccumGraph.Margin = new System.Windows.Forms.Padding(2);
            this.chkBoxAccumGraph.Name = "chkBoxAccumGraph";
            this.chkBoxAccumGraph.Size = new System.Drawing.Size(59, 17);
            this.chkBoxAccumGraph.TabIndex = 10;
            this.chkBoxAccumGraph.Text = "Accum";
            this.toolTip1.SetToolTip(this.chkBoxAccumGraph, "Turn on/off charts accumulation");
            this.chkBoxAccumGraph.UseVisualStyleBackColor = true;
            // 
            // nmrSzSelSigma
            // 
            this.nmrSzSelSigma.Enabled = false;
            this.nmrSzSelSigma.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmrSzSelSigma.Location = new System.Drawing.Point(88, 23);
            this.nmrSzSelSigma.Margin = new System.Windows.Forms.Padding(2);
            this.nmrSzSelSigma.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nmrSzSelSigma.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrSzSelSigma.Name = "nmrSzSelSigma";
            this.nmrSzSelSigma.Size = new System.Drawing.Size(39, 20);
            this.nmrSzSelSigma.TabIndex = 6;
            this.toolTip1.SetToolTip(this.nmrSzSelSigma, "Standard deviation of the size selection normal distribution ");
            this.nmrSzSelSigma.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "m";
            this.toolTip1.SetToolTip(this.label7, "Mean in size selection normal distribution");
            // 
            // nmrSzSelMean
            // 
            this.nmrSzSelMean.Enabled = false;
            this.nmrSzSelMean.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmrSzSelMean.Location = new System.Drawing.Point(19, 24);
            this.nmrSzSelMean.Margin = new System.Windows.Forms.Padding(2);
            this.nmrSzSelMean.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrSzSelMean.Name = "nmrSzSelMean";
            this.nmrSzSelMean.Size = new System.Drawing.Size(47, 20);
            this.nmrSzSelMean.TabIndex = 5;
            this.toolTip1.SetToolTip(this.nmrSzSelMean, "Expectation of the size-selection normal distribution (average size of fragment)");
            this.nmrSzSelMean.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "sd";
            this.toolTip1.SetToolTip(this.label8, "Sigma in size selection normal distribution");
            // 
            // lblModeVal
            // 
            this.lblModeVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblModeVal.AutoSize = true;
            this.lblModeVal.Location = new System.Drawing.Point(184, 435);
            this.lblModeVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModeVal.Name = "lblModeVal";
            this.lblModeVal.Size = new System.Drawing.Size(13, 13);
            this.lblModeVal.TabIndex = 37;
            this.lblModeVal.Text = "0";
            this.toolTip1.SetToolTip(this.lblModeVal, "Maximum X value");
            // 
            // lblRGenCalls
            // 
            this.lblRGenCalls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRGenCalls.AutoSize = true;
            this.lblRGenCalls.Location = new System.Drawing.Point(92, 434);
            this.lblRGenCalls.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRGenCalls.Name = "lblRGenCalls";
            this.lblRGenCalls.Size = new System.Drawing.Size(13, 13);
            this.lblRGenCalls.TabIndex = 130;
            this.lblRGenCalls.Text = "0";
            this.toolTip1.SetToolTip(this.lblRGenCalls, "Number of random generator calls for one cycle");
            // 
            // Graph
            // 
            this.Graph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Graph.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.Graph.AxisMargin = ((byte)(3));
            this.Graph.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Graph.CausesValidation = false;
            this.Graph.ExtMargin = ((byte)(5));
            this.Graph.IsSpline = false;
            this.Graph.IsXInteger = false;
            this.Graph.IsYInteger = true;
            this.Graph.LegendMargin = ((byte)(3));
            this.Graph.Location = new System.Drawing.Point(275, 11);
            this.Graph.LowPowerX = ((short)(-2));
            this.Graph.LowPowerY = ((short)(-2));
            this.Graph.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Graph.Mode = Plot.Modes.Graph;
            this.Graph.Name = "Graph";
            this.Graph.PenWidth = 1F;
            this.Graph.ShowBorder = true;
            this.Graph.ShowLegend = false;
            this.Graph.Size = new System.Drawing.Size(588, 479);
            this.Graph.TabIndex = 1;
            this.Graph.TitleMargin = ((byte)(1));
            this.toolTip1.SetToolTip(this.Graph, "Click to refresh charts");
            this.Graph.TopPowerX = ((short)(3));
            this.Graph.TopPowerY = ((short)(3));
            this.Graph.ValueMargin = ((byte)(5));
            // 
            // nmrCountBase
            // 
            this.nmrCountBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nmrCountBase.DecimalPlaces = 1;
            this.nmrCountBase.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nmrCountBase.Location = new System.Drawing.Point(49, 347);
            this.nmrCountBase.Margin = new System.Windows.Forms.Padding(2);
            this.nmrCountBase.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            65536});
            this.nmrCountBase.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrCountBase.Name = "nmrCountBase";
            this.nmrCountBase.Size = new System.Drawing.Size(41, 20);
            this.nmrCountBase.TabIndex = 13;
            this.toolTip1.SetToolTip(this.nmrCountBase, "Number of cycles: significand in scientific notation");
            this.nmrCountBase.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // chkBoxSizeSel
            // 
            this.chkBoxSizeSel.AutoSize = true;
            this.chkBoxSizeSel.Location = new System.Drawing.Point(5, 2);
            this.chkBoxSizeSel.Margin = new System.Windows.Forms.Padding(2);
            this.chkBoxSizeSel.Name = "chkBoxSizeSel";
            this.chkBoxSizeSel.Size = new System.Drawing.Size(91, 17);
            this.chkBoxSizeSel.TabIndex = 38;
            this.chkBoxSizeSel.Text = "Size selection";
            this.toolTip1.SetToolTip(this.chkBoxSizeSel, "Turn on/off fragment size selection");
            this.chkBoxSizeSel.UseVisualStyleBackColor = true;
            this.chkBoxSizeSel.CheckedChanged += new System.EventHandler(this.chkBoxSizeSelect_CheckedChanged);
            // 
            // chkBoxGraph
            // 
            this.chkBoxGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkBoxGraph.AutoSize = true;
            this.chkBoxGraph.Checked = true;
            this.chkBoxGraph.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxGraph.Location = new System.Drawing.Point(83, 370);
            this.chkBoxGraph.Margin = new System.Windows.Forms.Padding(2);
            this.chkBoxGraph.Name = "chkBoxGraph";
            this.chkBoxGraph.Size = new System.Drawing.Size(44, 17);
            this.chkBoxGraph.TabIndex = 131;
            this.chkBoxGraph.Text = "Plot";
            this.toolTip1.SetToolTip(this.chkBoxGraph, "Turn on/off charts output");
            this.chkBoxGraph.UseVisualStyleBackColor = true;
            this.chkBoxGraph.CheckedChanged += new System.EventHandler(this.chkBoxGraph_CheckedChanged);
            // 
            // lblMode
            // 
            this.lblMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(150, 435);
            this.lblMode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(37, 13);
            this.lblMode.TabIndex = 36;
            this.lblMode.Text = "Mode:";
            this.toolTip1.SetToolTip(this.lblMode, "X-coordinate of maximum Y-value");
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 434);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 129;
            this.label3.Text = "RGen calls/cycle:";
            this.toolTip1.SetToolTip(this.label3, "Number of random generator calls for one cycle");
            // 
            // chkBoxYLimit
            // 
            this.chkBoxYLimit.Location = new System.Drawing.Point(0, 29);
            this.chkBoxYLimit.Margin = new System.Windows.Forms.Padding(2);
            this.chkBoxYLimit.Name = "chkBoxYLimit";
            this.chkBoxYLimit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkBoxYLimit.Size = new System.Drawing.Size(26, 16);
            this.chkBoxYLimit.TabIndex = 5;
            this.chkBoxYLimit.Text = "Y";
            this.chkBoxYLimit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.chkBoxYLimit, "Turn on/off Y-scale autoadaption");
            this.chkBoxYLimit.UseVisualStyleBackColor = true;
            this.chkBoxYLimit.CheckedChanged += new System.EventHandler(this.chkBoxYLimit_CheckedChanged);
            // 
            // nmrYMin
            // 
            this.nmrYMin.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nmrYMin.Location = new System.Drawing.Point(30, 29);
            this.nmrYMin.Margin = new System.Windows.Forms.Padding(2);
            this.nmrYMin.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nmrYMin.Name = "nmrYMin";
            this.nmrYMin.Size = new System.Drawing.Size(43, 20);
            this.nmrYMin.TabIndex = 12;
            this.toolTip1.SetToolTip(this.nmrYMin, "Minimum Y-scale value");
            this.nmrYMin.ValueChanged += new System.EventHandler(this.nmrlimit_Changed);
            // 
            // chkBoxXLimit
            // 
            this.chkBoxXLimit.Location = new System.Drawing.Point(0, 7);
            this.chkBoxXLimit.Margin = new System.Windows.Forms.Padding(2);
            this.chkBoxXLimit.Name = "chkBoxXLimit";
            this.chkBoxXLimit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkBoxXLimit.Size = new System.Drawing.Size(26, 16);
            this.chkBoxXLimit.TabIndex = 2;
            this.chkBoxXLimit.Text = "X";
            this.chkBoxXLimit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.chkBoxXLimit, "Turn on/off X-scale autoadaption");
            this.chkBoxXLimit.UseVisualStyleBackColor = true;
            this.chkBoxXLimit.CheckedChanged += new System.EventHandler(this.chkBoxXLimit_CheckedChanged);
            // 
            // nmrXMax
            // 
            this.nmrXMax.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmrXMax.Location = new System.Drawing.Point(83, 6);
            this.nmrXMax.Margin = new System.Windows.Forms.Padding(2);
            this.nmrXMax.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nmrXMax.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nmrXMax.Name = "nmrXMax";
            this.nmrXMax.Size = new System.Drawing.Size(45, 20);
            this.nmrXMax.TabIndex = 11;
            this.toolTip1.SetToolTip(this.nmrXMax, "Maximum X-scale value");
            this.nmrXMax.ValueChanged += new System.EventHandler(this.nmrlimit_Changed);
            // 
            // chkBoxAutoLimit
            // 
            this.chkBoxAutoLimit.AutoSize = true;
            this.chkBoxAutoLimit.Checked = true;
            this.chkBoxAutoLimit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxAutoLimit.Location = new System.Drawing.Point(12, 51);
            this.chkBoxAutoLimit.Margin = new System.Windows.Forms.Padding(2);
            this.chkBoxAutoLimit.Name = "chkBoxAutoLimit";
            this.chkBoxAutoLimit.Size = new System.Drawing.Size(48, 17);
            this.chkBoxAutoLimit.TabIndex = 7;
            this.chkBoxAutoLimit.Text = "Auto";
            this.toolTip1.SetToolTip(this.chkBoxAutoLimit, "Turn on/off scales autoadaption");
            this.chkBoxAutoLimit.UseVisualStyleBackColor = true;
            this.chkBoxAutoLimit.CheckedChanged += new System.EventHandler(this.chkBoxAutoLimit_CheckedChanged);
            // 
            // nmrXMin
            // 
            this.nmrXMin.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmrXMin.Location = new System.Drawing.Point(30, 6);
            this.nmrXMin.Margin = new System.Windows.Forms.Padding(2);
            this.nmrXMin.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nmrXMin.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nmrXMin.Name = "nmrXMin";
            this.nmrXMin.Size = new System.Drawing.Size(43, 20);
            this.nmrXMin.TabIndex = 10;
            this.toolTip1.SetToolTip(this.nmrXMin, "Minimum X-scale value");
            this.nmrXMin.ValueChanged += new System.EventHandler(this.nmrlimit_Changed);
            // 
            // nmrYMax
            // 
            this.nmrYMax.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nmrYMax.Location = new System.Drawing.Point(83, 29);
            this.nmrYMax.Margin = new System.Windows.Forms.Padding(2);
            this.nmrYMax.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nmrYMax.Name = "nmrYMax";
            this.nmrYMax.Size = new System.Drawing.Size(45, 20);
            this.nmrYMax.TabIndex = 13;
            this.toolTip1.SetToolTip(this.nmrYMax, "Maximum Y-scale value");
            this.nmrYMax.ValueChanged += new System.EventHandler(this.nmrlimit_Changed);
            // 
            // chkBoxLegend
            // 
            this.chkBoxLegend.AutoSize = true;
            this.chkBoxLegend.Location = new System.Drawing.Point(52, 8);
            this.chkBoxLegend.Margin = new System.Windows.Forms.Padding(2);
            this.chkBoxLegend.Name = "chkBoxLegend";
            this.chkBoxLegend.Size = new System.Drawing.Size(62, 17);
            this.chkBoxLegend.TabIndex = 11;
            this.chkBoxLegend.Text = "Legend";
            this.toolTip1.SetToolTip(this.chkBoxLegend, "Turn on/off legend output");
            this.chkBoxLegend.UseVisualStyleBackColor = true;
            this.chkBoxLegend.CheckedChanged += new System.EventHandler(this.chkBoxLegend_CheckedChanged);
            // 
            // rBtnGraph
            // 
            this.rBtnGraph.AutoSize = true;
            this.rBtnGraph.Checked = true;
            this.rBtnGraph.Location = new System.Drawing.Point(6, 49);
            this.rBtnGraph.Margin = new System.Windows.Forms.Padding(2);
            this.rBtnGraph.Name = "rBtnGraph";
            this.rBtnGraph.Size = new System.Drawing.Size(54, 17);
            this.rBtnGraph.TabIndex = 1;
            this.rBtnGraph.TabStop = true;
            this.rBtnGraph.Text = "Graph";
            this.toolTip1.SetToolTip(this.rBtnGraph, "View distribution as a function graph");
            this.rBtnGraph.UseVisualStyleBackColor = true;
            this.rBtnGraph.CheckedChanged += new System.EventHandler(this.rBtnGraphs_CheckedChanged);
            // 
            // chkBoxGrid
            // 
            this.chkBoxGrid.AutoSize = true;
            this.chkBoxGrid.Checked = true;
            this.chkBoxGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxGrid.Location = new System.Drawing.Point(6, 8);
            this.chkBoxGrid.Margin = new System.Windows.Forms.Padding(2);
            this.chkBoxGrid.Name = "chkBoxGrid";
            this.chkBoxGrid.Size = new System.Drawing.Size(45, 17);
            this.chkBoxGrid.TabIndex = 3;
            this.chkBoxGrid.Text = "Grid";
            this.toolTip1.SetToolTip(this.chkBoxGrid, "Hide/show grid");
            this.chkBoxGrid.UseVisualStyleBackColor = true;
            this.chkBoxGrid.CheckedChanged += new System.EventHandler(this.chkBoxGrid_CheckedChanged);
            // 
            // chkBoxSpline
            // 
            this.chkBoxSpline.AutoSize = true;
            this.chkBoxSpline.Location = new System.Drawing.Point(58, 49);
            this.chkBoxSpline.Margin = new System.Windows.Forms.Padding(2);
            this.chkBoxSpline.Name = "chkBoxSpline";
            this.chkBoxSpline.Size = new System.Drawing.Size(55, 17);
            this.chkBoxSpline.TabIndex = 4;
            this.chkBoxSpline.Text = "Spline";
            this.toolTip1.SetToolTip(this.chkBoxSpline, "Turn on/off line smoothness");
            this.chkBoxSpline.UseVisualStyleBackColor = true;
            this.chkBoxSpline.CheckedChanged += new System.EventHandler(this.chkBoxSpline_CheckedChanged);
            // 
            // rBtnHist
            // 
            this.rBtnHist.AutoSize = true;
            this.rBtnHist.Location = new System.Drawing.Point(6, 29);
            this.rBtnHist.Margin = new System.Windows.Forms.Padding(2);
            this.rBtnHist.Name = "rBtnHist";
            this.rBtnHist.Size = new System.Drawing.Size(72, 17);
            this.rBtnHist.TabIndex = 0;
            this.rBtnHist.Text = "Histogram";
            this.toolTip1.SetToolTip(this.rBtnHist, "View distribution as a histogram");
            this.rBtnHist.UseVisualStyleBackColor = true;
            this.rBtnHist.CheckedChanged += new System.EventHandler(this.rBtnGraphs_CheckedChanged);
            // 
            // lblCountPower
            // 
            this.lblCountPower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCountPower.AutoSize = true;
            this.lblCountPower.Location = new System.Drawing.Point(94, 348);
            this.lblCountPower.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountPower.Name = "lblCountPower";
            this.lblCountPower.Size = new System.Drawing.Size(14, 13);
            this.lblCountPower.TabIndex = 35;
            this.lblCountPower.Text = "E";
            // 
            // pnlSizeSelect
            // 
            this.pnlSizeSelect.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlSizeSelect.Controls.Add(this.nmrSzSelSigma);
            this.pnlSizeSelect.Controls.Add(this.label7);
            this.pnlSizeSelect.Controls.Add(this.nmrSzSelMean);
            this.pnlSizeSelect.Controls.Add(this.label8);
            this.pnlSizeSelect.Controls.Add(this.chkBoxSizeSel);
            this.pnlSizeSelect.Location = new System.Drawing.Point(7, 190);
            this.pnlSizeSelect.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSizeSelect.Name = "pnlSizeSelect";
            this.pnlSizeSelect.Size = new System.Drawing.Size(141, 49);
            this.pnlSizeSelect.TabIndex = 39;
            // 
            // lsViewResult
            // 
            this.lsViewResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmn1,
            this.clmn2});
            this.lsViewResult.HideSelection = false;
            this.lsViewResult.Location = new System.Drawing.Point(153, 10);
            this.lsViewResult.Name = "lsViewResult";
            this.lsViewResult.Size = new System.Drawing.Size(117, 417);
            this.lsViewResult.TabIndex = 133;
            this.lsViewResult.UseCompatibleStateImageBehavior = false;
            // 
            // clmn1
            // 
            this.clmn1.Text = "Value";
            // 
            // clmn2
            // 
            this.clmn2.Text = "Freq";
            // 
            // tabView
            // 
            this.tabView.Controls.Add(this.tabPgLimits);
            this.tabView.Controls.Add(this.tabPgView);
            this.tabView.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabView.ItemSize = new System.Drawing.Size(100, 21);
            this.tabView.Location = new System.Drawing.Point(7, 243);
            this.tabView.Margin = new System.Windows.Forms.Padding(2);
            this.tabView.Name = "tabView";
            this.tabView.SelectedIndex = 0;
            this.tabView.Size = new System.Drawing.Size(140, 97);
            this.tabView.TabIndex = 132;
            // 
            // tabPgLimits
            // 
            this.tabPgLimits.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPgLimits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPgLimits.Controls.Add(this.chkBoxYLimit);
            this.tabPgLimits.Controls.Add(this.nmrYMin);
            this.tabPgLimits.Controls.Add(this.chkBoxXLimit);
            this.tabPgLimits.Controls.Add(this.label10);
            this.tabPgLimits.Controls.Add(this.nmrXMax);
            this.tabPgLimits.Controls.Add(this.label6);
            this.tabPgLimits.Controls.Add(this.chkBoxAutoLimit);
            this.tabPgLimits.Controls.Add(this.nmrXMin);
            this.tabPgLimits.Controls.Add(this.nmrYMax);
            this.tabPgLimits.Location = new System.Drawing.Point(4, 25);
            this.tabPgLimits.Margin = new System.Windows.Forms.Padding(2);
            this.tabPgLimits.Name = "tabPgLimits";
            this.tabPgLimits.Padding = new System.Windows.Forms.Padding(2);
            this.tabPgLimits.Size = new System.Drawing.Size(132, 68);
            this.tabPgLimits.TabIndex = 0;
            this.tabPgLimits.Text = "Ranges";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 30);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "–";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "–";
            // 
            // tabPgView
            // 
            this.tabPgView.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPgView.Controls.Add(this.chkBoxLegend);
            this.tabPgView.Controls.Add(this.rBtnGraph);
            this.tabPgView.Controls.Add(this.chkBoxGrid);
            this.tabPgView.Controls.Add(this.chkBoxSpline);
            this.tabPgView.Controls.Add(this.rBtnHist);
            this.tabPgView.Location = new System.Drawing.Point(4, 25);
            this.tabPgView.Margin = new System.Windows.Forms.Padding(2);
            this.tabPgView.Name = "tabPgView";
            this.tabPgView.Padding = new System.Windows.Forms.Padding(2);
            this.tabPgView.Size = new System.Drawing.Size(132, 68);
            this.tabPgView.TabIndex = 1;
            this.tabPgView.Text = "View";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(865, 496);
            this.Controls.Add(this.lsViewResult);
            this.Controls.Add(this.tabView);
            this.Controls.Add(this.chkBoxGraph);
            this.Controls.Add(this.lblRGenCalls);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlSizeSelect);
            this.Controls.Add(this.chkBoxAccumGraph);
            this.Controls.Add(this.lblModeVal);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.lblCountPower);
            this.Controls.Add(this.nmrCountBase);
            this.Controls.Add(this.pnlExp);
            this.Controls.Add(this.pnlNormal);
            this.Controls.Add(this.grpGenerator);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblTimerVal);
            this.Controls.Add(this.lblXmaxVal);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblLnMeanVal);
            this.Controls.Add(this.lblLnMean);
            this.Controls.Add(this.lblTickerVal);
            this.Controls.Add(this.lblTicker);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.nmrCountPower);
            this.Controls.Add(this.Graph);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(702, 535);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Generator Test";
            this.toolTip1.SetToolTip(this, "Random, normal and lognormal test");
            ((System.ComponentModel.ISupportInitialize)(this.nmrCountPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrLnMean)).EndInit();
            this.grpGenerator.ResumeLayout(false);
            this.pnlNormal.ResumeLayout(false);
            this.pnlNormal.PerformLayout();
            this.pnlExp.ResumeLayout(false);
            this.pnlExp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrLnSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSzSelSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSzSelMean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCountBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrYMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrXMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrXMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrYMax)).EndInit();
            this.pnlSizeSelect.ResumeLayout(false);
            this.pnlSizeSelect.PerformLayout();
            this.tabView.ResumeLayout(false);
            this.tabPgLimits.ResumeLayout(false);
            this.tabPgLimits.PerformLayout();
            this.tabPgView.ResumeLayout(false);
            this.tabPgView.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Plot.Plot Graph;
        private System.Windows.Forms.NumericUpDown nmrCountPower;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown nmrSigma;
        private System.Windows.Forms.Label lblSigma;
        private System.Windows.Forms.NumericUpDown nmrMean;
        private System.Windows.Forms.Label lblMean;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTicker;
        private System.Windows.Forms.Label lblTickerVal;
        private System.Windows.Forms.CheckBox chkBoxLognorm;
        private System.Windows.Forms.Label lblLnM;
        private System.Windows.Forms.NumericUpDown nmrLnMean;
        private System.Windows.Forms.Label lblLnSigma;
        private System.Windows.Forms.Label lblLnMean;
        private System.Windows.Forms.Label lblLnMeanVal;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblXmaxVal;
        private System.Windows.Forms.Label lblTimerVal;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.GroupBox grpGenerator;
        private System.Windows.Forms.CheckBox chkBoxNorm;
        private System.Windows.Forms.CheckBox chkBoxGrid;
        private System.Windows.Forms.Panel pnlNormal;
        private System.Windows.Forms.Panel pnlExp;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox chkBoxStdLogNorm;
        private System.Windows.Forms.RadioButton rBtnHist;
        private System.Windows.Forms.RadioButton rBtnGraph;
        private System.Windows.Forms.CheckBox chkBoxSpline;
        private System.Windows.Forms.NumericUpDown nmrCountBase;
        private System.Windows.Forms.Label lblCountPower;
        private System.Windows.Forms.ComboBox cmbBoxNormGen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBoxRNG;
        private System.Windows.Forms.NumericUpDown nmrXMax;
        private System.Windows.Forms.CheckBox chkBoxAutoLimit;
        private System.Windows.Forms.NumericUpDown nmrYMax;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label lblModeVal;
        private System.Windows.Forms.CheckBox chkBoxAccumGraph;
        private System.Windows.Forms.CheckBox chkBoxSizeSel;
        private System.Windows.Forms.Panel pnlSizeSelect;
        private System.Windows.Forms.NumericUpDown nmrSzSelSigma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmrSzSelMean;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkBoxLegend;
        private System.Windows.Forms.NumericUpDown nmrYMin;
        private System.Windows.Forms.NumericUpDown nmrXMin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkBoxXLimit;
        private System.Windows.Forms.CheckBox chkBoxYLimit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRGenCalls;
        private System.Windows.Forms.CheckBox chkBoxGraph;
        private System.Windows.Forms.NumericUpDown nmrLnSigma;
        private NeatTabControl tabView;
        private System.Windows.Forms.TabPage tabPgLimits;
        private System.Windows.Forms.TabPage tabPgView;
        private System.Windows.Forms.ListView lsViewResult;
        private System.Windows.Forms.ColumnHeader clmn1;
        private System.Windows.Forms.ColumnHeader clmn2;
    }
}

