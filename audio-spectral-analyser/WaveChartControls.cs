using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
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

        public void PlotWave(OxyPlot.WindowsForms.PlotView view)
        {
            var mainModel = new PlotModel { };

            mainModel.Axes.Add(new OxyPlot.Axes.LinearAxis
            {
                Minimum = -1.0,
                Maximum = 1.0,
                MajorStep = 0.5,
            });

            mainModel.Axes.Add(new OxyPlot.Axes.LinearAxis
            {
                Position = OxyPlot.Axes.AxisPosition.Bottom,
                Title = "Time (s)",
            }); ;


            var series = new FunctionSeries { };
            foreach (var p in waveList)
                series.Points.Add(p);

            mainModel.Series.Add(series);
            view.Model = mainModel;
        }

        //public void PlotFFT(Chart fftChart)
        //{
        //    fftChart.Series.Clear();
        //    var series = fftChart.Series.Add("wave");
        //    series.ChartType = SeriesChartType.FastLine;
        //    series.ChartArea = "ChartArea1";

        //    var length = waveList.Count;
        //    var count = (int)Math.Pow(2, (int)Math.Log(length, 2) + 1);

        //    var fftWrapper = new FFTWrapper(count);
        //    foreach (var sample in waveList)
        //        fftWrapper.Add((float)sample.Item2);

        //    var result = fftWrapper.GetSeries();
        //    int i = 0;
        //    foreach(var f in result)
        //    {
        //        series.Points.AddXY(i * sampleRate / count + 1, f);
        //        i++;
        //    }
        //}
    }
}
