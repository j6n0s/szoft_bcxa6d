namespace VillogoGomb
{
    public partial class Form1 : Form
    {
        int m�ret = 40;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //b.Left = ClientRectangle.Width / 2 - m�ret / 2;
            //b.Top = ClientRectangle.Height / 2 - m�ret / 2;

            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < 10; oszlop++)
                {
                    VillogoGomb b = new VillogoGomb();
                    Random rnd = new Random();
                    
                    //1-3 feladatok
                    b.Height = m�ret;
                    b.Width = m�ret;
                    b.Left =oszlop*m�ret;
                    b.Top = sor*m�ret;
                    b.Text = ((sor+1)*(oszlop+1)).ToString();
                    Controls.Add(b);
                }
            }
        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}
    }
}