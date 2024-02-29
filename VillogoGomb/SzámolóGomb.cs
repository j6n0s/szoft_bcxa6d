using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillogoGomb
{
    internal class SzámolóGomb : Button
    {
        int méret = 20;
        int szám = 0;
        public SzámolóGomb()
        {
            Width = méret;
            Height = méret;
            MouseClick += SzámolóGomb_MouseClick;
        }

        private void SzámolóGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            if (szám == 5)
            {
                szám = 1;
            }
            else
            {
                szám++;
            }
            Text = szám.ToString();
        }
    }
}
