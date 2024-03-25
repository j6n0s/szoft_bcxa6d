namespace HajósKvízOtthon_2_
{
    public partial class Form1 : Form
    {
        List<Kérdés> ÖsszesKérdés;
        List<Kérdés> AktívKérdések;
        int AktívKérdés = 6;

        VálaszGomb Válasz1;
        VálaszGomb Válasz2;
        VálaszGomb Válasz3;

        public Form1()
        {
            InitializeComponent();
            Válasz1 = new VálaszGomb();
            Válasz1.Top = 50;
            Controls.Add(Válasz1);

            Válasz2 = new VálaszGomb();
            Válasz2.Top = 150;
            Controls.Add(Válasz2);

            Válasz3 = new VálaszGomb();
            Válasz3.Top = 250;
            Controls.Add(Válasz3);
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

            //TextBoxo-k megjelenítése
            KérdésMegjelenítés(AktívKérdések[AktívKérdés]);


            dataGridView1.DataSource = AktívKérdések;
            Válasz1.MouseClick += Válasz1_MouseClick;
            Válasz2.MouseClick += Válasz2_MouseClick;
            Válasz3.MouseClick += Válasz3_MouseClick;
        }

        void VálaszValidálás()
        {
            if (AktívKérdések[AktívKérdés].HelyesVálasz == 1) { Válasz1.BackColor = Color.Green; }
            if (AktívKérdések[AktívKérdés].HelyesVálasz == 2) { Válasz2.BackColor = Color.Green; }
            if (AktívKérdések[AktívKérdés].HelyesVálasz == 3) { Válasz3.BackColor = Color.Green; }
            Válasz1.Enabled = false;
            Válasz2.Enabled = false;
            Válasz3.Enabled = false;
        }

        void Visszaállítás()
        {
            Válasz1.BackColor = Color.Gray;
            Válasz2.BackColor = Color.Gray;
            Válasz3.BackColor = Color.Gray;
            Válasz1.Enabled = true;
            Válasz2.Enabled = true;
            Válasz3.Enabled = true;
        }

        private void Válasz3_MouseClick(object? sender, MouseEventArgs e)
        {
            Válasz3.BackColor = Color.Red;
            if(AktívKérdések[AktívKérdés].HelyesVálasz == 3) { AktívKérdések[AktívKérdés].HelyesVálaszokSzáma++; }
            VálaszValidálás();
        }

        private void Válasz2_MouseClick(object? sender, MouseEventArgs e)
        {
            Válasz2.BackColor = Color.Red;
            if (AktívKérdések[AktívKérdés].HelyesVálasz == 2) { AktívKérdések[AktívKérdés].HelyesVálaszokSzáma++; }
            VálaszValidálás();
        }

        private void Válasz1_MouseClick(object? sender, MouseEventArgs e)
        {
            Válasz1.BackColor = Color.Red;
            if (AktívKérdések[AktívKérdés].HelyesVálasz == 1) { AktívKérdések[AktívKérdés].HelyesVálaszokSzáma++; }
            VálaszValidálás();
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

        void KérdésMegjelenítés(Kérdés kérdés)
        {
            label1.Text = kérdés.KérdésSzöveg;
            label1.Font = new Font(Font.Name, 12);
            Válasz1.Text = kérdés.Válasz1;
            Válasz2.Text = kérdés.Válasz2;
            Válasz3.Text = kérdés.Válasz3;
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

        //Csere ha elérte 3 jó választ
        void KérdésCsere()
        {
            AktívKérdések[AktívKérdés] = ÖsszesKérdés[0];
            ÖsszesKérdés.RemoveAt(0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visszaállítás();
            if(AktívKérdések[AktívKérdés].HelyesVálaszokSzáma == 3) { KérdésCsere(); }
            if (AktívKérdés == 6)
            {
                AktívKérdés = 0;
                KérdésMegjelenítés(AktívKérdések[AktívKérdés]);
            }
            else
            {
                AktívKérdés++;
                KérdésMegjelenítés(AktívKérdések[AktívKérdés]);
            }

        }
    }

}
