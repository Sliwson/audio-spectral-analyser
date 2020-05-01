using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NAudio.Dsp;
using System.Threading.Tasks;

namespace audio_spectral_analyser
{
    class FFTWrapper
    {

        private Complex[] buffer;
        private int position;
        private int length;
        private int m;

        public FFTWrapper(int fftLength)
        {
            this.m = (int)Math.Log(fftLength, 2.0);
            length = fftLength;
            this.buffer = new Complex[fftLength];
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
