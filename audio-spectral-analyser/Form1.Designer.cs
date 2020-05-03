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
            this.spectrumLayout = new System.Windows.Forms.TableLayoutPanel();
            this.frameOverlapLabel = new System.Windows.Forms.Label();
            this.overlapNumeric = new System.Windows.Forms.NumericUpDown();
            this.spectrumPlot = new OxyPlot.WindowsForms.PlotView();
            this.fundamentalTab = new System.Windows.Forms.TabPage();
            this.fundamentalLayout = new System.Windows.Forms.TableLayoutPanel();
            this.fundamentalOverlapLabel = new System.Windows.Forms.Label();
            this.fundamentalOverlap = new System.Windows.Forms.NumericUpDown();
            this.fundamentalPlot = new OxyPlot.WindowsForms.PlotView();
            this.windowCombobox = new System.Windows.Forms.ComboBox();
            this.subLayout = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.waveChart = new OxyPlot.WindowsForms.PlotView();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.frameLengthNumeric = new audio_spectral_analyser.PowerNumericUpDown();
            this.mainLayout.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.fourierTab.SuspendLayout();
            this.fourierLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beginFrameTime)).BeginInit();
            this.spectrumTab.SuspendLayout();
            this.spectrumLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overlapNumeric)).BeginInit();
            this.fundamentalTab.SuspendLayout();
            this.fundamentalLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fundamentalOverlap)).BeginInit();
            this.subLayout.SuspendLayout();
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
            this.mainLayout.Size = new System.Drawing.Size(1164, 657);
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
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(3, 213);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1158, 441);
            this.tabControl.TabIndex = 2;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.TabControlSelectedIndexChanged);
            // 
            // fourierTab
            // 
            this.fourierTab.Controls.Add(this.fourierLayout);
            this.fourierTab.Location = new System.Drawing.Point(4, 22);
            this.fourierTab.Name = "fourierTab";
            this.fourierTab.Padding = new System.Windows.Forms.Padding(3);
            this.fourierTab.Size = new System.Drawing.Size(1150, 415);
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
            this.fourierLayout.Size = new System.Drawing.Size(1144, 409);
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
            this.fftChart.Size = new System.Drawing.Size(1138, 373);
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
            this.spectrumTab.Controls.Add(this.spectrumLayout);
            this.spectrumTab.Location = new System.Drawing.Point(4, 22);
            this.spectrumTab.Name = "spectrumTab";
            this.spectrumTab.Padding = new System.Windows.Forms.Padding(3);
            this.spectrumTab.Size = new System.Drawing.Size(1150, 415);
            this.spectrumTab.TabIndex = 1;
            this.spectrumTab.Text = "Spectrum";
            this.spectrumTab.UseVisualStyleBackColor = true;
            // 
            // spectrumLayout
            // 
            this.spectrumLayout.ColumnCount = 3;
            this.spectrumLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.spectrumLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.spectrumLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.spectrumLayout.Controls.Add(this.frameOverlapLabel, 0, 0);
            this.spectrumLayout.Controls.Add(this.overlapNumeric, 1, 0);
            this.spectrumLayout.Controls.Add(this.spectrumPlot, 0, 1);
            this.spectrumLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spectrumLayout.Location = new System.Drawing.Point(3, 3);
            this.spectrumLayout.Name = "spectrumLayout";
            this.spectrumLayout.RowCount = 2;
            this.spectrumLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.spectrumLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.spectrumLayout.Size = new System.Drawing.Size(1144, 409);
            this.spectrumLayout.TabIndex = 0;
            // 
            // frameOverlapLabel
            // 
            this.frameOverlapLabel.AutoSize = true;
            this.frameOverlapLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frameOverlapLabel.Location = new System.Drawing.Point(3, 0);
            this.frameOverlapLabel.Name = "frameOverlapLabel";
            this.frameOverlapLabel.Size = new System.Drawing.Size(94, 30);
            this.frameOverlapLabel.TabIndex = 0;
            this.frameOverlapLabel.Text = "Overlap:";
            this.frameOverlapLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // overlapNumeric
            // 
            this.overlapNumeric.DecimalPlaces = 2;
            this.overlapNumeric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overlapNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.overlapNumeric.Location = new System.Drawing.Point(103, 6);
            this.overlapNumeric.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.overlapNumeric.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            65536});
            this.overlapNumeric.Name = "overlapNumeric";
            this.overlapNumeric.Size = new System.Drawing.Size(94, 20);
            this.overlapNumeric.TabIndex = 1;
            this.overlapNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.overlapNumeric.ValueChanged += new System.EventHandler(this.OverlapNumericValueChanged);
            // 
            // spectrumPlot
            // 
            this.spectrumPlot.BackColor = System.Drawing.Color.White;
            this.spectrumLayout.SetColumnSpan(this.spectrumPlot, 3);
            this.spectrumPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spectrumPlot.Location = new System.Drawing.Point(3, 33);
            this.spectrumPlot.Name = "spectrumPlot";
            this.spectrumPlot.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.spectrumPlot.Size = new System.Drawing.Size(1138, 373);
            this.spectrumPlot.TabIndex = 2;
            this.spectrumPlot.Text = "plotView1";
            this.spectrumPlot.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.spectrumPlot.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.spectrumPlot.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // fundamentalTab
            // 
            this.fundamentalTab.Controls.Add(this.fundamentalLayout);
            this.fundamentalTab.Location = new System.Drawing.Point(4, 22);
            this.fundamentalTab.Name = "fundamentalTab";
            this.fundamentalTab.Size = new System.Drawing.Size(1150, 415);
            this.fundamentalTab.TabIndex = 2;
            this.fundamentalTab.Text = "Fundamental frequency";
            this.fundamentalTab.UseVisualStyleBackColor = true;
            // 
            // fundamentalLayout
            // 
            this.fundamentalLayout.ColumnCount = 3;
            this.fundamentalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.fundamentalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.fundamentalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.fundamentalLayout.Controls.Add(this.fundamentalOverlapLabel, 0, 0);
            this.fundamentalLayout.Controls.Add(this.fundamentalOverlap, 1, 0);
            this.fundamentalLayout.Controls.Add(this.fundamentalPlot, 0, 1);
            this.fundamentalLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fundamentalLayout.Location = new System.Drawing.Point(0, 0);
            this.fundamentalLayout.Name = "fundamentalLayout";
            this.fundamentalLayout.RowCount = 2;
            this.fundamentalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.fundamentalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.fundamentalLayout.Size = new System.Drawing.Size(1150, 415);
            this.fundamentalLayout.TabIndex = 1;
            // 
            // fundamentalOverlapLabel
            // 
            this.fundamentalOverlapLabel.AutoSize = true;
            this.fundamentalOverlapLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fundamentalOverlapLabel.Location = new System.Drawing.Point(3, 0);
            this.fundamentalOverlapLabel.Name = "fundamentalOverlapLabel";
            this.fundamentalOverlapLabel.Size = new System.Drawing.Size(94, 30);
            this.fundamentalOverlapLabel.TabIndex = 0;
            this.fundamentalOverlapLabel.Text = "Overlap:";
            this.fundamentalOverlapLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fundamentalOverlap
            // 
            this.fundamentalOverlap.DecimalPlaces = 2;
            this.fundamentalOverlap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fundamentalOverlap.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.fundamentalOverlap.Location = new System.Drawing.Point(103, 6);
            this.fundamentalOverlap.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.fundamentalOverlap.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fundamentalOverlap.Name = "fundamentalOverlap";
            this.fundamentalOverlap.Size = new System.Drawing.Size(94, 20);
            this.fundamentalOverlap.TabIndex = 1;
            this.fundamentalOverlap.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.fundamentalOverlap.ValueChanged += new System.EventHandler(this.FundamentalOverlapValueChanged);
            // 
            // fundamentalPlot
            // 
            this.fundamentalPlot.BackColor = System.Drawing.Color.White;
            this.fundamentalLayout.SetColumnSpan(this.fundamentalPlot, 3);
            this.fundamentalPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fundamentalPlot.Location = new System.Drawing.Point(3, 33);
            this.fundamentalPlot.Name = "fundamentalPlot";
            this.fundamentalPlot.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.fundamentalPlot.Size = new System.Drawing.Size(1144, 379);
            this.fundamentalPlot.TabIndex = 2;
            this.fundamentalPlot.Text = "plotView1";
            this.fundamentalPlot.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.fundamentalPlot.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.fundamentalPlot.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
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
            this.subLayout.ColumnCount = 2;
            this.subLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.subLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frame length:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // frameLengthNumeric
            // 
            this.frameLengthNumeric.Location = new System.Drawing.Point(83, 3);
            this.frameLengthNumeric.Maximum = new decimal(new int[] {
            16384,
            0,
            0,
            0});
            this.frameLengthNumeric.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.frameLengthNumeric.Name = "frameLengthNumeric";
            this.frameLengthNumeric.ReadOnly = true;
            this.frameLengthNumeric.Size = new System.Drawing.Size(120, 20);
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
            this.ClientSize = new System.Drawing.Size(1184, 677);
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
            this.spectrumLayout.ResumeLayout(false);
            this.spectrumLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overlapNumeric)).EndInit();
            this.fundamentalTab.ResumeLayout(false);
            this.fundamentalLayout.ResumeLayout(false);
            this.fundamentalLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fundamentalOverlap)).EndInit();
            this.subLayout.ResumeLayout(false);
            this.subLayout.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel spectrumLayout;
        private System.Windows.Forms.Label frameOverlapLabel;
        private System.Windows.Forms.NumericUpDown overlapNumeric;
        private OxyPlot.WindowsForms.PlotView spectrumPlot;
        private System.Windows.Forms.TableLayoutPanel fundamentalLayout;
        private System.Windows.Forms.Label fundamentalOverlapLabel;
        private System.Windows.Forms.NumericUpDown fundamentalOverlap;
        private OxyPlot.WindowsForms.PlotView fundamentalPlot;
    }
}

