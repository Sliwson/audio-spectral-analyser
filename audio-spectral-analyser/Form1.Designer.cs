﻿namespace audio_spectral_analyser
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
            this.fftChart = new OxyPlot.WindowsForms.PlotView();
            this.spectrumTab = new System.Windows.Forms.TabPage();
            this.fundamentalTab = new System.Windows.Forms.TabPage();
            this.windowCombobox = new System.Windows.Forms.ComboBox();
            this.subLayout = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.frameLengthNumeric = new audio_spectral_analyser.PowerNumericUpDown();
            this.waveChart = new OxyPlot.WindowsForms.PlotView();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.mainLayout.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.fourierTab.SuspendLayout();
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
            this.mainLayout.Size = new System.Drawing.Size(1164, 741);
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
            this.tabControl.Size = new System.Drawing.Size(1158, 525);
            this.tabControl.TabIndex = 2;
            // 
            // fourierTab
            // 
            this.fourierTab.Controls.Add(this.fftChart);
            this.fourierTab.Location = new System.Drawing.Point(4, 22);
            this.fourierTab.Name = "fourierTab";
            this.fourierTab.Padding = new System.Windows.Forms.Padding(3);
            this.fourierTab.Size = new System.Drawing.Size(1150, 499);
            this.fourierTab.TabIndex = 0;
            this.fourierTab.Text = "Fourier Transform";
            this.fourierTab.UseVisualStyleBackColor = true;
            // 
            // fftChart
            // 
            this.fftChart.BackColor = System.Drawing.Color.White;
            this.fftChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fftChart.Location = new System.Drawing.Point(3, 3);
            this.fftChart.Name = "fftChart";
            this.fftChart.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.fftChart.Size = new System.Drawing.Size(1144, 493);
            this.fftChart.TabIndex = 0;
            this.fftChart.Text = "plotView1";
            this.fftChart.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.fftChart.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.fftChart.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // spectrumTab
            // 
            this.spectrumTab.Location = new System.Drawing.Point(4, 22);
            this.spectrumTab.Name = "spectrumTab";
            this.spectrumTab.Padding = new System.Windows.Forms.Padding(3);
            this.spectrumTab.Size = new System.Drawing.Size(1150, 499);
            this.spectrumTab.TabIndex = 1;
            this.spectrumTab.Text = "Spectrum";
            this.spectrumTab.UseVisualStyleBackColor = true;
            // 
            // fundamentalTab
            // 
            this.fundamentalTab.Location = new System.Drawing.Point(4, 22);
            this.fundamentalTab.Name = "fundamentalTab";
            this.fundamentalTab.Size = new System.Drawing.Size(1150, 499);
            this.fundamentalTab.TabIndex = 2;
            this.fundamentalTab.Text = "Fundamental frequency";
            this.fundamentalTab.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.mainLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Audio spectral analyser";
            this.mainLayout.ResumeLayout(false);
            this.mainLayout.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.fourierTab.ResumeLayout(false);
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
        private OxyPlot.WindowsForms.PlotView fftChart;
        private PowerNumericUpDown frameLengthNumeric;
    }
}

