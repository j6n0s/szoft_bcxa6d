using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace KigyósJáték
{
    internal class Alma : PictureBox
    {
        public static int Méret = 20;

        public Alma()
        {
            Width = Alma.Méret;
            Height = Alma.Méret;
            BackColor = Color.Red;
        }
    }
}
