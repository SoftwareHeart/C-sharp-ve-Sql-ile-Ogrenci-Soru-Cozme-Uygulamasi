using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace yazılımYapimiProje
{
    public partial class Ogrenci : Form
    {
        public Ogrenci()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-IQ1GDIUE\\SQLEXPRESS;Initial Catalog=YazılımYapımı;Integrated Security=True");

        private void SoruCozButton_Click(object sender, EventArgs e)
        {
            //Soru Çözme ile ilgili alanlar
            SoruCozme soru = new SoruCozme();
            soru.Show();
            this.Hide();

        }

        private void RaporButton_Click(object sender, EventArgs e)
        {
            //Rapor ile ilgili alanlar

        }

        private void AyarlarButton_Click(object sender, EventArgs e)
        {
            //ayarlar ile ilgili form
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Başarı ile çıkış yapılmıştır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Giriş kısmına dönüş
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Sonuç_Click(object sender, EventArgs e)
        {
            Sonuclar sonuclar = new Sonuclar();
            sonuclar.Show();
            this.Hide();
        }
    }
}
