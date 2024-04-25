using SQL_Szerver_csatlakozas.Models;

namespace SQL_Szerver_csatlakozas
{
    public partial class Form1 : Form
    {
        Models.StudentContext context = new Models.StudentContext();

        public Form1()
        {
            InitializeComponent();
            studentBindingSource.DataSource = context.Students.ToList();
            dataGridView1.DataSource = studentBindingSource.DataSource;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            listBox1.DataSource = (from x in context.Students select x.Neptun).ToList();
            listBox1.DoubleClick += ListBox1_DoubleClick;
        }

        private void ListBox1_DoubleClick(object? sender, EventArgs e)
        {
            var jelenlegi = listBox1.SelectedItem as string;
            var eredmény = from x in context.Students
                           where x.Neptun == $"{jelenlegi}"
                           select x;

            studentBindingSource.DataSource = eredmény.ToList();
            dataGridView1.DataSource = studentBindingSource.DataSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var eredmény = from x in context.Students
                           where x.Name.StartsWith(textBox1.Text)
                           select x;

            studentBindingSource.DataSource = eredmény.ToList();
            dataGridView1.DataSource = studentBindingSource.DataSource;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}