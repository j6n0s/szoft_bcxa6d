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
            int méret = 40;

            

            for (int i = 0; i < n; i++)
            {
                Button b = new Button();
                b.Text = Fib(i).ToString();
                b.Width = méret;
                b.Height = méret;
                b.Top = i * méret;
                Controls.Add(b);
            }

            List<Elem> list = new List<Elem>();
            for (int i = 0; i < n; i++)
            {
                Elem elem = new Elem();
                elem.Sorszám = i + 1;
                elem.Érték = Fib(i);
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
