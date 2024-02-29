namespace VillogoGomb
{
    public partial class Form1 : Form
    {
        int méret = 40;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //b.Left = ClientRectangle.Width / 2 - méret / 2;
            //b.Top = ClientRectangle.Height / 2 - méret / 2;

            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < 10; oszlop++)
                {
                    SzámolóGomb b = new SzámolóGomb();
                    Random rnd = new Random();
                    b.Left = rnd.Next(1, ClientRectangle.Width - méret);
                    b.Top = rnd.Next(1, ClientRectangle.Height - méret);
                    //1-3 feladatok
                    b.Height = méret;
                    b.Width = méret;
                    //b.Left =oszlop*méret;
                    //b.Top = sor*méret;
                    //b.Text = ((sor+1)*(oszlop+1)).ToString();
                    Controls.Add(b);
                }
            }
        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}
    }
}