namespace Hatvanyok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{


        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Hatványozás> list = new List<Hatványozás>();
            for (int i = 0; i < 10; i++)
            {
                Hatványozás b = new Hatványozás();
                b.Szám = i;
                b.Másodikon = (int)Math.Pow( i,  2);
                list.Add(b);
            }
        }
    }
}