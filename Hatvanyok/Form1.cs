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
            List<Hatv�nyoz�s> list = new List<Hatv�nyoz�s>();
            for (int i = 0; i < 10; i++)
            {
                Hatv�nyoz�s b = new Hatv�nyoz�s();
                b.Sz�m = i;
                b.M�sodikon = (int)Math.Pow( i,  2);
                list.Add(b);
            }
        }
    }
}