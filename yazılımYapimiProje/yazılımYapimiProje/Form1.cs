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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-IQ1GDIUE\\SQLEXPRESS;Initial Catalog=YazılımYapımı;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
            //Kayıt Kısmını Getiren Kodlar
            KayıtOlma kayıt = new KayıtOlma();
            kayıt.Show();
            this.Hide();
        }

        private void GirisButton_Click(object sender, EventArgs e)
        {
            if (comboGirisTuru.SelectedIndex==0)
            {
               
                baglanti.Open();
                //Adminin doğru girip girmediğini kontrol eden komutlar
                SqlCommand komut = new SqlCommand("Select * From KayitAdminTbl where KullaniciAd=@p1 and Sifre=@p2", baglanti);
                komut.Parameters.AddWithValue("@p1", KullaniciAdiText.Text);
                komut.Parameters.AddWithValue("@p2", SifreText.Text);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    //Admin İle ilgili form 
                    Admin ad = new Admin();
                    ad.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş Yaptınız..", "Uyarı!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                baglanti.Close();




            }


            else if (comboGirisTuru.SelectedIndex == 1)
            {
                //Sınav Sorumlusu İle ilgili form .
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From KayitSinavTbl where KullaniciAd=@p1 and Sifre=@p2", baglanti);
                komut.Parameters.AddWithValue("@p1", KullaniciAdiText.Text);
                komut.Parameters.AddWithValue("@p2", SifreText.Text);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    //Sınav Sorumlusu İle ilgili form 
                    SinavSorumlusu sinav = new SinavSorumlusu();
                    sinav.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş Yaptınız..","Uyarı!!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                baglanti.Close();

            }


            else if (comboGirisTuru.SelectedIndex == 2)
            {
                
                baglanti.Open();
                //Öğrencinin doğru girip girmediğini kontrol eden komutlar
                SqlCommand komut = new SqlCommand("Select * From KayitOgrTbl where KullaniciAd=@p1 and Sifre=@p2", baglanti);
                komut.Parameters.AddWithValue("@p1", KullaniciAdiText.Text);
                komut.Parameters.AddWithValue("@p2", SifreText.Text);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    //Öğrenci İle ilgili form 
                    Ogrenci ogrenci = new Ogrenci();
                    ogrenci.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş Yaptınız..", "Uyarı!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                baglanti.Close();
            }


            else
            {
                MessageBox.Show("Tüm alanları doldurduğunuza emin olun!!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void cikisbtn_Click(object sender, EventArgs e)
        {
            //programdan çıkma
            this.Close();
        }
    }
}
