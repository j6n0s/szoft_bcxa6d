namespace Fib_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int n = 10;
            int m�ret = 40;

            

            for (int i = 0; i < n; i++)
            {
                Button b = new Button();
                b.Text = Fib(i).ToString();
                b.Width = m�ret;
                b.Height = m�ret;
                b.Top = i * m�ret;
                Controls.Add(b);
            }

            List<Elem> list = new List<Elem>();
            for (int i = 0; i < n; i++)
            {
                Elem elem = new Elem();
                elem.Sorsz�m = i + 1;
                elem.�rt�k = Fib(i);
                list.Add(elem);
            }
            dataGridView1.DataSource = list;
            
        }

        int Fib(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fib(n - 1) + Fib(n - 2);
        }
    }
}
