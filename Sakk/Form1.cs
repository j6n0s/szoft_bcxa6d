namespace Sakk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int n = 8;
            int m�ret = 50;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i % 2 != 0)
                    {
                        if ((j % 2) == 0)
                        {
                            Button b = new Button();
                            b.Width = m�ret;
                            b.Height = m�ret;
                            b.Left = m�ret * j;
                            b.Top = m�ret * i;
                            b.BackColor = Color.Black;
                            Controls.Add(b);
                        }
                    }
                    else
                    {
                        if ((j % 2) != 0)
                        {
                            Button b = new Button();
                            b.Width = m�ret;
                            b.Height = m�ret;
                            b.Left = m�ret * j;
                            b.Top = m�ret * i;
                            b.BackColor = Color.Black;
                            Controls.Add(b);
                        }
                    }
                }
            }
        }
    }
}
