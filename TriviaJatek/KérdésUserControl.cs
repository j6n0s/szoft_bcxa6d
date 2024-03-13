using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaJatek
{
    public partial class KérdésUserControl : UserControl
    {
        int helyes;
        public KérdésUserControl()
        {
            InitializeComponent();
        }
        public KérdésUserControl(string kérdés, string válasz1, string válasz2, string válasz3, string válasz4, int helyes)
        {
            InitializeComponent();
            label1.Text = kérdés;
            button1.Text = válasz1;
            button2.Text = válasz2;
            button3.Text = válasz3;
            button4.Text = válasz4;
            this.helyes = helyes;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (helyes == 1)
            {
                button1.BackColor = Color.Green;
            }
            else
            {
                if (helyes == 2) { button2.BackColor = Color.Green; }
                else { button2.BackColor = SystemColors.ButtonFace; }
                if (helyes == 3) { button3.BackColor = Color.Green; }
                else { button3.BackColor = SystemColors.ButtonFace; }
                if (helyes == 4) { button4.BackColor = Color.Green; }
                else { button4.BackColor = SystemColors.ButtonFace; }
                button1.BackColor = Color.Red;
            }
        }
        public void button2_Click(object sender, EventArgs e)
        {
            if (helyes == 2)
            {
                button2.BackColor = Color.Green;
            }
            else
            {
                if (helyes == 1) { button1.BackColor = Color.Green; }
                else { button1.BackColor = SystemColors.ButtonFace; }
                if (helyes == 3) { button3.BackColor = Color.Green; }
                else { button3.BackColor = SystemColors.ButtonFace; }
                if (helyes == 4) { button4.BackColor = Color.Green; }
                else { button4.BackColor = SystemColors.ButtonFace; }
                button2.BackColor = Color.Red;
            }
        }
        public void button3_Click(object sender, EventArgs e)
        {
            if (helyes == 3)
            {
                button3.BackColor = Color.Green;
            }
            else
            {
                if (helyes == 1) { button1.BackColor = Color.Green; }
                else { button1.BackColor = SystemColors.ButtonFace; }
                if (helyes == 2) { button2.BackColor = Color.Green; }
                else { button2.BackColor = SystemColors.ButtonFace; }
                if (helyes == 4) { button4.BackColor = Color.Green; }
                else { button4.BackColor = SystemColors.ButtonFace; }
                button3.BackColor = Color.Red;
            }
        }
        public void button4_Click(object sender, EventArgs e)
        {
            if (helyes == 4)
            {
                button4.BackColor = Color.Green;
            }
            else
            {
                if (helyes == 1) { button1.BackColor = Color.Green; }
                else { button1.BackColor = SystemColors.ButtonFace; }
                if (helyes == 2) { button2.BackColor = Color.Green; }
                else { button2.BackColor = SystemColors.ButtonFace; }
                if (helyes == 3) { button3.BackColor = Color.Green; }
                else { button3.BackColor = SystemColors.ButtonFace; }
                button4.BackColor = Color.Red;
            }
        }
    }
}
