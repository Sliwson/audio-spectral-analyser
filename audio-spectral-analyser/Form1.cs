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
        private Action[] tabRefreshActions;

        public Form1()
        {
            InitializeComponent();
            SetupRefreshActions();

            windowCombobox.SelectedIndex = 0;
        }

        private void SetupRefreshActions()
        {
            tabRefreshActions = new Action[]
            {
                RedrawFFT,
                RedrawSpectogram,
                RedrawFundamentalFrequency,
                RedrawVolume,
                RedrawFrequencyCentroid,
                RedrawEffectiveBandwidth,
                RedrawBandEnergy,
            };
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
            GetBasicUiFeatures(out int frameLength, out double overlapValue, out WindowType type);
            var oneFrame = oneFrameCheckBox.Checked;

            if (oneFrame)
            {
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
            GetBasicUiFeatures(out int frameLength, out double overlapValue, out WindowType type);
            waveChartControls.PlotSpectogram(spectrumPlot, type, frameLength, overlapValue);
        }

        private void RedrawFundamentalFrequency()
        {
            GetBasicUiFeatures(out int frameLength, out double overlapValue, out WindowType type);
            waveChartControls.PlotFundamentalFrequency(fundamentalPlot, type, frameLength, overlapValue);
        }

        private void RedrawVolume()
        {
            GetBasicUiFeatures(out int frameLength, out double overlapValue, out WindowType type);
            waveChartControls.PlotVolume(volumePlotChart, type, frameLength, overlapValue);
        }

        private void RedrawFrequencyCentroid()
        {
            GetBasicUiFeatures(out int frameLength, out double overlapValue, out WindowType type);
            waveChartControls.PlotFrequencyCentroid(frequencyCentroidChart, type, frameLength, overlapValue);
        }

        private void RedrawEffectiveBandwidth()
        {
            GetBasicUiFeatures(out int frameLength, out double overlapValue, out WindowType type);
            waveChartControls.PlotEffectiveBandwidth(effectiveBandwidthChart, type, frameLength, overlapValue);
        }

        private void RedrawBandEnergy()
        {
            GetBasicUiFeatures(out int frameLength, out double overlapValue, out WindowType type);
            waveChartControls.PlotBandEnergy(bandEnergyChart, type, frameLength, overlapValue);
        }

        private void GetBasicUiFeatures(out int frameLength, out double overlapValue, out WindowType outType)
        {
            frameLength = (int)frameLengthNumeric.Value;
            overlapValue = (double)overlap.Value;
            outType = WindowTypeExtension.FromInt(windowCombobox.SelectedIndex);
        }

        #region Redraw bindings

        private void OnWindowSelectedIndexChanged(object sender, EventArgs e)
        {
            RedrawAll();
        }

        private void OneFrameCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            if (waveChartControls != null)
                RedrawFFT();
        }

        private void FrameLengthNumericValueChanged(object sender, EventArgs e)
        {
            RedrawAll();
        }

        private void BeginFrameTimeValueChanged(object sender, EventArgs e)
        {
            if (waveChartControls != null)
                RedrawFFT();
            }

        private void TabControlSelectedIndexChanged(object sender, EventArgs e)
        {
            RedrawAll();
        }
        
        private void OverlapValueChanged(object sender, EventArgs e)
        {
            RedrawAll();
        }

        private void RedrawAll()
        {
            Cursor.Current = Cursors.WaitCursor;
            if (waveChartControls == null)
                return;

            int index = tabControl.SelectedIndex;
            tabRefreshActions[index].Invoke();
            
            Cursor.Current = Cursors.Default;
        }

        #endregion
    }
}
