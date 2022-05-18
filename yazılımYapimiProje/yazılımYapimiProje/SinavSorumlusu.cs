using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazılımYapimiProje
{
    public partial class SinavSorumlusu : Form
    {
        public SinavSorumlusu()
        {
            InitializeComponent();
        }

        private void ListeleButton_Click(object sender, EventArgs e)
        {
            KayitGetirmeSql2 kayitGetirme = new KayitGetirmeSql2();
            SinavSorumlusuData.DataSource = kayitGetirme.AdminListe;
        }

        private void SoruEklemeButton_Click(object sender, EventArgs e)
        {
            //Soru ekleme formunu getirme
            SoruEkleme soru = new SoruEkleme();
            soru.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Başarı ile çıkış yapılmıştır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Giriş kısmına dönüş
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
