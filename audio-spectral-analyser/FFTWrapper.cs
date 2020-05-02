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
        Complex[] data = null;

        public FFTWrapper(Complex[] series)
        {
            data = series;
        }

        public static Complex[] ConvertToFourierSeries(List<DataPoint> data)
        {
            var length = data.Count;
            var lengthPow = (int)Math.Pow(2, (int)Math.Log(length, 2) + 1);
            var array = data.Select(d => new Complex(d.Y, 0)).ToArray();
            Array.Resize(ref array, lengthPow);
            return array;
        }

        public double[] Calculate(WindowType windowType)
        {
            var length = data.Length;
            var window = GetWindow(windowType, length);
            var scaledData = new Complex[length];
            for (int i = 0; i < data.Length; i++)
                scaledData[i] = data[i] * window[i];

            MathNet.Numerics.IntegralTransforms.Fourier.Forward(scaledData, MathNet.Numerics.IntegralTransforms.FourierOptions.Matlab);
            return data.Select(d => d.Magnitude).ToArray();
        }

        private double[] GetWindow(WindowType type, int width)
        {
            switch (type)
            {
                case WindowType.Rectangle:
                    var window = new double[width];
                    window.Fill(1.0);
                    return window;
                case WindowType.Hamming:
                    return Window.Hamming(width);
                case WindowType.Hann:
                    return Window.Hann(width);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
