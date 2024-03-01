namespace RandomGombok
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
            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < 10; oszlop++)
                {
                    List<int> sor_rnd = new List<int>();
                    List<int> oszlop_rnd = new List<int>();
                    Random rnd = new Random();
                    Button b = new Button();
                    int sor_r = rnd.Next(0,11);
                    while (sor_rnd.Contains(sor_r) == true)
                    {
                        sor_r = rnd.Next(0, 11);
                    }
                    int oszlop_r = rnd.Next(0, 20);
                    while (oszlop_rnd.Contains(sor_r) == true)
                    {
                        oszlop_r = rnd.Next(0, 20);
                    }
                    sor_rnd.Add(sor_r);
                    oszlop_rnd.Add(oszlop_r);
                    b.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
                    b.Width = méret;
                    b.Height = méret;
                    b.Top = méret * sor_r;
                    b.Left = méret * oszlop_r;
                    Controls.Add(b);

                }
            }
        }
    }
}
