using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HajosVizsgakerdesek
{
    public partial class SorRogzites : Form
    {
        public Kviz kviz = new();
        public SorRogzites()
        {
            InitializeComponent();            
        }

        private void SorRogzites_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = kviz;
        }
    }
}
