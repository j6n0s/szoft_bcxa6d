using TriviaJatek;

namespace HajósKvíz
{
    public partial class Form1 : Form
    {
        List<HajosTeszt> ÖsszesKérdés;
        List<HajosTeszt> AktuálisKérdések;

        VálaszGomb VálaszGomb1;
        VálaszGomb VálaszGomb2;
        VálaszGomb VálaszGomb3;

        int AktuálisKérdés = 5;
        public Form1()
        {
            InitializeComponent();
            VálaszGomb1 = new VálaszGomb();
            VálaszGomb1.Top = 50;
            Controls.Add(VálaszGomb1);

            VálaszGomb2 = new VálaszGomb();
            VálaszGomb2.Top = 150;
            Controls.Add(VálaszGomb2);

            VálaszGomb3 = new VálaszGomb();
            VálaszGomb3.Top = 250;
            Controls.Add(VálaszGomb3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ÖsszesKérdés = KérdésBetöltés();
            List<HajosTeszt> AktuálisKérdések = new List<HajosTeszt>();
            for (int i = 0; i < 7; i++)
            {
                AktuálisKérdések.Add(ÖsszesKérdés[0]);
                ÖsszesKérdés.RemoveAt(0);
            }
            dataGridView2.DataSource = AktuálisKérdések;

            KérdésmegJelenítés(AktuálisKérdések[AktuálisKérdés]);
        }

        void KérdésmegJelenítés(HajosTeszt kérdés)
        {
            label1.Text = kérdés.KérdésSzöveg;
            label1.Font = new Font(Font.Name, 12);
            VálaszGomb1.Text = kérdés.Válasz1;
            VálaszGomb2.Text = kérdés.Válasz2;
            VálaszGomb3.Text = kérdés.Válasz3;

            if (string.IsNullOrEmpty(kérdés.URL))
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + kérdés.URL);
            }
        }

        List<HajosTeszt> KérdésBetöltés()
        {
            List<HajosTeszt> kérdések = new List<HajosTeszt>();
            try
            {
                StreamReader sr = new StreamReader("hajozasi_szabalyzat_kerdessor_BOM.txt", true);
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine() ?? "--";
                    string[] tömb = sor.Split("\t");
                    if (tömb.Length != 7) continue;
                    HajosTeszt k = new HajosTeszt();
                    k.KérdésSzöveg = tömb[1];
                    k.Válasz1 = tömb[2];
                    k.Válasz2 = tömb[3];
                    k.Válasz3 = tömb[4];
                    k.URL = tömb[5];

                    int x = 0;
                    int.TryParse(tömb[6], out x);
                    k.HelyesVálasz = x;
                    kérdések.Add(k);
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return kérdések;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kérdésUserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}