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
    public partial class Form2 : Form
    {
        static Class2.Kegiatan id = Class2.Kegiatan.Game;
        public string Kegiatan = id.ToString();
        public string Olahraga = Class2.getOlahraga(id);
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            string Kegiatan, Olahraga;
            Kegiatan = textBox1.Text;
            Olahraga = textBox2.Text;

            if (textBox1.Text == Kegiatan.ToString() && textBox2.Text == Olahraga.ToString())
            {
                MessageBox.Show("berhasil di simpan");
                this.Hide(); History hs = new History(); hs.Show();
            }
            else if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("belum mengisi data");
            }
            else

            {
                MessageBox.Show("Gagal menyimpan");
                this.Hide(); Form2 ji = new Form2(); ji.Show();
            }
        }
    }
}
