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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-IQ1GDIUE\\SQLEXPRESS;Initial Catalog=YazılımYapımı;Integrated Security=True");
        private void AdminSınavSorumlusuGetir_Click(object sender, EventArgs e)
        {
            //Sınav sorumlusu getirme
            KayitGetirmeSql kayitGetirme = new KayitGetirmeSql();
            dataGridView1.DataSource = kayitGetirme.AdminListe;
        }

        private void AdminOgrenciGetir_Click(object sender, EventArgs e)
        {
            //Öğrenci Getirme
            KayitGetirmeSql2 kayitGetirme = new KayitGetirmeSql2();
            dataGridView1.DataSource = kayitGetirme.AdminListe;
        }

        private void SilButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            // Sınav sorumluları tablosundan veri silme
            SqlCommand komutsil = new SqlCommand("Delete From KayitSinavTbl Where ID=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1", TxtId.Text);
            komutsil.ExecuteNonQuery();
            //Ayrı ayrı formlar oluşturlacak,,

            
            //Öğrenci tablosundan veri silme
            SqlCommand komutsil1 = new SqlCommand("Delete From KayitOgrTbl Where ID=@k1", baglanti);
            komutsil1.Parameters.AddWithValue("@k1", TxtId.Text);
            komutsil1.ExecuteNonQuery();


            baglanti.Close();
            MessageBox.Show("Kayit silindi");
            MessageBox.Show("Kayit silindi");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Admin çıkış işlemi
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
            MessageBox.Show("Başarı ile çıkış yaptınız", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
