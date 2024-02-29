using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillogoGomb
{
    internal class SzinezodoGomb : Button
    {
        int méret = 20;
        bool click = false;

        public SzinezodoGomb()
        {
            MouseClick += SzinezodoGomb_MouseClick;
            Width = méret;
            Height = méret;
            
        }

        private void SzinezodoGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            if (click == false)
            {
                BackColor = Color.Fuchsia;
                click = true;
            }
            else
            {
                BackColor = SystemColors.ButtonFace;
                click = false;
            }
            
         
        }
    }
}
