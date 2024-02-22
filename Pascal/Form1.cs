namespace Pascal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int m = 40;
            for (int sor = 0; sor < 10; sor++) 
            {
                for (int oszlop = 0; oszlop < sor+1; oszlop++)
                {
                    Button button = new Button();
                    Controls.Add(button);
                    button.Top = m* sor;
                    button.Left = m* oszlop + Width / 2;
                    button.Height = m;
                    button.Width = m;
                    int x = Faktoriális(sor) / (Faktoriális(oszlop)*Faktoriális(sor-oszlop));
                    button.Text = x.ToString();
                    
                }
            }
        }

        int Faktoriális(int n)
        {
            if (n == 0 || n == 1){return 1;}
            else { return n*Faktoriális(n-1); }
        }
    }
}