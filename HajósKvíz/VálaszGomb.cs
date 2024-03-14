using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HajósKvíz
{
    internal class VálaszGomb : TextBox
    {
        public VálaszGomb()
        {
            ReadOnly = true;
            BackColor = Color.Gray;
            BorderStyle = BorderStyle.None;
            Multiline = true;
            Width = 440;
            Height = 80;
            Font = new Font(Font.Name, 14);
        }
    }
}
