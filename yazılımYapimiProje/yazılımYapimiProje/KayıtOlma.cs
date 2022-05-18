using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace yazılımYapimiProje
{
    public partial class KayıtOlma : Form
    {

        public KayıtOlma()
        {
            InitializeComponent();
        }
        //Veri Tanına bağlanmak
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-IQ1GDIUE\\SQLEXPRESS;Initial Catalog=YazılımYapımı;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
            //Giriş Kısmına Dönüş
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //KayıtOlma 
            if (ComboMeslekTuru.SelectedIndex == 0)
            {
                //Öğrenci kayıt
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into KayitOgrTbl(Ad,Soyad,Meslek,KullaniciAd,Sifre) values (@k1,@k2,@k3,@k4,@k5)", baglanti);
                komut.Parameters.AddWithValue("@k1", KayitAdText.Text);
                komut.Parameters.AddWithValue("@k2", KayitSoyadText.Text);
                komut.Parameters.AddWithValue("@k3", ComboMeslekTuru.SelectedItem);
                komut.Parameters.AddWithValue("@k4", KayitKullaniciAdiText.Text);
                komut.Parameters.AddWithValue("@k5", KayitSifre.Text);


                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kaydınız başarıyla gerçekleşmiştir.");
                //Giriş formuna geri dönme işlemi
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else if (ComboMeslekTuru.SelectedIndex == 1)
            {
                //Sınav Sorumlusu Kayıt
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into KayitSinavTbl(Ad,Soyad,Meslek,KullaniciAd,Sifre) values (@k1,@k2,@k3,@k4,@k5)", baglanti);
                komut.Parameters.AddWithValue("@k1", KayitAdText.Text);
                komut.Parameters.AddWithValue("@k2", KayitSoyadText.Text);
                komut.Parameters.AddWithValue("@k3", ComboMeslekTuru.SelectedItem);
                komut.Parameters.AddWithValue("@k4", KayitKullaniciAdiText.Text);
                komut.Parameters.AddWithValue("@k5", KayitSifre.Text);


                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kaydınız başarıyla gerçekleşmiştir.");
                //Giriş formuna geri dönme işlemi
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else if (ComboMeslekTuru.SelectedIndex == 2)
            {
                //Admin kayıt alanı
                baglanti.Open();
                
                SqlCommand komut = new SqlCommand("insert into KayitAdminTbl(Ad,Soyad,Meslek,KullaniciAd,Sifre) values (@k1,@k2,@k3,@k4,@k5)", baglanti);
                komut.Parameters.AddWithValue("@k1", KayitAdText.Text);
                komut.Parameters.AddWithValue("@k2", KayitSoyadText.Text);
                komut.Parameters.AddWithValue("@k3", ComboMeslekTuru.SelectedItem);
                komut.Parameters.AddWithValue("@k4", KayitKullaniciAdiText.Text);
                komut.Parameters.AddWithValue("@k5", KayitSifre.Text);


                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kaydınız başarıyla gerçekleşmiştir.");
                //Giriş formuna geri dönme işlemi
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Meslek türü boş bırakılamaz!!", "Uyarı!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}