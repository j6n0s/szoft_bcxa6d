namespace SzinesGombok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int méret = 20;
            int n = 10;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    SzínezõdõGomb b = new SzínezõdõGomb();
                    b.Top = i * b.Height;
                    b.Left = j * b.Width;
                    Controls.Add(b);

                }
            }
        }
    }
}
