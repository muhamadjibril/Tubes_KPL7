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
    public partial class Login : Form
    {
        string Username = "dole";
        string Password = "1234";
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Username && textBox1.Text == Password)
            {
                MessageBox.Show("Kamu berhasil login");
            }
            else if (textBox2.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Kamu belum mengisi form login");
            }
            else
            {
                MessageBox.Show("Berhasil Login ");
            }
           
            {
                this.Hide(); Menu mn = new Menu(); mn.Show();
            }
        }
    

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

