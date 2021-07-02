using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace AplikasiKPL_7
{
    public partial class Form1 : Form
    {
        string nama = "Tomoko";
        string Kotaasal = "Japan";
        string status = "Pelajar";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); Menu mn = new Menu(); mn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Memanggil class db_pengguna
            var dataPengguna = new db_pengguna();
            dataPengguna.nama = inputNama.Text;
            dataPengguna.kota = inputKota.Text;
            dataPengguna.status = inputStatus.Text;

            //Memasukkan File JSON
            string ambilData = File.ReadAllText("D:KPL77/Yubes_KPL7/AplikasiKPL_7/AplikasiKPL_7/db_pengguna");

            List<db_pengguna> listJson = JsonConvert.DeserializeObject<List<db_pengguna>>(ambilData);
            listJson.Add(db_pengguna);

            var data = JsonConvert.SerializeObject(listJson, Formatting.Indented);
            //Menulis ke File JSON
            File.WriteAllText("D:KPL77/Yubes_KPL7/AplikasiKPL_7/AplikasiKPL_7/db_pengguna", data);

            MessageBox.Show("Berhasil");
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputStatus_TextChanged(object sender, EventArgs e)
        {

        }
    }
}