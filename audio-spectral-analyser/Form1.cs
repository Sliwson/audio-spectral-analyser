using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace audio_spectral_analyser
{
    public partial class Form1 : Form
    {
        private WaveChartControls waveChartControls = null;

        public Form1()
        {
            InitializeComponent();
            windowCombobox.SelectedIndex = 0;
        }

        private void OpenFileClick(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "All|*wav;*mp3|Wave file (*.wav)|*.wav|MP3 file (*.mp3)|*.mp3";
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            filenameLabel.Text = dialog.FileName;

            Cursor = Cursors.WaitCursor;
            waveChartControls = new WaveChartControls(dialog.FileName);
            waveChartControls.PlotWave(waveChart);
            RedrawFft();
            Cursor = Cursors.Default;
        }

        private void RedrawFft()
        {
            if (waveChartControls != null)
                waveChartControls.PlotFFT(fftChart, WindowTypeExtension.FromInt(windowCombobox.SelectedIndex));
        }

        private void OnWindowSelectedIndexChanged(object sender, EventArgs e)
        {
            RedrawFft();
        }
    }
}
