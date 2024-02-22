namespace Fibinacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Sor> lista = new List<Sor>();
            for (int i = 0; i < 10; i++)
            {
                Button button = new Button();
                button.Top = i * 20;
                button.Text = Fibonacci(i).ToString();
                Controls.Add(button);

                Sor uj_sor = new Sor();
                uj_sor.Sor_szám = i;
                uj_sor.Érték = Fibonacci(i);
                lista.Add(uj_sor);
            }
            dataGridView1.DataSource = lista;
        }

        int Fibonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}