namespace GombokHaromszogben
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int méret = 40;
            int n = 10;
            
            for (int sor = 0; sor < n; sor++)
            {
                for (int oszlop = 0; oszlop <= sor; oszlop++)
                {
                    Button button = new Button();
                    button.Width = méret;
                    button.Height = méret;
                    button.Left = oszlop * méret;
                    button.Top = sor * méret;
                    Controls.Add(button);
                }
            }

        }
    }
}
