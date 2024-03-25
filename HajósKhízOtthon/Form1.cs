namespace HajósKhízOtthon
{
    public partial class Form1 : Form
    {
        List<Kérdés> ÖsszesKérdés;
        List<Kérdés> AktívKérdések;
        int AktívKérdés = 5;
        public Form1()
        {
            InitializeComponent();
        }

        List<Kérdés> KérdésBeolvasás()
        {
            List<Kérdés> kérdések = new List<Kérdés>();
            try
            {
                int sorszám = 0;
                StreamReader file = new StreamReader("kerdesek\\hajozasi_szabalyzat_kerdessor_BOM.txt");

                while (!file.EndOfStream)
                {
                    sorszám++;
                    string sor = file.ReadLine();
                    string[] elemek = sor.Split("\t");

                    Kérdés k = new Kérdés();
                    k.KérdésSzöveg = elemek[1];
                    k.Válasz1 = elemek[2];
                    k.Válasz2 = elemek[3];
                    k.Válasz3 = elemek[4];
                    k.URL = elemek[5];

                    int.TryParse(elemek[6], out int jóválasz);
                    k.HelyesVálasz = jóválasz;

                    kérdések.Add(k);
                    if (sorszám == 100) break;
                }

                file.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return kérdések;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ÖsszesKérdés = KérdésBeolvasás();
            AktívKérdések = new List<Kérdés>();
            for (int i = 0; i < 7; i++)
            {
                AktívKérdések.Add(ÖsszesKérdés[0]);
                ÖsszesKérdés.RemoveAt(0);
            }

            dataGridView1.DataSource = AktívKérdések;

        }
    }
}
