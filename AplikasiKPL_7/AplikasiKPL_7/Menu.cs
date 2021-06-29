using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiKPL_7
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); TambahJadwal tj = new TambahJadwal(); tj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); History ht = new History(); ht.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide(); Login lg = new Login(); lg.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide(); Form1 bg = new Form1(); bg.Show();
        }
    }
}
