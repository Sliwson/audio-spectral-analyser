using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audio_spectral_analyser
{
    public enum WindowType
    {
        Rectangle,
        Hamming,
        Hann
    }

    public static class WindowTypeExtension
    {
        public static WindowType FromInt(int i)
        {
            try
            {
                return (WindowType)i;
            } 
            catch { }
            return WindowType.Rectangle;
        }
    }
}
