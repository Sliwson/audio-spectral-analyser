using MathNet.Numerics;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace audio_spectral_analyser
{
    class FFTWrapper
    {
        public FFTWrapper(float[] series)
        {
        }

        public static Complex[] ConvertToFourierSeries(List<DataPoint> data)
        {
            var length = data.Count;
            var lengthPow = (int)Math.Pow(2, (int)Math.Log(length, 2) + 1);
            var array = data.Select(d => new Complex(d.Y, 0)).ToArray();
            Array.Resize(ref array, lengthPow);
            return array;
        }

        public void Add(float value)
        {
            buffer[position].X = value; //(float)(value * FastFourierTransform.HammingWindow(position, length));
            buffer[position].Y = 0; // This is always zero with audio.
            position++;
            if (position >= length)
            {
                position = 0;
                FastFourierTransform.FFT(true, m, buffer);
            }
        }

        public List<float> GetSeries()
        {
            var series = new List<float>();
            FastFourierTransform.FFT(true, m, buffer);
            for(int i = 0; i < length / 2 ; i++)
            {
                var c = buffer[i];
                var mag = Math.Sqrt(c.X * c.X + c.Y * c.Y);
                series.Add((float)(20 * Math.Log10(mag)));
            }

            return series;
        }
    }
}
