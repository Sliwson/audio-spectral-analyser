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
            RedrawAll();
            Cursor = Cursors.Default;
        }

        private void RedrawFFT()
        {
            if (waveChartControls == null || tabControl.SelectedIndex != 0)
                return;

            var type = WindowTypeExtension.FromInt(windowCombobox.SelectedIndex);
            var oneFrame = oneFrameCheckBox.Checked;
            if (oneFrame)
            {
                var frameLength = (int)frameLengthNumeric.Value;
                var beginTime = (double)beginFrameTime.Value;
                waveChartControls.PlotFFTFrame(fftChart, type, frameLength, beginTime);
            }
            else
            {
                waveChartControls.PlotFFTFull(fftChart, type);
            }
        }

        private void RedrawSpectogram()
        {
            if (waveChartControls == null || tabControl.SelectedIndex != 1)
                return;

            var frameLength = (int)frameLengthNumeric.Value;
            var overlap = (double)overlapNumeric.Value;
            var type = WindowTypeExtension.FromInt(windowCombobox.SelectedIndex);
            waveChartControls.PlotSpectogram(spectrumPlot, type, frameLength, overlap);
        }

        private void RedrawFundamentalFrequency()
        {
            if (waveChartControls == null || tabControl.SelectedIndex != 2)
                return;
            
            var frameLength = (int)frameLengthNumeric.Value;
            var overlap = (double)fundamentalOverlap.Value;
            var type = WindowTypeExtension.FromInt(windowCombobox.SelectedIndex);
            waveChartControls.PlotFundamentalFrequency(fundamentalPlot, type, frameLength, overlap);
        }

        #region Redraw bindings

        private void OnWindowSelectedIndexChanged(object sender, EventArgs e)
        {
            RedrawAll();
        }

        private void OneFrameCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            RedrawFFT();
        }

        private void FrameLengthNumericValueChanged(object sender, EventArgs e)
        {
            RedrawAll();
        }

        private void BeginFrameTimeValueChanged(object sender, EventArgs e)
        {
            RedrawFFT();
        }

        private void TabControlSelectedIndexChanged(object sender, EventArgs e)
        {
            RedrawAll();
        }

        private void OverlapNumericValueChanged(object sender, EventArgs e)
        {
            RedrawSpectogram();
        }

        private void FundamentalOverlapValueChanged(object sender, EventArgs e)
        {
            RedrawFundamentalFrequency();
        }

        private void RedrawAll()
        {
            RedrawFFT();
            RedrawSpectogram();
            RedrawFundamentalFrequency();
        }

        #endregion
    }
}
