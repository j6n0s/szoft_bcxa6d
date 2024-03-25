using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KígyósJátékOtthon
{
    internal class AlmaElem : PictureBox
    {
        public static int Méret = 20;

        public AlmaElem() 
        {
            BackColor = Color.Red;
            Height = Méret;
            Width = Méret;
        }
    }
}
