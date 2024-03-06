using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzinesGombok
{
    internal class SzíneződőGomb : Button
    {
        int méret = 20;

        public SzíneződőGomb()
        {
            Width = méret;
            Height = méret;
            Click += SzíneződőGomb_Click;
        }

        private void SzíneződőGomb_Click(object? sender, EventArgs e)
        {
            BackColor = Color.Fuchsia;
        }
    }
}
