using System;
using System.IO;
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
    public partial class SoruEkleme : Form
    {
        public SoruEkleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-IQ1GDIUE\\SQLEXPRESS;Initial Catalog=YazılımYapımı;Integrated Security=True");
        private void SoruEklemeButton_Click(object sender, EventArgs e)
        {
            //tüm alanların dolu olup olmadığını kontrol eder..
            if (ATextbox.Text == "" || Btextbox.Text == "" || Ctextbox.Text == "" || Dtextbox.Text == "" || DogruTextbox.Text == "" || Sorurich.Text=="" || comboBox1.SelectedItem==null || pictureBox1.Image==null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurduğunuza emin olunuz.", "Uyarı !" ,MessageBoxButtons.OK ,MessageBoxIcon.Warning );
                
            }
            else
            {
                //Doğru şık kısmının kontrolüne bakar.
                if (DogruTextbox.Text == "A" || DogruTextbox.Text == "B" || DogruTextbox.Text == "C" || DogruTextbox.Text == "D")
                {

                    //soru ekleme kısmı ile ilgili kodlar
                    //bağlantı açma
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("Insert Into SoruTbl(Soru,A,B,C,D,DogruCevap,Resim,SoruAlani) Values (@Soru,@A,@B,@C,@D,@DogruCevap,@Resim,@SoruAlani)", baglanti);
                    komut.Parameters.AddWithValue("@Soru", Sorurich.Text);
                    komut.Parameters.AddWithValue("@A", ATextbox.Text);
                    komut.Parameters.AddWithValue("@B", Btextbox.Text);
                    komut.Parameters.AddWithValue("@C", Ctextbox.Text);
                    komut.Parameters.AddWithValue("@D", Dtextbox.Text);
                    komut.Parameters.AddWithValue("@DogruCevap", DogruTextbox.Text);
                    //Resim için gerekli kodlar
                    //https://bilgisayardershanesi.com/Y4510-picturebox-kullanimi---veritabanina-resim-eklemek.html
                    Image img = Image.FromFile(openFileDialog1.FileName);
                        //Resimleri byte dönüştürme işlemi
                        MemoryStream ms = new MemoryStream();

                        img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                        komut.Parameters.AddWithValue("@resim", ms.ToArray());
                    
                    
                    komut.Parameters.AddWithValue("@SoruAlani", comboBox1.SelectedItem);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Sorunuz başarı ile eklenmiştir", "Harika!!", MessageBoxButtons.OK, MessageBoxIcon.Information); 



                }
                else
                {
                    MessageBox.Show("Doğru şıkkı doğru yazdığınıza lütfen emin olunuz");
                }
            }
            
            
           
        }

        private void ResimEklemeButton_Click(object sender, EventArgs e)
        {
            //Sorumuza resim ekleme kodları..
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void TemizleButton_Click(object sender, EventArgs e)
        {
            //Soru ekleme kısmındaki kısımları temizlemek için yapılan kodlar
            Sorurich.Text = "";
            pictureBox1.Image = null;
            ATextbox.Text = "";
            Btextbox.Text = "";
            Ctextbox.Text = "";
            Dtextbox.Text = "";
            DogruTextbox.Text = "";
            comboBox1.SelectedItem = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Sınav sorumlusunun ana ekrana geçmesi için gerekli kod.
            SinavSorumlusu sinav = new SinavSorumlusu();
            sinav.Show();
            this.Hide();
        }

        
    }
}
