using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.WindowsForms;
using OxyPlot.Series;
using OxyPlot.Axes;
using MathNet.Numerics;
using System.Numerics;

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
            });

            var series = new FunctionSeries { };
            foreach (var p in waveList)
                series.Points.Add(p);

            model.Series.Add(series);
            view.Model = model;
        }

        public void PlotFFTFull(PlotView view, WindowType windowType)
        {
            var fft = new FFTWrapper(waveList);
            var result = fft.CalculateMagnitude(windowType);
            FillFFTView(view, result);
        }

        public void PlotFFTFrame(PlotView view, WindowType type, int frameLength, double beginTime)
        {
            var result = GetSample(frameLength, beginTime).ToList();
            var fft = new FFTWrapper(result);
            var calculated = fft.CalculateMagnitude(type);
            FillFFTView(view, calculated);
        }

        private DataPoint[] GetSample(int frameLength, double beginTime)
        {
            var result = waveList.Where(w => w.X >= beginTime).ToArray();
            Array.Resize(ref result, frameLength);
            return result;
        }

        private DataPoint[] GetSample(int frameLength, int beginPoint)
        {
            var minLength = Math.Min(frameLength, waveList.Count - beginPoint);
            var result = waveList.GetRange(beginPoint, minLength).ToArray();
            Array.Resize(ref result, frameLength);
            return result;
        }

        private void FillFFTView(PlotView view, double[] result)
        {
            var model = new PlotModel { };

            model.Axes.Add(new LinearAxis
            {
                Title = "Amplitude (dB)"
            });

            model.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Frequency (Hz)",
            });

            var series = new FunctionSeries { };
            for (int i = 0; i < result.Length / 2; i++)
                series.Points.Add(new DataPoint((double)i * sampleRate / result.Length, 20 * Math.Log10(result[i])));

            model.Series.Add(series);
            view.Model = model;
        }

        public void PlotSpectogram(PlotView view, WindowType windowType, int frameLength, double overlap)
        {
            var span = (int)Math.Round(frameLength * (1.0 - overlap));
            int columns = waveList.Count / span;
            var data = new double[columns, frameLength / 2];
            for (int i = 0, beginPoint = 0; i < columns; i++, beginPoint += span)
            {
                var sample = GetSample(frameLength, beginPoint);
                var fft = new FFTWrapper(sample);
                var result = fft.CalculateMagnitude(windowType);
                for (int y = 0; y < frameLength / 2; y++)
                    data[i, y] = 20 * Math.Log10(result[y]);
            }
            
            FillSpectogram(view, data);
        }

        private void FillSpectogram(PlotView view, double[,] data)
        {
            var model = new PlotModel { };

            model.Axes.Add(new LinearColorAxis { });

            model.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "Frequency (Hz)",
            });

            model.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Time (s)",
            });

            var series = new HeatMapSeries
            {
                X0 = 0,
                X1 = length.TotalSeconds,
                Y0 = 0,
                Y1 = sampleRate / 2,
                RenderMethod = HeatMapRenderMethod.Bitmap,
                Interpolate = true,
                Data = data
            };

            model.Series.Add(series);
            view.Model = model;
        }

        public void PlotFundamentalFrequency(PlotView view, WindowType windowType, int frameLength, double overlap)
        { 
            var span = (int)Math.Round(frameLength * (1.0 - overlap));
            var columns = waveList.Count / span;
            var data = new double[columns];
            var begin = 2 * 50 * frameLength / sampleRate;
            var end = 2 * 400 * frameLength / sampleRate;
            if (begin == end)
            {
                FillDefaultPlotView(view, "Frequency (Hz)", data);
                return;
            }

            for (int i = 0, beginPoint = 0; i < columns; i++, beginPoint += span)
            {
                var sample = GetSample(frameLength, beginPoint);
                var fft = new FFTWrapper(sample);
                var forward = fft.CalculateMagnitude(windowType);
                var inverse = new FFTWrapper(forward.Select(d => new Complex(Math.Log10(d), 0)).ToArray());
                var result = inverse.Calculate(windowType, false).Select(d => d.Real);
                var resultSnip = result.Skip(begin).Take(end - begin).ToList();
                var max = resultSnip.IndexOf(resultSnip.Max());
                var realIdx = max + begin;
                data[i] = realIdx * sampleRate / (2 * frameLength);
            }

            FillDefaultPlotView(view, "Frequency (Hz)", data);
        }

        public void PlotVolume(PlotView view, WindowType windowType, int frameLength, double overlap)
        {

        }

        public void PlotFrequencyCentroid(PlotView view, WindowType windowType, int frameLength, double overlap)
        {

        }

        public void PlotEffectiveBandwidth(PlotView view, WindowType windowType, int frameLength, double overlap)
        {
    
        }

        public void PlotBandEnergy(PlotView view, WindowType windowType, int frameLength, double overlap)
        {
    
        }

        private void FillDefaultPlotView(PlotView view, string yTitle, double[] result)
        {
            var model = new PlotModel { };

            model.Axes.Add(new LinearAxis
            {
                Title =  yTitle
            });

            model.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Time (s)"
            });

            var series = new FunctionSeries { };
            for (int i = 0; i < result.Length; i++)
                series.Points.Add(new DataPoint((double)i * length.TotalSeconds / result.Length, result[i]));

            model.Series.Add(series);
            view.Model = model;
        }
    }
}
