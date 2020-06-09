namespace audio_spectral_analyser
{
    partial class Form1
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
            if (disposing && (components != null))
            {
                components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.filenameLabel = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.fourierTab = new System.Windows.Forms.TabPage();
            this.fourierLayout = new System.Windows.Forms.TableLayoutPanel();
            this.fftChart = new OxyPlot.WindowsForms.PlotView();
            this.oneFrameCheckBox = new System.Windows.Forms.CheckBox();
            this.beginLabel = new System.Windows.Forms.Label();
            this.beginFrameTime = new System.Windows.Forms.NumericUpDown();
            this.spectrumTab = new System.Windows.Forms.TabPage();
            this.spectrumPlot = new OxyPlot.WindowsForms.PlotView();
            this.fundamentalTab = new System.Windows.Forms.TabPage();
            this.fundamentalPlot = new OxyPlot.WindowsForms.PlotView();
            this.volumeTab = new System.Windows.Forms.TabPage();
            this.volumePlotChart = new OxyPlot.WindowsForms.PlotView();
            this.frequencyCentroidTab = new System.Windows.Forms.TabPage();
            this.frequencyCentroidChart = new OxyPlot.WindowsForms.PlotView();
            this.effectiveBandwidthTab = new System.Windows.Forms.TabPage();
            this.effectiveBandwidthChart = new OxyPlot.WindowsForms.PlotView();
            this.bandEnergyTab = new System.Windows.Forms.TabPage();
            this.windowCombobox = new System.Windows.Forms.ComboBox();
            this.subLayout = new System.Windows.Forms.TableLayoutPanel();
            this.fundamentalOverlapLabel = new System.Windows.Forms.Label();
            this.overlap = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.waveChart = new OxyPlot.WindowsForms.PlotView();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bandEnergyChart = new OxyPlot.WindowsForms.PlotView();
            this.f0Label = new System.Windows.Forms.Label();
            this.f1Label = new System.Windows.Forms.Label();
            this.f0Numeric = new System.Windows.Forms.NumericUpDown();
            this.f1Numeric = new System.Windows.Forms.NumericUpDown();
            this.frameLengthNumeric = new audio_spectral_analyser.PowerNumericUpDown();
            this.mainLayout.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.fourierTab.SuspendLayout();
            this.fourierLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beginFrameTime)).BeginInit();
            this.spectrumTab.SuspendLayout();
            this.fundamentalTab.SuspendLayout();
            this.volumeTab.SuspendLayout();
            this.frequencyCentroidTab.SuspendLayout();
            this.effectiveBandwidthTab.SuspendLayout();
            this.bandEnergyTab.SuspendLayout();
            this.subLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overlap)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.f0Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameLengthNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 2;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayout.Controls.Add(this.filenameLabel, 0, 0);
            this.mainLayout.Controls.Add(this.tabControl, 0, 3);
            this.mainLayout.Controls.Add(this.windowCombobox, 1, 2);
            this.mainLayout.Controls.Add(this.subLayout, 0, 2);
            this.mainLayout.Controls.Add(this.waveChart, 0, 1);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(10, 10);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 4;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Size = new System.Drawing.Size(1164, 541);
            this.mainLayout.TabIndex = 0;
            // 
            // filenameLabel
            // 
            this.filenameLabel.AutoSize = true;
            this.filenameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filenameLabel.Location = new System.Drawing.Point(3, 0);
            this.filenameLabel.Name = "filenameLabel";
            this.filenameLabel.Size = new System.Drawing.Size(576, 30);
            this.filenameLabel.TabIndex = 0;
            this.filenameLabel.Text = "No file loaded...";
            // 
            // tabControl
            // 
            this.mainLayout.SetColumnSpan(this.tabControl, 2);
            this.tabControl.Controls.Add(this.fourierTab);
            this.tabControl.Controls.Add(this.spectrumTab);
            this.tabControl.Controls.Add(this.fundamentalTab);
            this.tabControl.Controls.Add(this.volumeTab);
            this.tabControl.Controls.Add(this.frequencyCentroidTab);
            this.tabControl.Controls.Add(this.effectiveBandwidthTab);
            this.tabControl.Controls.Add(this.bandEnergyTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(3, 213);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1158, 325);
            this.tabControl.TabIndex = 2;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.TabControlSelectedIndexChanged);
            // 
            // fourierTab
            // 
            this.fourierTab.Controls.Add(this.fourierLayout);
            this.fourierTab.Location = new System.Drawing.Point(4, 22);
            this.fourierTab.Name = "fourierTab";
            this.fourierTab.Padding = new System.Windows.Forms.Padding(3);
            this.fourierTab.Size = new System.Drawing.Size(1150, 299);
            this.fourierTab.TabIndex = 0;
            this.fourierTab.Text = "Fourier Transform";
            this.fourierTab.UseVisualStyleBackColor = true;
            // 
            // fourierLayout
            // 
            this.fourierLayout.ColumnCount = 5;
            this.fourierLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.fourierLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.fourierLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.fourierLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.fourierLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.fourierLayout.Controls.Add(this.fftChart, 0, 1);
            this.fourierLayout.Controls.Add(this.oneFrameCheckBox, 0, 0);
            this.fourierLayout.Controls.Add(this.beginLabel, 2, 0);
            this.fourierLayout.Controls.Add(this.beginFrameTime, 3, 0);
            this.fourierLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fourierLayout.Location = new System.Drawing.Point(3, 3);
            this.fourierLayout.Name = "fourierLayout";
            this.fourierLayout.RowCount = 2;
            this.fourierLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.fourierLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.fourierLayout.Size = new System.Drawing.Size(1144, 293);
            this.fourierLayout.TabIndex = 0;
            // 
            // fftChart
            // 
            this.fftChart.BackColor = System.Drawing.Color.White;
            this.fourierLayout.SetColumnSpan(this.fftChart, 5);
            this.fftChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fftChart.Location = new System.Drawing.Point(3, 33);
            this.fftChart.Name = "fftChart";
            this.fftChart.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.fftChart.Size = new System.Drawing.Size(1138, 257);
            this.fftChart.TabIndex = 0;
            this.fftChart.Text = "plotView1";
            this.fftChart.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.fftChart.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.fftChart.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // oneFrameCheckBox
            // 
            this.oneFrameCheckBox.AutoSize = true;
            this.oneFrameCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.oneFrameCheckBox.Location = new System.Drawing.Point(3, 3);
            this.oneFrameCheckBox.Name = "oneFrameCheckBox";
            this.oneFrameCheckBox.Size = new System.Drawing.Size(94, 17);
            this.oneFrameCheckBox.TabIndex = 1;
            this.oneFrameCheckBox.Text = "One frame only";
            this.oneFrameCheckBox.UseVisualStyleBackColor = true;
            this.oneFrameCheckBox.CheckedChanged += new System.EventHandler(this.OneFrameCheckBoxCheckedChanged);
            // 
            // beginLabel
            // 
            this.beginLabel.AutoSize = true;
            this.beginLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.beginLabel.Location = new System.Drawing.Point(203, 0);
            this.beginLabel.Name = "beginLabel";
            this.beginLabel.Size = new System.Drawing.Size(94, 30);
            this.beginLabel.TabIndex = 2;
            this.beginLabel.Text = "Begin:";
            this.beginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // beginFrameTime
            // 
            this.beginFrameTime.DecimalPlaces = 2;
            this.beginFrameTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.beginFrameTime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.beginFrameTime.Location = new System.Drawing.Point(303, 6);
            this.beginFrameTime.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.beginFrameTime.Name = "beginFrameTime";
            this.beginFrameTime.Size = new System.Drawing.Size(94, 20);
            this.beginFrameTime.TabIndex = 3;
            this.beginFrameTime.ValueChanged += new System.EventHandler(this.BeginFrameTimeValueChanged);
            // 
            // spectrumTab
            // 
            this.spectrumTab.Controls.Add(this.spectrumPlot);
            this.spectrumTab.Location = new System.Drawing.Point(4, 22);
            this.spectrumTab.Name = "spectrumTab";
            this.spectrumTab.Padding = new System.Windows.Forms.Padding(3);
            this.spectrumTab.Size = new System.Drawing.Size(1150, 299);
            this.spectrumTab.TabIndex = 1;
            this.spectrumTab.Text = "Spectrum";
            this.spectrumTab.UseVisualStyleBackColor = true;
            // 
            // spectrumPlot
            // 
            this.spectrumPlot.BackColor = System.Drawing.Color.White;
            this.spectrumPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spectrumPlot.Location = new System.Drawing.Point(3, 3);
            this.spectrumPlot.Name = "spectrumPlot";
            this.spectrumPlot.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.spectrumPlot.Size = new System.Drawing.Size(1144, 293);
            this.spectrumPlot.TabIndex = 3;
            this.spectrumPlot.Text = "plotView1";
            this.spectrumPlot.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.spectrumPlot.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.spectrumPlot.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // fundamentalTab
            // 
            this.fundamentalTab.Controls.Add(this.fundamentalPlot);
            this.fundamentalTab.Location = new System.Drawing.Point(4, 22);
            this.fundamentalTab.Name = "fundamentalTab";
            this.fundamentalTab.Size = new System.Drawing.Size(1150, 299);
            this.fundamentalTab.TabIndex = 2;
            this.fundamentalTab.Text = "Fundamental frequency";
            this.fundamentalTab.UseVisualStyleBackColor = true;
            // 
            // fundamentalPlot
            // 
            this.fundamentalPlot.BackColor = System.Drawing.Color.White;
            this.fundamentalPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fundamentalPlot.Location = new System.Drawing.Point(0, 0);
            this.fundamentalPlot.Name = "fundamentalPlot";
            this.fundamentalPlot.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.fundamentalPlot.Size = new System.Drawing.Size(1150, 299);
            this.fundamentalPlot.TabIndex = 3;
            this.fundamentalPlot.Text = "plotView1";
            this.fundamentalPlot.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.fundamentalPlot.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.fundamentalPlot.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // volumeTab
            // 
            this.volumeTab.Controls.Add(this.volumePlotChart);
            this.volumeTab.Location = new System.Drawing.Point(4, 22);
            this.volumeTab.Name = "volumeTab";
            this.volumeTab.Size = new System.Drawing.Size(1150, 299);
            this.volumeTab.TabIndex = 3;
            this.volumeTab.Text = "Volume";
            this.volumeTab.UseVisualStyleBackColor = true;
            // 
            // volumePlotChart
            // 
            this.volumePlotChart.BackColor = System.Drawing.Color.White;
            this.volumePlotChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.volumePlotChart.Location = new System.Drawing.Point(0, 0);
            this.volumePlotChart.Name = "volumePlotChart";
            this.volumePlotChart.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.volumePlotChart.Size = new System.Drawing.Size(1150, 299);
            this.volumePlotChart.TabIndex = 0;
            this.volumePlotChart.Text = "plotView1";
            this.volumePlotChart.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.volumePlotChart.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.volumePlotChart.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // frequencyCentroidTab
            // 
            this.frequencyCentroidTab.Controls.Add(this.frequencyCentroidChart);
            this.frequencyCentroidTab.Location = new System.Drawing.Point(4, 22);
            this.frequencyCentroidTab.Name = "frequencyCentroidTab";
            this.frequencyCentroidTab.Size = new System.Drawing.Size(1150, 299);
            this.frequencyCentroidTab.TabIndex = 4;
            this.frequencyCentroidTab.Text = "Frequency Centroid";
            this.frequencyCentroidTab.UseVisualStyleBackColor = true;
            // 
            // frequencyCentroidChart
            // 
            this.frequencyCentroidChart.BackColor = System.Drawing.Color.White;
            this.frequencyCentroidChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frequencyCentroidChart.Location = new System.Drawing.Point(0, 0);
            this.frequencyCentroidChart.Name = "frequencyCentroidChart";
            this.frequencyCentroidChart.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.frequencyCentroidChart.Size = new System.Drawing.Size(1150, 299);
            this.frequencyCentroidChart.TabIndex = 0;
            this.frequencyCentroidChart.Text = "plotView1";
            this.frequencyCentroidChart.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.frequencyCentroidChart.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.frequencyCentroidChart.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // effectiveBandwidthTab
            // 
            this.effectiveBandwidthTab.Controls.Add(this.effectiveBandwidthChart);
            this.effectiveBandwidthTab.Location = new System.Drawing.Point(4, 22);
            this.effectiveBandwidthTab.Name = "effectiveBandwidthTab";
            this.effectiveBandwidthTab.Size = new System.Drawing.Size(1150, 299);
            this.effectiveBandwidthTab.TabIndex = 5;
            this.effectiveBandwidthTab.Text = "Effective Bandwidth";
            this.effectiveBandwidthTab.UseVisualStyleBackColor = true;
            // 
            // effectiveBandwidthChart
            // 
            this.effectiveBandwidthChart.BackColor = System.Drawing.Color.White;
            this.effectiveBandwidthChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.effectiveBandwidthChart.Location = new System.Drawing.Point(0, 0);
            this.effectiveBandwidthChart.Name = "effectiveBandwidthChart";
            this.effectiveBandwidthChart.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.effectiveBandwidthChart.Size = new System.Drawing.Size(1150, 299);
            this.effectiveBandwidthChart.TabIndex = 0;
            this.effectiveBandwidthChart.Text = "plotView2";
            this.effectiveBandwidthChart.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.effectiveBandwidthChart.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.effectiveBandwidthChart.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // bandEnergyTab
            // 
            this.bandEnergyTab.Controls.Add(this.tableLayoutPanel1);
            this.bandEnergyTab.Location = new System.Drawing.Point(4, 22);
            this.bandEnergyTab.Name = "bandEnergyTab";
            this.bandEnergyTab.Size = new System.Drawing.Size(1150, 299);
            this.bandEnergyTab.TabIndex = 6;
            this.bandEnergyTab.Text = "Band Energy";
            this.bandEnergyTab.UseVisualStyleBackColor = true;
            // 
            // windowCombobox
            // 
            this.windowCombobox.Dock = System.Windows.Forms.DockStyle.Left;
            this.windowCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.windowCombobox.FormattingEnabled = true;
            this.windowCombobox.Items.AddRange(new object[] {
            "Rectangle window",
            "Hamming window",
            "van Hann window"});
            this.windowCombobox.Location = new System.Drawing.Point(585, 183);
            this.windowCombobox.Name = "windowCombobox";
            this.windowCombobox.Size = new System.Drawing.Size(180, 21);
            this.windowCombobox.TabIndex = 3;
            this.windowCombobox.SelectedIndexChanged += new System.EventHandler(this.OnWindowSelectedIndexChanged);
            // 
            // subLayout
            // 
            this.subLayout.ColumnCount = 4;
            this.subLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.subLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.subLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.subLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.subLayout.Controls.Add(this.fundamentalOverlapLabel, 2, 0);
            this.subLayout.Controls.Add(this.overlap, 3, 0);
            this.subLayout.Controls.Add(this.label1, 0, 0);
            this.subLayout.Controls.Add(this.frameLengthNumeric, 1, 0);
            this.subLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subLayout.Location = new System.Drawing.Point(3, 183);
            this.subLayout.Name = "subLayout";
            this.subLayout.RowCount = 1;
            this.subLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.subLayout.Size = new System.Drawing.Size(576, 24);
            this.subLayout.TabIndex = 4;
            // 
            // fundamentalOverlapLabel
            // 
            this.fundamentalOverlapLabel.AutoSize = true;
            this.fundamentalOverlapLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fundamentalOverlapLabel.Location = new System.Drawing.Point(291, 0);
            this.fundamentalOverlapLabel.Name = "fundamentalOverlapLabel";
            this.fundamentalOverlapLabel.Size = new System.Drawing.Size(138, 24);
            this.fundamentalOverlapLabel.TabIndex = 4;
            this.fundamentalOverlapLabel.Text = "Overlap:";
            this.fundamentalOverlapLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // overlap
            // 
            this.overlap.DecimalPlaces = 2;
            this.overlap.Dock = System.Windows.Forms.DockStyle.Top;
            this.overlap.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.overlap.Location = new System.Drawing.Point(435, 3);
            this.overlap.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            this.overlap.Name = "overlap";
            this.overlap.Size = new System.Drawing.Size(138, 20);
            this.overlap.TabIndex = 3;
            this.overlap.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.overlap.ValueChanged += new System.EventHandler(this.OverlapValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frame length:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // waveChart
            // 
            this.waveChart.BackColor = System.Drawing.Color.White;
            this.mainLayout.SetColumnSpan(this.waveChart, 2);
            this.waveChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waveChart.Location = new System.Drawing.Point(3, 33);
            this.waveChart.Name = "waveChart";
            this.waveChart.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.waveChart.Size = new System.Drawing.Size(1158, 144);
            this.waveChart.TabIndex = 6;
            this.waveChart.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.waveChart.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.waveChart.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2});
            this.menuItem1.Text = "File";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "Open";
            this.menuItem2.Click += new System.EventHandler(this.OpenFileClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.f1Numeric, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.f0Numeric, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.f1Label, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.f0Label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bandEnergyChart, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1150, 299);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bandEnergyChart
            // 
            this.bandEnergyChart.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.bandEnergyChart, 5);
            this.bandEnergyChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bandEnergyChart.Location = new System.Drawing.Point(3, 28);
            this.bandEnergyChart.Name = "bandEnergyChart";
            this.bandEnergyChart.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.bandEnergyChart.Size = new System.Drawing.Size(1144, 268);
            this.bandEnergyChart.TabIndex = 1;
            this.bandEnergyChart.Text = "plotView3";
            this.bandEnergyChart.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.bandEnergyChart.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.bandEnergyChart.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // f0Label
            // 
            this.f0Label.AutoSize = true;
            this.f0Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.f0Label.Location = new System.Drawing.Point(3, 0);
            this.f0Label.Name = "f0Label";
            this.f0Label.Size = new System.Drawing.Size(94, 25);
            this.f0Label.TabIndex = 5;
            this.f0Label.Text = "f0:";
            this.f0Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // f1Label
            // 
            this.f1Label.AutoSize = true;
            this.f1Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.f1Label.Location = new System.Drawing.Point(203, 0);
            this.f1Label.Name = "f1Label";
            this.f1Label.Size = new System.Drawing.Size(94, 25);
            this.f1Label.TabIndex = 6;
            this.f1Label.Text = "f1:";
            this.f1Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // f0Numeric
            // 
            this.f0Numeric.Dock = System.Windows.Forms.DockStyle.Top;
            this.f0Numeric.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.f0Numeric.Location = new System.Drawing.Point(103, 3);
            this.f0Numeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.f0Numeric.Name = "f0Numeric";
            this.f0Numeric.Size = new System.Drawing.Size(94, 20);
            this.f0Numeric.TabIndex = 7;
            this.f0Numeric.ValueChanged += new System.EventHandler(this.F0NumericValueChanged);
            // 
            // f1Numeric
            // 
            this.f1Numeric.Dock = System.Windows.Forms.DockStyle.Top;
            this.f1Numeric.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.f1Numeric.Location = new System.Drawing.Point(303, 3);
            this.f1Numeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.f1Numeric.Name = "f1Numeric";
            this.f1Numeric.Size = new System.Drawing.Size(94, 20);
            this.f1Numeric.TabIndex = 8;
            this.f1Numeric.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.f1Numeric.ValueChanged += new System.EventHandler(this.F1NumericValueChanged);
            // 
            // frameLengthNumeric
            // 
            this.frameLengthNumeric.Dock = System.Windows.Forms.DockStyle.Top;
            this.frameLengthNumeric.Location = new System.Drawing.Point(147, 3);
            this.frameLengthNumeric.Maximum = new decimal(new int[] {
            16384,
            0,
            0,
            0});
            this.frameLengthNumeric.Minimum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.frameLengthNumeric.Name = "frameLengthNumeric";
            this.frameLengthNumeric.ReadOnly = true;
            this.frameLengthNumeric.Size = new System.Drawing.Size(138, 20);
            this.frameLengthNumeric.TabIndex = 1;
            this.frameLengthNumeric.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.frameLengthNumeric.ValueChanged += new System.EventHandler(this.FrameLengthNumericValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.mainLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Audio spectral analyser";
            this.mainLayout.ResumeLayout(false);
            this.mainLayout.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.fourierTab.ResumeLayout(false);
            this.fourierLayout.ResumeLayout(false);
            this.fourierLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beginFrameTime)).EndInit();
            this.spectrumTab.ResumeLayout(false);
            this.fundamentalTab.ResumeLayout(false);
            this.volumeTab.ResumeLayout(false);
            this.frequencyCentroidTab.ResumeLayout(false);
            this.effectiveBandwidthTab.ResumeLayout(false);
            this.bandEnergyTab.ResumeLayout(false);
            this.subLayout.ResumeLayout(false);
            this.subLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overlap)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.f0Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameLengthNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.Label filenameLabel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage fourierTab;
        private System.Windows.Forms.TabPage spectrumTab;
        private System.Windows.Forms.TabPage fundamentalTab;
        private System.Windows.Forms.ComboBox windowCombobox;
        private System.Windows.Forms.TableLayoutPanel subLayout;
        private System.Windows.Forms.Label label1;
        private OxyPlot.WindowsForms.PlotView waveChart;
        private PowerNumericUpDown frameLengthNumeric;
        private System.Windows.Forms.TableLayoutPanel fourierLayout;
        private OxyPlot.WindowsForms.PlotView fftChart;
        private System.Windows.Forms.CheckBox oneFrameCheckBox;
        private System.Windows.Forms.Label beginLabel;
        private System.Windows.Forms.NumericUpDown beginFrameTime;
        private System.Windows.Forms.TabPage volumeTab;
        private OxyPlot.WindowsForms.PlotView volumePlotChart;
        private System.Windows.Forms.TabPage frequencyCentroidTab;
        private OxyPlot.WindowsForms.PlotView frequencyCentroidChart;
        private System.Windows.Forms.TabPage effectiveBandwidthTab;
        private OxyPlot.WindowsForms.PlotView effectiveBandwidthChart;
        private System.Windows.Forms.TabPage bandEnergyTab;
        private OxyPlot.WindowsForms.PlotView fundamentalPlot;
        private System.Windows.Forms.Label fundamentalOverlapLabel;
        private System.Windows.Forms.NumericUpDown overlap;
        private OxyPlot.WindowsForms.PlotView spectrumPlot;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown f1Numeric;
        private System.Windows.Forms.NumericUpDown f0Numeric;
        private System.Windows.Forms.Label f1Label;
        private System.Windows.Forms.Label f0Label;
        private OxyPlot.WindowsForms.PlotView bandEnergyChart;
    }
}

