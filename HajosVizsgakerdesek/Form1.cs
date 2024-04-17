using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace HajosVizsgakerdesek
{
    public partial class Form1 : Form
    {
        BindingList<Kviz> kvízek = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kvizBindingSource.DataSource = kvízek;
            dataGridView1.DataSource = kvizBindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("hajozasi_szabalyzat_coma.txt");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var tomb = csv.GetRecords<Kviz>();
                foreach (Kviz v in tomb)
                {
                    kvízek.Add(v);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();

            if (sf.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sf.FileName);
                var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                csv.WriteRecords(kvízek);
                sw.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (kvizBindingSource.Current == null) { return; }

            if (MessageBox.Show("Biztos törölni szeretné ezt a sort?", "tõrés", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                kvizBindingSource.RemoveCurrent();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SorRogzites sr = new SorRogzites();

            if (sr.ShowDialog() == DialogResult.OK) { kvízek.Add(sr.kviz); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{kvízek.Count}");
            
            Kviz max_sor = new Kviz();
            int max = -12421354;
            foreach (var item in kvízek)
            {
                if (item.Szam > max) { max_sor = item; }
            }
            MessageBox.Show($"{max_sor.Szam}");
        }
    }
}
