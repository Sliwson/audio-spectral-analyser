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
    public partial class PowerNumericUpDown : NumericUpDown
    {
        int currentPow = 10; 

        public PowerNumericUpDown()
        {
            InitializeComponent();
        }

        public override void DownButton()
        {
            if (currentPow - 1> Math.Log((double)Minimum, 2))
                currentPow--;

            Value = (int)Math.Pow(2, currentPow);
        }

        public override void UpButton()
        {
            if (currentPow + 1 < Math.Log((double)Maximum, 2))
                currentPow++;

            Value = (int)Math.Pow(2, currentPow);
        }
    }
}
