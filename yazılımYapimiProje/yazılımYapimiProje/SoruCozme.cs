using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading;
using System.Timers;

namespace yazılımYapimiProje
{
    public partial class SoruCozme : Form
    {
        public SoruCozme()
        {
            InitializeComponent();
        }
        int dakika = 0, saniye = 0;
        //veri tabanına bağlantı
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-IQ1GDIUE\\SQLEXPRESS;Initial Catalog=YazılımYapımı;Integrated Security=True");
        private void timer1_Tick(object sender, EventArgs e)
        {
            dakika++;
            DakikaSureLbl.Text = Convert.ToString(dakika);
            if(dakika==10)
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("Süreniz bitmiştir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Ogrenci ogrenci = new Ogrenci();
                ogrenci.Show();
                this.Close();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            //saniye sayacımızın doğru çalışması ve 60 saniyede 1 sıfırlanması için gerekli kodlar
            if (saniye==60)
            {
                saniye = 0;
            }
            SaniyeLbl.Text = Convert.ToString(saniye);
            saniye++;
        }
        private void SoruCozme_Load(object sender, EventArgs e)
        {
            //timer1 dakikayı temsil ettiği için interval değerini 60000 yaptık;
            timer1.Interval = 60000;
            //timer2 dakikayı temsil ettiği için interval değerini 1000 yaptık;
            timer2.Interval = 1000;
            DakikaSureLbl.Text = "0";
            SaniyeLbl.Text = "0"; 
            

        }
        int soruno = 0;
        int i = 1;
        int j = 1;
        string CevapSoru;
        private void button1_Click(object sender, EventArgs e)
        {
            //timerları başlatalım
            timer1.Start();
            timer2.Start();
            //Cevap kısmı
            baglanti.Open();
            //Hep aynı sorunun gelmemesi için rastgele sayı üretiyoruz;
            Random rastgele = new Random();
            //Soru getirmek için gerekli sorgu ve kod
            SqlCommand komut = new SqlCommand("Select * From SoruTbl where SoruID=@ID", baglanti);
            //quiz için random sayı üretme;
            soruno = rastgele.Next(1, 55);
            i = soruno;



            komut.Parameters.AddWithValue("@ID", soruno);

            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {

                SoruNoLbl.Text = dr[0].ToString();
                richTextBox1.Text = dr[1].ToString();
                //foto çekme ve fotoları bytedan normal şekile dödürme
                Byte[] data = new Byte[0];
                data = (Byte[])(dr["resim"]);
                MemoryStream mem = new MemoryStream(data);
                pictureBox1.Image = Image.FromStream(mem);
                txtA.Text = dr[2].ToString();
                txtB.Text = dr[3].ToString();
                txtC.Text = dr[4].ToString();
                txtD.Text = dr[5].ToString();
                //Cevabı tutuyoruz.
                CevapSoru = dr[6].ToString();


            }

            dr.Close();

            temizle();


            //cevap gönderilmeden sonraki butonunun aktif olmaması için basılamaz hale getiriyoruz.
            button1.Enabled = false;

            baglanti.Close();
            


            if (j==11 )
            {
                //sınavımız on soruluk olduğu için jyi cevap fonksiyonu altında arttırıyoruz ve bitiyor.
              
                
                MessageBox.Show("Sınavınız bitmiştir.", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Ogrenci ogrenci = new Ogrenci();
                ogrenci.Show();
                this.Close();
            }
           
        }
        public void temizle()
        {
            //Bir sonraki soruda şıkın seçilmemiş olmasını sağlamak
            AradioBtn.Checked = false;
            Bradiobtn.Checked = false;
            CradioBtn.Checked = false;
            DradioBtn.Checked = false;
            
        }
        public void cevap()
        {
           
            //Cevapları tabloya eklemek için gerekli kodlar
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Update SoruTbl Set Cevap=@a1 where SoruID=@a2", baglanti);
            //Seçilen şık A ve sorunun cevabı da A ise öğrencinin soruyu doğru yaptığını tabloya ekle
            if (CevapSoru == "A" && AradioBtn.Checked==true)
            {


                cmd.Parameters.AddWithValue("@a2", i);
                cmd.Parameters.AddWithValue("@a1", "True");

            }
            //Seçilen şık B ve sorunun cevabı da B ise öğrencinin soruyu doğru yaptığını tabloya ekle
            else if (CevapSoru == "B" && Bradiobtn.Checked == true)
            {


                cmd.Parameters.AddWithValue("@a2", i);
                cmd.Parameters.AddWithValue("@a1", "True");

            }
            //Seçilen şık C ve sorunun cevabı da C ise öğrencinin soruyu doğru yaptığını tabloya ekle
            else if (CevapSoru == "C" && CradioBtn.Checked == true)
            {


                cmd.Parameters.AddWithValue("@a2", i);
                cmd.Parameters.AddWithValue("@a1", "True");

            }
            //Seçilen şık D ve sorunun cevabı da D ise öğrencinin soruyu doğru yaptığını tabloya ekle
            else if (CevapSoru == "D" && DradioBtn.Checked == true)
            {


                cmd.Parameters.AddWithValue("@a2", i);
                cmd.Parameters.AddWithValue("@a1", "True");

            }
            //doğru tercih verilmemiş ise tabloya ekle
            else
            {
                cmd.Parameters.AddWithValue("@a2", i);
                cmd.Parameters.AddWithValue("@a1", "False");

            }

            
            cmd.ExecuteNonQuery();
            baglanti.Close();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cevap();
         
            button1.Enabled = true;
            j++;
        }
    }
}
