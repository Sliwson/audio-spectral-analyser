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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.filenameLabel = new System.Windows.Forms.Label();
            this.waveChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.fourierTab = new System.Windows.Forms.TabPage();
            this.spectrumTab = new System.Windows.Forms.TabPage();
            this.fundamentalTab = new System.Windows.Forms.TabPage();
            this.windowCombobox = new System.Windows.Forms.ComboBox();
            this.subLayout = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.zoomTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.zoomInButton = new System.Windows.Forms.Button();
            this.zoomOutButton = new System.Windows.Forms.Button();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.fftChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waveChart)).BeginInit();
            this.tabControl.SuspendLayout();
            this.fourierTab.SuspendLayout();
            this.subLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.zoomTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fftChart)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 2;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayout.Controls.Add(this.filenameLabel, 0, 0);
            this.mainLayout.Controls.Add(this.waveChart, 0, 1);
            this.mainLayout.Controls.Add(this.tabControl, 0, 3);
            this.mainLayout.Controls.Add(this.windowCombobox, 1, 2);
            this.mainLayout.Controls.Add(this.subLayout, 0, 2);
            this.mainLayout.Controls.Add(this.zoomTableLayout, 1, 0);
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
            // waveChart
            // 
            chartArea1.Name = "ChartArea1";
            this.waveChart.ChartAreas.Add(chartArea1);
            this.mainLayout.SetColumnSpan(this.waveChart, 2);
            this.waveChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waveChart.Location = new System.Drawing.Point(3, 33);
            this.waveChart.Name = "waveChart";
            this.waveChart.Size = new System.Drawing.Size(1158, 144);
            this.waveChart.TabIndex = 1;
            this.waveChart.Text = "waveChart";
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
            // 
            // subLayout
            // 
            this.subLayout.ColumnCount = 2;
            this.subLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.subLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.subLayout.Controls.Add(this.label1, 0, 0);
            this.subLayout.Controls.Add(this.numericUpDown1, 1, 0);
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
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(83, 3);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 1;
            // 
            // zoomTableLayout
            // 
            this.zoomTableLayout.ColumnCount = 3;
            this.zoomTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.zoomTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.zoomTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.zoomTableLayout.Controls.Add(this.zoomInButton, 1, 0);
            this.zoomTableLayout.Controls.Add(this.zoomOutButton, 2, 0);
            this.zoomTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zoomTableLayout.Location = new System.Drawing.Point(585, 3);
            this.zoomTableLayout.Name = "zoomTableLayout";
            this.zoomTableLayout.RowCount = 1;
            this.zoomTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.zoomTableLayout.Size = new System.Drawing.Size(576, 24);
            this.zoomTableLayout.TabIndex = 5;
            // 
            // zoomInButton
            // 
            this.zoomInButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zoomInButton.Location = new System.Drawing.Point(397, 1);
            this.zoomInButton.Margin = new System.Windows.Forms.Padding(1);
            this.zoomInButton.Name = "zoomInButton";
            this.zoomInButton.Size = new System.Drawing.Size(88, 22);
            this.zoomInButton.TabIndex = 0;
            this.zoomInButton.Text = "Zoom in";
            this.zoomInButton.UseVisualStyleBackColor = true;
            this.zoomInButton.Click += new System.EventHandler(this.zoomInButton_Click);
            // 
            // zoomOutButton
            // 
            this.zoomOutButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zoomOutButton.Location = new System.Drawing.Point(487, 1);
            this.zoomOutButton.Margin = new System.Windows.Forms.Padding(1);
            this.zoomOutButton.Name = "zoomOutButton";
            this.zoomOutButton.Size = new System.Drawing.Size(88, 22);
            this.zoomOutButton.TabIndex = 1;
            this.zoomOutButton.Text = "Zoom out";
            this.zoomOutButton.UseVisualStyleBackColor = true;
            this.zoomOutButton.Click += new System.EventHandler(this.zoomOutButton_Click);
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
            // fftChart
            // 
            chartArea2.Name = "ChartArea1";
            this.fftChart.ChartAreas.Add(chartArea2);
            this.fftChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fftChart.Location = new System.Drawing.Point(3, 3);
            this.fftChart.Name = "fftChart";
            this.fftChart.Size = new System.Drawing.Size(1144, 493);
            this.fftChart.TabIndex = 0;
            this.fftChart.Text = "chart1";
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
            ((System.ComponentModel.ISupportInitialize)(this.waveChart)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.fourierTab.ResumeLayout(false);
            this.subLayout.ResumeLayout(false);
            this.subLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.zoomTableLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fftChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.Label filenameLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart waveChart;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage fourierTab;
        private System.Windows.Forms.TabPage spectrumTab;
        private System.Windows.Forms.TabPage fundamentalTab;
        private System.Windows.Forms.ComboBox windowCombobox;
        private System.Windows.Forms.TableLayoutPanel subLayout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TableLayoutPanel zoomTableLayout;
        private System.Windows.Forms.Button zoomInButton;
        private System.Windows.Forms.Button zoomOutButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart fftChart;
    }
}

