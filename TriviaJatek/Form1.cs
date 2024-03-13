using System.Web;

namespace TriviaJatek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                
                int sorsz�m = 0;
                StreamReader file = new StreamReader("jatek.csv", true);
                while (!file.EndOfStream)
                {
                    string sor = file.ReadLine();
                    string[] k�rd�s = sor.Split(";");
                    K�rd�sUserControl k�rd�sek = new K�rd�sUserControl(k�rd�s[0], k�rd�s[1], k�rd�s[2], k�rd�s[3], k�rd�s[4], int.Parse(k�rd�s[5]));
                    k�rd�sek.Top = sorsz�m * k�rd�sek.Height;
                    Controls.Add(k�rd�sek);
                    sorsz�m++;
                    if (sorsz�m == 20) break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
