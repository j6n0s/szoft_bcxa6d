using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HajósKvízOtthon_2_
{
    internal class VálaszGomb : TextBox
    {
        public VálaszGomb()
        {
            BackColor = Color.LightCoral;
            Multiline = true;
            ReadOnly = true;

            MouseEnter += VálaszGomb_MouseEnter;
            MouseLeave += VálaszGomb_MouseLeave;

            BorderStyle = BorderStyle.None;
            Cursor = Cursors.Hand;
        }

        private void VálaszGomb_MouseLeave(object? sender, EventArgs e)
        {
            BorderStyle = BorderStyle.None;
        }

        private void VálaszGomb_MouseEnter(object? sender, EventArgs e)
        {
            BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
