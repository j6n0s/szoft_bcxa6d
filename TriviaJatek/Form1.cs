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
                
                int sorszám = 0;
                StreamReader file = new StreamReader("jatek.csv", true);
                while (!file.EndOfStream)
                {
                    string sor = file.ReadLine();
                    string[] kérdés = sor.Split(";");
                    KérdésUserControl kérdések = new KérdésUserControl(kérdés[0], kérdés[1], kérdés[2], kérdés[3], kérdés[4], int.Parse(kérdés[5]));
                    kérdések.Top = sorszám * kérdések.Height;
                    Controls.Add(kérdések);
                    sorszám++;
                    if (sorszám == 20) break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
