namespace Karacsonyfa
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

            for (int sor = 0; sor < n; sor++)
            {
                for (int oszlop = 0; oszlop <= sor; oszlop++)
                {

                    Button button = new Button(); 
                    button.Width = m�ret;
                    button.Height = m�ret;
                    button.Top = m�ret*sor;
                    button.Left = ClientRectangle.Width/2-(m�ret/2)-(sor*10)+(m�ret*oszlop);
                    Controls.Add(button);
                }
            }
        }
    }
}
