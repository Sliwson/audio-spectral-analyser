using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.WindowsForms;
using OxyPlot.Series;

namespace audio_spectral_analyser
{
    class WaveChartControls
    {
        private List<DataPoint> waveList = null;
        private TimeSpan length = new TimeSpan(0);
        private int sampleRate = 0;

        public WaveChartControls(string filename)
        {
            waveList = Load(filename);
        }

        private List<DataPoint> Load(string filename)
        {
            var wave = new AudioFileReader(filename);

            length = wave.TotalTime;
            sampleRate = wave.WaveFormat.SampleRate;

            const int readCount = 32768;
            int currentPoint = 0;
            double pointTimeInterval = 1.0 / wave.WaveFormat.AverageBytesPerSecond;
            var buffer = new byte[readCount];
            var rawSeries = new List<DataPoint>();
            while (wave.Position < wave.Length)
            {
                var read = wave.Read(buffer, 0, readCount);
                for (int i = 0; i < read / 4; i++)
                {
                    var time = currentPoint * pointTimeInterval * 4;
                    rawSeries.Add(new DataPoint(time, BitConverter.ToSingle(buffer, i * 4)));
                    currentPoint++;
                }
            }

            return rawSeries;
        }

        public void PlotWave(PlotView view)
        {
            var model = new PlotModel { };

            model.Axes.Add(new OxyPlot.Axes.LinearAxis
            {
                Minimum = -1.0,
                Maximum = 1.0,
                MajorStep = 0.5,
                Title = "Amplitude",
            });

            model.Axes.Add(new OxyPlot.Axes.LinearAxis
            {
                Position = OxyPlot.Axes.AxisPosition.Bottom,
                Title = "Time (s)",
            }); ;


            var series = new FunctionSeries { };
            foreach (var p in waveList)
                series.Points.Add(p);

            model.Series.Add(series);
            view.Model = model;
        }

        public void PlotFFTFull(PlotView view, WindowType windowType)
        {
            var fft = new FFTWrapper(waveList);
            var result = fft.Calculate(windowType);
            FillFFTView(view, result);
        }

        public void PlotFFTFrame(PlotView view, WindowType type, int frameLength, double beginTime)
        {
            var result = GetSample(frameLength, beginTime).ToList();
            var fft = new FFTWrapper(result);
            var calculated = fft.Calculate(type);
            FillFFTView(view, calculated);
        }

        private DataPoint[] GetSample(int frameLength, double beginTime)
        {
            var result = waveList.Where(w => w.X >= beginTime).ToArray();
            Array.Resize(ref result, frameLength);
            return result;
        }

        private void FillFFTView(PlotView view, double[] result)
        {
            var model = new PlotModel { };

            model.Axes.Add(new OxyPlot.Axes.LinearAxis
            {
                Title = "Amplitude (dB)"
            });

            model.Axes.Add(new OxyPlot.Axes.LinearAxis
            {
                Position = OxyPlot.Axes.AxisPosition.Bottom,
                Title = "Frequency (Hz)",
            });

            var series = new FunctionSeries { };
            for (int i = 0; i < result.Length / 2; i++)
                series.Points.Add(new DataPoint((double)i * sampleRate / result.Length, 20 * Math.Log10(result[i])));

            model.Series.Add(series);
            view.Model = model;
        }
    }
}
