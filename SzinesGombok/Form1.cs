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
            int m�ret = 20;
            int n = 10;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Sz�nez�d�Gomb b = new Sz�nez�d�Gomb();
                    b.Top = i * b.Height;
                    b.Left = j * b.Width;
                    Controls.Add(b);

                }
            }
        }
    }
}
