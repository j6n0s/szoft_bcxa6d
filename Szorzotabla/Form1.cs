namespace Szorzotabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int m�ret = 45;

            for (int sor = 1; sor <= 10; sor++)
            {
                for(int oszlop = 1; oszlop <= 10; oszlop++)
                {
                    Button b = new Button();
                    b.Text = (sor*oszlop).ToString();
                    b.Top = m�ret*(sor-1);
                    b.Left = m�ret*(oszlop-1);
                    b.Width = m�ret;
                    b.Height = m�ret;
                    Controls.Add(b);
                }
            }
        }
    }
}
