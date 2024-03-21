namespace KigyósJáték
{
    public partial class Form1 : Form
    {
        //kigyó
        int fej_x = 100;
        int fej_y = 100;
        int irány_x = 1;
        int irány_y = 0;
        int lépésszám = 0;

        //alam
        int alma_x = 0;
        int alma_y = 0;
        bool játékban = false;

        List<KígyóElem> kígyó = new List<KígyóElem>();
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lépésszám++;

            //Fejnövesztés
            fej_x += irány_x * KígyóElem.Méret;
            fej_y += irány_y * KígyóElem.Méret;

            foreach (object item in Controls)
            {
                if (item is KígyóElem)
                {
                    KígyóElem k = (KígyóElem)item;

                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
            }

            //Alma
            if (játékban == false)
            {
                Random rnd = new Random();
                Alma alma = new Alma();
                alma_x = Alma.Méret * rnd.Next(0, (ClientRectangle.Width/Alma.Méret));
                alma_y = Alma.Méret * rnd.Next(0, (ClientRectangle.Height / Alma.Méret));
                alma.Top = alma_y;
                alma.Left = alma_x;
                Controls.Add(alma);
                játékban = true;
            }

            KígyóElem ke = new KígyóElem();
            ke.Top = fej_y;
            ke.Left = fej_x;
            kígyó.Add(ke);
            if (lépésszám % 2 == 0) ke.BackColor = Color.Yellow;
            Controls.Add(ke);
            if (kígyó.Count > KígyóElem.hossz)
            {
                KígyóElem levágandó = kígyó[0];
                kígyó.RemoveAt(0);
                Controls.Remove(levágandó);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up & irány_y != 1 & irány_x != 0)
            {
                irány_y = -1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Down & irány_y != -1 & irány_x != 0)
            {
                irány_y = 1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Left & irány_y != 0 & irány_x != 1)
            {
                irány_y = 0;
                irány_x = -1;
            }

            if (e.KeyCode == Keys.Right & irány_y != 0 & irány_x != -1)
            {
                irány_y = 0;
                irány_x = 1;
            }
        }
    }
}