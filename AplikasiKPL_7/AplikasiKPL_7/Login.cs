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
        static Class1.Username id = Class1.Username.dzaky;
        public string username = id.ToString();
        public string password = Class1.getPassword(id);

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username, Password;
            Username = textBox1.Text;
            Password = textBox2.Text;

            if (textBox1.Text == username.ToString() && textBox2.Text == password.ToString())
            {
                MessageBox.Show("Kamu berhasil login");
                this.Hide(); Menu mn = new Menu(); mn.Show();
            }
            else if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Kamu belum mengisi data login");
            }
            else

            {
                MessageBox.Show("Gagal login");
                this.Hide(); Login lg = new Login(); lg.Show();
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

