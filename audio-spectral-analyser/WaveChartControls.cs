using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace audio_spectral_analyser
{
    class WaveChartControls
    {
        private static DateTime Date0 => DateTime.MinValue;
        private Chart waveChart = null;
        private List<(double, double)> waveList = null;
        private TimeSpan length = new TimeSpan(0);
        private int sampleRate = 0;

        public WaveChartControls(Chart chart, string filename)
        {
            waveChart = chart;
            waveList = Load(filename);
            Configure();
            Plot();
        }

        public void ZoomIn()
        {
            var xAxis = waveChart.ChartAreas.First().AxisX;
            var xMin = xAxis.ScaleView.ViewMinimum;
            var xMax = xAxis.ScaleView.ViewMaximum;
            xAxis.ScaleView.Zoom(xMin, (xMax - xMin) / 2);
        }

        public void ZoomOut()
        {
            var xAxis = waveChart.ChartAreas.First().AxisX;
            var xMin = xAxis.ScaleView.ViewMinimum;
            var xMax = xAxis.ScaleView.ViewMaximum;
            var part = (xMax - xMin) / 3;
            var left = Math.Max(xMin - part, xAxis.Minimum);
            var right = Math.Min(xMax + part, xAxis.Maximum);
            xAxis.ScaleView.Zoom(left, right);
        }

        private List<(double, double)> Load(string filename)
        {
            var wave = filename.EndsWith("wav") ?
                new WaveChannel32(new WaveFileReader(filename)) :
                new WaveChannel32(new Mp3FileReader(filename));

            length = wave.TotalTime;
            sampleRate = wave.WaveFormat.SampleRate;

            const int readCount = 32768;
            int currentPoint = 0;
            double pointTimeInterval = 1.0 / wave.WaveFormat.AverageBytesPerSecond;
            var buffer = new byte[readCount];
            List<(double, double)> rawSeries = new List<(double, double)>();
            while (wave.Position < wave.Length)
            {
                var read = wave.Read(buffer, 0, readCount);
                for (int i = 0; i < read / 4; i++)
                {
                    var time = Date0.AddSeconds(currentPoint * pointTimeInterval * 4);
                    rawSeries.Add((time.ToOADate(), BitConverter.ToSingle(buffer, i * 4)));
                    currentPoint++;
                }
            }

            return rawSeries;
        }

        private void Configure()
        {
            waveChart.Series.Clear();

            var series = waveChart.Series.Add("wave");
            series.ChartType = SeriesChartType.FastLine;
            series.ChartArea = "ChartArea1";
            series.XValueType = ChartValueType.DateTime;

            var chartArea = waveChart.ChartAreas[0];
            var ax = chartArea.AxisX;
            ax.IntervalType = DateTimeIntervalType.Seconds;
            ax.LabelStyle.Format = "ss.ff";
            ax.ScrollBar.Enabled = true;
            ax.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
            ax.ScaleView.Zoomable = true;
            ax.ScaleView.SmallScrollMinSize = 50;
            ax.ScaleView.SmallScrollMinSizeType = DateTimeIntervalType.Milliseconds;

            ax.Minimum = Date0.ToOADate();
            ax.Maximum = Date0.AddSeconds(length.TotalSeconds).ToOADate();
            ax.Interval = 0.1;
        }

        private void Plot()
        {
            var series = waveChart.Series.First();
            foreach (var p in waveList)
                series.Points.AddXY(p.Item1, p.Item2);
        }
    }
}
