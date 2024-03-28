using System.Timers;

namespace KígyósJátékOtthon
{
    public partial class Form1 : Form
    {
        //Alma helye
        int alma_y = 0;
        int alma_x = 0;
        int elhelyezett_almák = 3;
        List<AlmaElem> a_elem = new List<AlmaElem>();

        //Kígyó helye
        int y_irány = 0;
        int x_irány = 1;
        int fej_poz_x = 3 * KígyóElem.Méret;
        int fej_poz_y = 4 * KígyóElem.Méret;
        int kígyó_növekedés = 1;
        List<KígyóElem> k_elem = new List<KígyóElem>();

        //Client méret
        int ablak_hossz = 340;
        int ablak_magasság = 400;

        public Form1()
        {
            InitializeComponent();
        }


        //Alaphelyzetbe állítás
        void Alaphelyzet()
        {
            y_irány = 0;
            x_irány = 1;
            fej_poz_x = 3 * KígyóElem.Méret;
            fej_poz_y = 4 * KígyóElem.Méret;
            k_elem.Clear();
            a_elem.Clear();
            Controls.Clear();
            KígyóElem.Hossz = 3;
            timer1.Enabled = true;
        }

        //Alma magevése
        void Alma_evés(KígyóElem kígyó)
        {
            foreach (AlmaElem vizsg_alma in a_elem)
            {
                if (kígyó.Top == vizsg_alma.Top && kígyó.Left == vizsg_alma.Left)
                {
                    KígyóElem.Hossz += kígyó_növekedés;
                    Controls.Remove(vizsg_alma);
                    a_elem.Remove(vizsg_alma);
                    return;
                }
            }
        }

        //Alma elhelyezése
        void Alma_elhelyezése()
        {
            Random rnd = new Random(); 
            while (true)
            {
                bool alma_ismétlődés = false;
                alma_x = rnd.Next(0, (int)(ablak_hossz / AlmaElem.Méret)) * AlmaElem.Méret;
                alma_y = rnd.Next(0, (int)(ablak_magasság / AlmaElem.Méret)) * AlmaElem.Méret;
                foreach (KígyóElem vizsg in k_elem)
                {
                    if (vizsg.Top == alma_y && vizsg.Left == alma_x)
                    {
                        alma_ismétlődés = true;
                        break;
                    }
                }
                if (alma_ismétlődés == false) { break; }
            }
            AlmaElem alma_ui = new AlmaElem();
            alma_ui.Top = alma_y;
            alma_ui.Left = alma_x;
            a_elem.Add(alma_ui);
            Controls.Add(alma_ui);
        }
        //Hossz megvizsgálása
        void Hossz_kígyó()
        {
            KígyóElem kitorlendo = k_elem[0];
            Controls.Remove(kitorlendo);
            k_elem.RemoveAt(0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Kígyó elhelyezése
            fej_poz_x += x_irány * KígyóElem.Méret;
            fej_poz_y += y_irány * KígyóElem.Méret;
            KígyóElem kígyó = new KígyóElem();
            kígyó.Top = fej_poz_y;
            kígyó.Left = fej_poz_x;

            //Megharapta-e magát?
            foreach (KígyóElem vizsg_kígyó in k_elem)
            {
                if (vizsg_kígyó.Top == kígyó.Top && vizsg_kígyó.Left == kígyó.Left)
                {
                    timer1.Enabled = false;
                    return;
                }
            }

            //Játéktér széle
            if (kígyó.Left < 0 || kígyó.Top < 0 || kígyó.Left > ablak_hossz || kígyó.Top > ablak_magasság)
            {
                timer1.Enabled = false;
                return;
            }

            //Almát evett-e a kígyó?
            Alma_evés(kígyó);

            if (a_elem.Count < elhelyezett_almák)
            {
                Alma_elhelyezése();
            }

            //Kígyó hossza
            if (KígyóElem.Hossz < k_elem.Count)
            {
                Hossz_kígyó();
            }


            k_elem.Add(kígyó);
            Controls.Add(kígyó);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && x_irány != 0 && y_irány != 1) { x_irány = 0; y_irány = -1; }
            if (e.KeyCode == Keys.Down && x_irány != 0 && y_irány != -1) { x_irány = 0; y_irány = 1; }
            if (e.KeyCode == Keys.Left && x_irány != 1 && y_irány != 0) { x_irány = -1; y_irány = 0; }
            if (e.KeyCode == Keys.Right && x_irány != -1 && y_irány != 0) { x_irány = 1; y_irány = 0; }
            if (e.KeyCode == Keys.Enter && timer1.Enabled == false) { Alaphelyzet(); }
        }
    }
}
