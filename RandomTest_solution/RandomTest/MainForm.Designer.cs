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
            this.chkBoxExp = new System.Windows.Forms.CheckBox();
            this.lblFormula1 = new System.Windows.Forms.Label();
            this.nmrDivisor = new System.Windows.Forms.NumericUpDown();
            this.lblPlus = new System.Windows.Forms.Label();
            this.lblBracket = new System.Windows.Forms.Label();
            this.txtBoxResult = new System.Windows.Forms.RichTextBox();
            this.lblLnMean = new System.Windows.Forms.Label();
            this.lblLnMeanVal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblYmax = new System.Windows.Forms.Label();
            this.lblTimerVal = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.grpGenerator = new System.Windows.Forms.GroupBox();
            this.cmbBoxRandGen = new System.Windows.Forms.ComboBox();
            this.pnlNormal = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBoxNormCode = new System.Windows.Forms.ComboBox();
            this.pnlExp = new System.Windows.Forms.Panel();
            this.nmrAdd = new System.Windows.Forms.NumericUpDown();
            this.chkBoxStdLogNorm = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chkBoxAccumGraph = new System.Windows.Forms.CheckBox();
            this.nmrSzSelSigma = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nmrSzSelMean = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nmrDev = new System.Windows.Forms.NumericUpDown();
            this.lblXmax = new System.Windows.Forms.Label();
            this.lblRGenCalls = new System.Windows.Forms.Label();
            this.Graph = new Plot.Plot();
            this.nmrCountBase = new System.Windows.Forms.NumericUpDown();
            this.chkBoxSizeSelect = new System.Windows.Forms.CheckBox();
            this.chkBoxGraph = new System.Windows.Forms.CheckBox();
            this.lblCountPower = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlSizeSelect = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tabView = new RandomTest.NeatTabControl();
            this.tabPgLimits = new System.Windows.Forms.TabPage();
            this.chkBoxYLimit = new System.Windows.Forms.CheckBox();
            this.nmrYMin = new System.Windows.Forms.NumericUpDown();
            this.chkBoxXLimit = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nmrXMax = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.chkBoxAutoLimit = new System.Windows.Forms.CheckBox();
            this.nmrXMin = new System.Windows.Forms.NumericUpDown();
            this.nmrYMax = new System.Windows.Forms.NumericUpDown();
            this.tabPgView = new System.Windows.Forms.TabPage();
            this.chkBoxLegend = new System.Windows.Forms.CheckBox();
            this.rBtnGraph = new System.Windows.Forms.RadioButton();
            this.chkBoxGrid = new System.Windows.Forms.CheckBox();
            this.chkBoxSpline = new System.Windows.Forms.CheckBox();
            this.rBtnHist = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCountPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDivisor)).BeginInit();
            this.grpGenerator.SuspendLayout();
            this.pnlNormal.SuspendLayout();
            this.pnlExp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSzSelSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSzSelMean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCountBase)).BeginInit();
            this.pnlSizeSelect.SuspendLayout();
            this.tabView.SuspendLayout();
            this.tabPgLimits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrYMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrXMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrXMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrYMax)).BeginInit();
            this.tabPgView.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkBoxNorm
            // 
            this.chkBoxNorm.AutoSize = true;
            this.chkBoxNorm.Checked = true;
            this.chkBoxNorm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxNorm.Location = new System.Drawing.Point(7, 3);
            this.chkBoxNorm.Name = "chkBoxNorm";
            this.chkBoxNorm.Size = new System.Drawing.Size(64, 21);
            this.chkBoxNorm.TabIndex = 103;
            this.chkBoxNorm.Text = "Norm";
            this.toolTip1.SetToolTip(this.chkBoxNorm, "Turn on/off normal distribution");
            this.chkBoxNorm.UseVisualStyleBackColor = true;
            this.chkBoxNorm.CheckedChanged += new System.EventHandler(this.chkBoxNorm_CheckedChanged);
            // 
            // nmrCountPower
            // 
            this.nmrCountPower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nmrCountPower.Location = new System.Drawing.Point(132, 459);
            this.nmrCountPower.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nmrCountPower.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrCountPower.Name = "nmrCountPower";
            this.nmrCountPower.Size = new System.Drawing.Size(28, 22);
            this.nmrCountPower.TabIndex = 14;
            this.toolTip1.SetToolTip(this.nmrCountPower, "Number of cycles: exponent  in scientific notation");
            this.nmrCountPower.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(18, 460);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(53, 17);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "Cycles:";
            this.toolTip1.SetToolTip(this.lblCount, "Number of cycles in scientific notation");
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.Location = new System.Drawing.Point(19, 516);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(141, 42);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Go!";
            this.toolTip1.SetToolTip(this.btnStart, "Start generator");
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
            this.nmrSigma.Location = new System.Drawing.Point(100, 30);
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
            this.nmrSigma.Size = new System.Drawing.Size(52, 22);
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
            this.lblSigma.Location = new System.Drawing.Point(82, 31);
            this.lblSigma.Name = "lblSigma";
            this.lblSigma.Size = new System.Drawing.Size(15, 17);
            this.lblSigma.TabIndex = 106;
            this.lblSigma.Text = "s";
            this.toolTip1.SetToolTip(this.lblSigma, "Sigma in normal distribution");
            // 
            // nmrMean
            // 
            this.nmrMean.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmrMean.Location = new System.Drawing.Point(25, 29);
            this.nmrMean.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.nmrMean.Name = "nmrMean";
            this.nmrMean.Size = new System.Drawing.Size(51, 22);
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
            this.lblMean.Location = new System.Drawing.Point(3, 29);
            this.lblMean.Name = "lblMean";
            this.lblMean.Size = new System.Drawing.Size(19, 17);
            this.lblMean.TabIndex = 8;
            this.lblMean.Text = "m";
            this.toolTip1.SetToolTip(this.lblMean, "Mean in normal distribution");
            // 
            // lblTicker
            // 
            this.lblTicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTicker.AutoSize = true;
            this.lblTicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTicker.Location = new System.Drawing.Point(6, 585);
            this.lblTicker.Name = "lblTicker";
            this.lblTicker.Size = new System.Drawing.Size(129, 17);
            this.lblTicker.TabIndex = 13;
            this.lblTicker.Text = "Ticks /10 cycles:";
            // 
            // lblTickerVal
            // 
            this.lblTickerVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTickerVal.AutoSize = true;
            this.lblTickerVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTickerVal.Location = new System.Drawing.Point(133, 583);
            this.lblTickerVal.Name = "lblTickerVal";
            this.lblTickerVal.Size = new System.Drawing.Size(19, 20);
            this.lblTickerVal.TabIndex = 14;
            this.lblTickerVal.Text = "0";
            this.toolTip1.SetToolTip(this.lblTickerVal, "Number of ticks per 10 cycles");
            // 
            // chkBoxExp
            // 
            this.chkBoxExp.AutoSize = true;
            this.chkBoxExp.Checked = true;
            this.chkBoxExp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxExp.Location = new System.Drawing.Point(6, 3);
            this.chkBoxExp.Name = "chkBoxExp";
            this.chkBoxExp.Size = new System.Drawing.Size(86, 21);
            this.chkBoxExp.TabIndex = 15;
            this.chkBoxExp.Text = "Lognorm";
            this.toolTip1.SetToolTip(this.chkBoxExp, "Turn on/off lognormal distribution");
            this.chkBoxExp.UseVisualStyleBackColor = true;
            this.chkBoxExp.CheckedChanged += new System.EventHandler(this.chkBoxExp_CheckedChanged);
            // 
            // lblFormula1
            // 
            this.lblFormula1.AutoSize = true;
            this.lblFormula1.Location = new System.Drawing.Point(4, 31);
            this.lblFormula1.Name = "lblFormula1";
            this.lblFormula1.Size = new System.Drawing.Size(48, 17);
            this.lblFormula1.TabIndex = 16;
            this.lblFormula1.Text = "exp(X/";
            // 
            // nmrDivisor
            // 
            this.nmrDivisor.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmrDivisor.Location = new System.Drawing.Point(48, 30);
            this.nmrDivisor.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nmrDivisor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrDivisor.Name = "nmrDivisor";
            this.nmrDivisor.Size = new System.Drawing.Size(48, 22);
            this.nmrDivisor.TabIndex = 3;
            this.toolTip1.SetToolTip(this.nmrDivisor, "Power multiplication factor in lognormal distribution ");
            this.nmrDivisor.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // lblPlus
            // 
            this.lblPlus.AutoSize = true;
            this.lblPlus.Location = new System.Drawing.Point(95, 31);
            this.lblPlus.Name = "lblPlus";
            this.lblPlus.Size = new System.Drawing.Size(16, 17);
            this.lblPlus.TabIndex = 18;
            this.lblPlus.Text = "+";
            // 
            // lblBracket
            // 
            this.lblBracket.AutoSize = true;
            this.lblBracket.Location = new System.Drawing.Point(146, 31);
            this.lblBracket.Name = "lblBracket";
            this.lblBracket.Size = new System.Drawing.Size(13, 17);
            this.lblBracket.TabIndex = 20;
            this.lblBracket.Text = ")";
            // 
            // txtBoxResult
            // 
            this.txtBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxResult.Location = new System.Drawing.Point(179, 11);
            this.txtBoxResult.Name = "txtBoxResult";
            this.txtBoxResult.Size = new System.Drawing.Size(132, 549);
            this.txtBoxResult.TabIndex = 21;
            this.txtBoxResult.Text = "";
            this.toolTip1.SetToolTip(this.txtBoxResult, "List of values and their frequencies");
            // 
            // lblLnMean
            // 
            this.lblLnMean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLnMean.AutoSize = true;
            this.lblLnMean.Location = new System.Drawing.Point(190, 563);
            this.lblLnMean.Name = "lblLnMean";
            this.lblLnMean.Size = new System.Drawing.Size(60, 17);
            this.lblLnMean.TabIndex = 22;
            this.lblLnMean.Text = "X mean:";
            // 
            // lblLnMeanVal
            // 
            this.lblLnMeanVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLnMeanVal.AutoSize = true;
            this.lblLnMeanVal.Location = new System.Drawing.Point(246, 563);
            this.lblLnMeanVal.Name = "lblLnMeanVal";
            this.lblLnMeanVal.Size = new System.Drawing.Size(16, 17);
            this.lblLnMeanVal.TabIndex = 23;
            this.lblLnMeanVal.Text = "0";
            this.toolTip1.SetToolTip(this.lblLnMeanVal, "Average X value");
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 607);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Y max:";
            // 
            // lblYmax
            // 
            this.lblYmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblYmax.AutoSize = true;
            this.lblYmax.Location = new System.Drawing.Point(246, 607);
            this.lblYmax.Name = "lblYmax";
            this.lblYmax.Size = new System.Drawing.Size(16, 17);
            this.lblYmax.TabIndex = 25;
            this.lblYmax.Text = "0";
            this.toolTip1.SetToolTip(this.lblYmax, "Maximum Y value");
            // 
            // lblTimerVal
            // 
            this.lblTimerVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTimerVal.AutoSize = true;
            this.lblTimerVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimerVal.Location = new System.Drawing.Point(112, 607);
            this.lblTimerVal.Name = "lblTimerVal";
            this.lblTimerVal.Size = new System.Drawing.Size(19, 20);
            this.lblTimerVal.TabIndex = 26;
            this.lblTimerVal.Text = "0";
            this.toolTip1.SetToolTip(this.lblTimerVal, "Total time of generation in sec");
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimer.Location = new System.Drawing.Point(6, 608);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(108, 17);
            this.lblTimer.TabIndex = 27;
            this.lblTimer.Text = "Gener-n time:";
            // 
            // grpGenerator
            // 
            this.grpGenerator.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpGenerator.Controls.Add(this.cmbBoxRandGen);
            this.grpGenerator.Location = new System.Drawing.Point(9, 12);
            this.grpGenerator.Name = "grpGenerator";
            this.grpGenerator.Size = new System.Drawing.Size(160, 54);
            this.grpGenerator.TabIndex = 128;
            this.grpGenerator.TabStop = false;
            this.grpGenerator.Text = "Random generator";
            // 
            // cmbBoxRandGen
            // 
            this.cmbBoxRandGen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxRandGen.FormattingEnabled = true;
            this.cmbBoxRandGen.Items.AddRange(new object[] {
            "C Mersenne twister",
            "C PCG (O\'Neill)",
            "C std",
            "C XorShift",
            "C# std",
            "C# crypt strong"});
            this.cmbBoxRandGen.Location = new System.Drawing.Point(10, 21);
            this.cmbBoxRandGen.Name = "cmbBoxRandGen";
            this.cmbBoxRandGen.Size = new System.Drawing.Size(141, 24);
            this.cmbBoxRandGen.TabIndex = 102;
            this.toolTip1.SetToolTip(this.cmbBoxRandGen, "Select random gen implementation");
            // 
            // pnlNormal
            // 
            this.pnlNormal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlNormal.Controls.Add(this.label2);
            this.pnlNormal.Controls.Add(this.cmbBoxNormCode);
            this.pnlNormal.Controls.Add(this.chkBoxNorm);
            this.pnlNormal.Controls.Add(this.nmrSigma);
            this.pnlNormal.Controls.Add(this.lblMean);
            this.pnlNormal.Controls.Add(this.nmrMean);
            this.pnlNormal.Controls.Add(this.lblSigma);
            this.pnlNormal.Location = new System.Drawing.Point(9, 71);
            this.pnlNormal.Name = "pnlNormal";
            this.pnlNormal.Size = new System.Drawing.Size(160, 93);
            this.pnlNormal.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "code:";
            // 
            // cmbBoxNormCode
            // 
            this.cmbBoxNormCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxNormCode.FormattingEnabled = true;
            this.cmbBoxNormCode.Items.AddRange(new object[] {
            "Abramowitz",
            "Central Limit",
            "Fog",
            "Marsaglia",
            "C/C# std"});
            this.cmbBoxNormCode.Location = new System.Drawing.Point(50, 61);
            this.cmbBoxNormCode.Name = "cmbBoxNormCode";
            this.cmbBoxNormCode.Size = new System.Drawing.Size(101, 24);
            this.cmbBoxNormCode.TabIndex = 10;
            this.toolTip1.SetToolTip(this.cmbBoxNormCode, "Select Gauss implementation");
            // 
            // pnlExp
            // 
            this.pnlExp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlExp.Controls.Add(this.nmrAdd);
            this.pnlExp.Controls.Add(this.chkBoxStdLogNorm);
            this.pnlExp.Controls.Add(this.nmrDivisor);
            this.pnlExp.Controls.Add(this.lblPlus);
            this.pnlExp.Controls.Add(this.chkBoxExp);
            this.pnlExp.Controls.Add(this.lblBracket);
            this.pnlExp.Controls.Add(this.lblFormula1);
            this.pnlExp.Location = new System.Drawing.Point(9, 169);
            this.pnlExp.Name = "pnlExp";
            this.pnlExp.Size = new System.Drawing.Size(160, 60);
            this.pnlExp.TabIndex = 32;
            // 
            // nmrAdd
            // 
            this.nmrAdd.DecimalPlaces = 1;
            this.nmrAdd.Location = new System.Drawing.Point(109, 30);
            this.nmrAdd.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nmrAdd.Name = "nmrAdd";
            this.nmrAdd.Size = new System.Drawing.Size(38, 22);
            this.nmrAdd.TabIndex = 22;
            this.toolTip1.SetToolTip(this.nmrAdd, "Power summand in lognormal distribution ");
            this.nmrAdd.Value = new decimal(new int[] {
            51,
            0,
            0,
            65536});
            // 
            // chkBoxStdLogNorm
            // 
            this.chkBoxStdLogNorm.AutoSize = true;
            this.chkBoxStdLogNorm.Location = new System.Drawing.Point(95, 3);
            this.chkBoxStdLogNorm.Name = "chkBoxStdLogNorm";
            this.chkBoxStdLogNorm.Size = new System.Drawing.Size(62, 21);
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
            this.chkBoxAccumGraph.Location = new System.Drawing.Point(20, 487);
            this.chkBoxAccumGraph.Name = "chkBoxAccumGraph";
            this.chkBoxAccumGraph.Size = new System.Drawing.Size(72, 21);
            this.chkBoxAccumGraph.TabIndex = 10;
            this.chkBoxAccumGraph.Text = "Accum";
            this.toolTip1.SetToolTip(this.chkBoxAccumGraph, "Turn on/off graphics accumulation");
            this.chkBoxAccumGraph.UseVisualStyleBackColor = true;
            // 
            // nmrSzSelSigma
            // 
            this.nmrSzSelSigma.Enabled = false;
            this.nmrSzSelSigma.Location = new System.Drawing.Point(100, 30);
            this.nmrSzSelSigma.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.nmrSzSelSigma.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrSzSelSigma.Name = "nmrSzSelSigma";
            this.nmrSzSelSigma.Size = new System.Drawing.Size(52, 22);
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
            this.label7.Location = new System.Drawing.Point(3, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 17);
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
            this.nmrSzSelMean.Location = new System.Drawing.Point(25, 29);
            this.nmrSzSelMean.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.nmrSzSelMean.Name = "nmrSzSelMean";
            this.nmrSzSelMean.Size = new System.Drawing.Size(51, 22);
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
            this.label8.Location = new System.Drawing.Point(82, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "s";
            this.toolTip1.SetToolTip(this.label8, "Sigma in size selection normal distribution");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(69, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 17);
            this.label9.TabIndex = 43;
            this.label9.Text = "dev";
            this.toolTip1.SetToolTip(this.label9, "Deviation of size selection");
            // 
            // nmrDev
            // 
            this.nmrDev.Enabled = false;
            this.nmrDev.Location = new System.Drawing.Point(101, 58);
            this.nmrDev.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.nmrDev.Name = "nmrDev";
            this.nmrDev.Size = new System.Drawing.Size(51, 22);
            this.nmrDev.TabIndex = 7;
            this.toolTip1.SetToolTip(this.nmrDev, "Deviation of size selection");
            this.nmrDev.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lblXmax
            // 
            this.lblXmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblXmax.AutoSize = true;
            this.lblXmax.Location = new System.Drawing.Point(246, 585);
            this.lblXmax.Name = "lblXmax";
            this.lblXmax.Size = new System.Drawing.Size(16, 17);
            this.lblXmax.TabIndex = 37;
            this.lblXmax.Text = "0";
            this.toolTip1.SetToolTip(this.lblXmax, "Maximum X value");
            // 
            // lblRGenCalls
            // 
            this.lblRGenCalls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRGenCalls.AutoSize = true;
            this.lblRGenCalls.Location = new System.Drawing.Point(123, 563);
            this.lblRGenCalls.Name = "lblRGenCalls";
            this.lblRGenCalls.Size = new System.Drawing.Size(16, 17);
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
            this.Graph.Location = new System.Drawing.Point(317, 7);
            this.Graph.LowPowerX = ((short)(-2));
            this.Graph.LowPowerY = ((short)(-2));
            this.Graph.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Graph.Mode = Plot.Modes.Graph;
            this.Graph.Name = "Graph";
            this.Graph.PenWidth = 1F;
            this.Graph.ShowBorder = true;
            this.Graph.ShowLegend = false;
            this.Graph.Size = new System.Drawing.Size(609, 619);
            this.Graph.TabIndex = 1;
            this.Graph.TitleMargin = ((byte)(1));
            this.toolTip1.SetToolTip(this.Graph, "Click to refresh graphics");
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
            this.nmrCountBase.Location = new System.Drawing.Point(72, 459);
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
            this.nmrCountBase.Size = new System.Drawing.Size(39, 22);
            this.nmrCountBase.TabIndex = 13;
            this.toolTip1.SetToolTip(this.nmrCountBase, "Number of cycles: significand in scientific notation");
            this.nmrCountBase.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkBoxSizeSelect
            // 
            this.chkBoxSizeSelect.AutoSize = true;
            this.chkBoxSizeSelect.Location = new System.Drawing.Point(7, 3);
            this.chkBoxSizeSelect.Name = "chkBoxSizeSelect";
            this.chkBoxSizeSelect.Size = new System.Drawing.Size(117, 21);
            this.chkBoxSizeSelect.TabIndex = 38;
            this.chkBoxSizeSelect.Text = "Size selection";
            this.toolTip1.SetToolTip(this.chkBoxSizeSelect, "Turn on/off fragment size selection");
            this.chkBoxSizeSelect.UseVisualStyleBackColor = true;
            this.chkBoxSizeSelect.CheckedChanged += new System.EventHandler(this.chkBoxSizeSelect_CheckedChanged);
            // 
            // chkBoxGraph
            // 
            this.chkBoxGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkBoxGraph.AutoSize = true;
            this.chkBoxGraph.Checked = true;
            this.chkBoxGraph.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxGraph.Location = new System.Drawing.Point(111, 487);
            this.chkBoxGraph.Name = "chkBoxGraph";
            this.chkBoxGraph.Size = new System.Drawing.Size(54, 21);
            this.chkBoxGraph.TabIndex = 131;
            this.chkBoxGraph.Text = "Plot";
            this.toolTip1.SetToolTip(this.chkBoxGraph, "Turn on/off graphics output");
            this.chkBoxGraph.UseVisualStyleBackColor = true;
            this.chkBoxGraph.CheckedChanged += new System.EventHandler(this.chkBoxGraph_CheckedChanged);
            // 
            // lblCountPower
            // 
            this.lblCountPower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCountPower.AutoSize = true;
            this.lblCountPower.Location = new System.Drawing.Point(113, 460);
            this.lblCountPower.Name = "lblCountPower";
            this.lblCountPower.Size = new System.Drawing.Size(17, 17);
            this.lblCountPower.TabIndex = 35;
            this.lblCountPower.Text = "E";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 585);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "X max:";
            // 
            // pnlSizeSelect
            // 
            this.pnlSizeSelect.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlSizeSelect.Controls.Add(this.label9);
            this.pnlSizeSelect.Controls.Add(this.nmrDev);
            this.pnlSizeSelect.Controls.Add(this.nmrSzSelSigma);
            this.pnlSizeSelect.Controls.Add(this.label7);
            this.pnlSizeSelect.Controls.Add(this.nmrSzSelMean);
            this.pnlSizeSelect.Controls.Add(this.label8);
            this.pnlSizeSelect.Controls.Add(this.chkBoxSizeSelect);
            this.pnlSizeSelect.Location = new System.Drawing.Point(9, 234);
            this.pnlSizeSelect.Name = "pnlSizeSelect";
            this.pnlSizeSelect.Size = new System.Drawing.Size(160, 87);
            this.pnlSizeSelect.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 563);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 129;
            this.label3.Text = "RGen calls/cycle:";
            // 
            // tabView
            // 
            this.tabView.Controls.Add(this.tabPgLimits);
            this.tabView.Controls.Add(this.tabPgView);
            this.tabView.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabView.ItemSize = new System.Drawing.Size(100, 21);
            this.tabView.Location = new System.Drawing.Point(9, 325);
            this.tabView.Name = "tabView";
            this.tabView.SelectedIndex = 0;
            this.tabView.Size = new System.Drawing.Size(160, 119);
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
            this.tabPgLimits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPgLimits.Name = "tabPgLimits";
            this.tabPgLimits.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPgLimits.Size = new System.Drawing.Size(152, 90);
            this.tabPgLimits.TabIndex = 0;
            this.tabPgLimits.Text = "Limits";
            // 
            // chkBoxYLimit
            // 
            this.chkBoxYLimit.Location = new System.Drawing.Point(1, 36);
            this.chkBoxYLimit.Name = "chkBoxYLimit";
            this.chkBoxYLimit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkBoxYLimit.Size = new System.Drawing.Size(35, 20);
            this.chkBoxYLimit.TabIndex = 5;
            this.chkBoxYLimit.Text = "Y";
            this.chkBoxYLimit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.chkBoxYLimit, "Turn on/off Y-scale autoadaption");
            this.chkBoxYLimit.UseVisualStyleBackColor = true;
            this.chkBoxYLimit.CheckedChanged += new System.EventHandler(this.chkBoxYLimit_CheckedChanged);
            // 
            // nmrYMin
            // 
            this.nmrYMin.Location = new System.Drawing.Point(41, 36);
            this.nmrYMin.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nmrYMin.Name = "nmrYMin";
            this.nmrYMin.Size = new System.Drawing.Size(45, 22);
            this.nmrYMin.TabIndex = 12;
            this.toolTip1.SetToolTip(this.nmrYMin, "Minimum Y-scale value");
            this.nmrYMin.ValueChanged += new System.EventHandler(this.nmrlimit_Changed);
            // 
            // chkBoxXLimit
            // 
            this.chkBoxXLimit.Location = new System.Drawing.Point(1, 9);
            this.chkBoxXLimit.Name = "chkBoxXLimit";
            this.chkBoxXLimit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkBoxXLimit.Size = new System.Drawing.Size(35, 20);
            this.chkBoxXLimit.TabIndex = 2;
            this.chkBoxXLimit.Text = "X";
            this.chkBoxXLimit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.chkBoxXLimit, "Turn on/off X-scale autoadaption");
            this.chkBoxXLimit.UseVisualStyleBackColor = true;
            this.chkBoxXLimit.CheckedChanged += new System.EventHandler(this.chkBoxXLimit_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(84, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "–";
            // 
            // nmrXMax
            // 
            this.nmrXMax.Location = new System.Drawing.Point(95, 8);
            this.nmrXMax.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nmrXMax.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.nmrXMax.Name = "nmrXMax";
            this.nmrXMax.Size = new System.Drawing.Size(54, 22);
            this.nmrXMax.TabIndex = 11;
            this.toolTip1.SetToolTip(this.nmrXMax, "Maximum X-scale value");
            this.nmrXMax.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.nmrXMax.ValueChanged += new System.EventHandler(this.nmrlimit_Changed);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "–";
            // 
            // chkBoxAutoLimit
            // 
            this.chkBoxAutoLimit.AutoSize = true;
            this.chkBoxAutoLimit.Checked = true;
            this.chkBoxAutoLimit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxAutoLimit.Location = new System.Drawing.Point(19, 63);
            this.chkBoxAutoLimit.Name = "chkBoxAutoLimit";
            this.chkBoxAutoLimit.Size = new System.Drawing.Size(59, 21);
            this.chkBoxAutoLimit.TabIndex = 7;
            this.chkBoxAutoLimit.Text = "Auto";
            this.toolTip1.SetToolTip(this.chkBoxAutoLimit, "Turn on/off scales autoadaption");
            this.chkBoxAutoLimit.UseVisualStyleBackColor = true;
            this.chkBoxAutoLimit.CheckedChanged += new System.EventHandler(this.chkBoxAutoLimit_CheckedChanged);
            // 
            // nmrXMin
            // 
            this.nmrXMin.Location = new System.Drawing.Point(41, 8);
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
            this.nmrXMin.Size = new System.Drawing.Size(45, 22);
            this.nmrXMin.TabIndex = 10;
            this.toolTip1.SetToolTip(this.nmrXMin, "Minimum X-scale value");
            this.nmrXMin.ValueChanged += new System.EventHandler(this.nmrlimit_Changed);
            // 
            // nmrYMax
            // 
            this.nmrYMax.Location = new System.Drawing.Point(95, 36);
            this.nmrYMax.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nmrYMax.Name = "nmrYMax";
            this.nmrYMax.Size = new System.Drawing.Size(54, 22);
            this.nmrYMax.TabIndex = 13;
            this.toolTip1.SetToolTip(this.nmrYMax, "Maximum Y-scale value");
            this.nmrYMax.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nmrYMax.ValueChanged += new System.EventHandler(this.nmrlimit_Changed);
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
            this.tabPgView.Name = "tabPgView";
            this.tabPgView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgView.Size = new System.Drawing.Size(152, 90);
            this.tabPgView.TabIndex = 1;
            this.tabPgView.Text = "View";
            // 
            // chkBoxLegend
            // 
            this.chkBoxLegend.AutoSize = true;
            this.chkBoxLegend.Location = new System.Drawing.Point(70, 10);
            this.chkBoxLegend.Name = "chkBoxLegend";
            this.chkBoxLegend.Size = new System.Drawing.Size(78, 21);
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
            this.rBtnGraph.Location = new System.Drawing.Point(8, 60);
            this.rBtnGraph.Name = "rBtnGraph";
            this.rBtnGraph.Size = new System.Drawing.Size(69, 21);
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
            this.chkBoxGrid.Location = new System.Drawing.Point(8, 10);
            this.chkBoxGrid.Name = "chkBoxGrid";
            this.chkBoxGrid.Size = new System.Drawing.Size(57, 21);
            this.chkBoxGrid.TabIndex = 3;
            this.chkBoxGrid.Text = "Grid";
            this.toolTip1.SetToolTip(this.chkBoxGrid, "Turn on/off grid output");
            this.chkBoxGrid.UseVisualStyleBackColor = true;
            this.chkBoxGrid.CheckedChanged += new System.EventHandler(this.chkBoxGrid_CheckedChanged);
            // 
            // chkBoxSpline
            // 
            this.chkBoxSpline.AutoSize = true;
            this.chkBoxSpline.Location = new System.Drawing.Point(78, 60);
            this.chkBoxSpline.Name = "chkBoxSpline";
            this.chkBoxSpline.Size = new System.Drawing.Size(69, 21);
            this.chkBoxSpline.TabIndex = 4;
            this.chkBoxSpline.Text = "Spline";
            this.toolTip1.SetToolTip(this.chkBoxSpline, "Turn on/off spline function graph");
            this.chkBoxSpline.UseVisualStyleBackColor = true;
            this.chkBoxSpline.CheckedChanged += new System.EventHandler(this.chkBoxSpline_CheckedChanged);
            // 
            // rBtnHist
            // 
            this.rBtnHist.AutoSize = true;
            this.rBtnHist.Location = new System.Drawing.Point(8, 36);
            this.rBtnHist.Name = "rBtnHist";
            this.rBtnHist.Size = new System.Drawing.Size(93, 21);
            this.rBtnHist.TabIndex = 0;
            this.rBtnHist.Text = "Histogram";
            this.toolTip1.SetToolTip(this.rBtnHist, "View distribution as a histogram");
            this.rBtnHist.UseVisualStyleBackColor = true;
            this.rBtnHist.CheckedChanged += new System.EventHandler(this.rBtnGraphs_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(932, 634);
            this.Controls.Add(this.tabView);
            this.Controls.Add(this.chkBoxGraph);
            this.Controls.Add(this.lblRGenCalls);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlSizeSelect);
            this.Controls.Add(this.chkBoxAccumGraph);
            this.Controls.Add(this.lblXmax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCountPower);
            this.Controls.Add(this.nmrCountBase);
            this.Controls.Add(this.pnlExp);
            this.Controls.Add(this.pnlNormal);
            this.Controls.Add(this.grpGenerator);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblTimerVal);
            this.Controls.Add(this.lblYmax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLnMeanVal);
            this.Controls.Add(this.lblLnMean);
            this.Controls.Add(this.txtBoxResult);
            this.Controls.Add(this.lblTickerVal);
            this.Controls.Add(this.lblTicker);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.nmrCountPower);
            this.Controls.Add(this.Graph);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(930, 674);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Generator Test";
            this.toolTip1.SetToolTip(this, "Random, normal and lognormal test");
            ((System.ComponentModel.ISupportInitialize)(this.nmrCountPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDivisor)).EndInit();
            this.grpGenerator.ResumeLayout(false);
            this.pnlNormal.ResumeLayout(false);
            this.pnlNormal.PerformLayout();
            this.pnlExp.ResumeLayout(false);
            this.pnlExp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSzSelSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSzSelMean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCountBase)).EndInit();
            this.pnlSizeSelect.ResumeLayout(false);
            this.pnlSizeSelect.PerformLayout();
            this.tabView.ResumeLayout(false);
            this.tabPgLimits.ResumeLayout(false);
            this.tabPgLimits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrYMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrXMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrXMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrYMax)).EndInit();
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
        private System.Windows.Forms.CheckBox chkBoxExp;
        private System.Windows.Forms.Label lblFormula1;
        private System.Windows.Forms.NumericUpDown nmrDivisor;
        private System.Windows.Forms.Label lblPlus;
        private System.Windows.Forms.Label lblBracket;
        private System.Windows.Forms.RichTextBox txtBoxResult;
        private System.Windows.Forms.Label lblLnMean;
        private System.Windows.Forms.Label lblLnMeanVal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblYmax;
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
        private System.Windows.Forms.ComboBox cmbBoxNormCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBoxRandGen;
        private System.Windows.Forms.NumericUpDown nmrXMax;
        private System.Windows.Forms.CheckBox chkBoxAutoLimit;
        private System.Windows.Forms.NumericUpDown nmrYMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblXmax;
        private System.Windows.Forms.CheckBox chkBoxAccumGraph;
        private System.Windows.Forms.CheckBox chkBoxSizeSelect;
        private System.Windows.Forms.Panel pnlSizeSelect;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nmrDev;
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
        private System.Windows.Forms.NumericUpDown nmrAdd;
        private NeatTabControl tabView;
        private System.Windows.Forms.TabPage tabPgLimits;
        private System.Windows.Forms.TabPage tabPgView;
    }
}

