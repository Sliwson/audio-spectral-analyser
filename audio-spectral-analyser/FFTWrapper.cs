using MathNet.Numerics;
using OxyPlot;
using System;
using System.Collections;
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

        public FFTWrapper(List<DataPoint> series)
        {
            if (IsPowerOfTwo(series.Count))
                data = ConvertToFourierArray(series);
            else
                data = ResizeToPowerOfTwo(series);
        }

        public FFTWrapper(DataPoint[] series)
        {
            if (IsPowerOfTwo(series.Length))
                data = ConvertToFourierArray(series);
            else
                data = ResizeToPowerOfTwo(series.ToList());
        }

        public FFTWrapper(Complex[] series)
        {
            data = series;
        }

        public static Complex[] ResizeToPowerOfTwo(List<DataPoint> data)
        {
            var length = data.Count;
            var pow = (int)Math.Log(length, 2) + 1;
            var lengthPow = (int)Math.Pow(2, pow);
            var array = data.Select(d => new Complex(d.Y, 0)).ToArray();
            Array.Resize(ref array, lengthPow);
            return array;
        }

        public double[] CalculateMagnitude(WindowType windowType, bool forward = true)
        {
            var result = Calculate(windowType, forward);
            return result.Select(d => d.Magnitude).ToArray();
        }

        public Complex[] Calculate(WindowType windowType, bool forward = true)
        {
            var length = data.Length;
            var window = GetWindow(windowType, length);
            var scaledData = new Complex[length];
            for (int i = 0; i < data.Length; i++)
                scaledData[i] = data[i] * window[i];

            if (forward)
                MathNet.Numerics.IntegralTransforms.Fourier.Forward(scaledData);
            else
                MathNet.Numerics.IntegralTransforms.Fourier.Inverse(scaledData);

            return scaledData;
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

        private Complex[] ConvertToFourierArray(IEnumerable<DataPoint> ie)
        {
            return ie.Select(d => new Complex(d.Y, 0)).ToArray();
        }

        bool IsPowerOfTwo(int x)
        {
            return (x & (x - 1)) == 0;
        }
    }
}
