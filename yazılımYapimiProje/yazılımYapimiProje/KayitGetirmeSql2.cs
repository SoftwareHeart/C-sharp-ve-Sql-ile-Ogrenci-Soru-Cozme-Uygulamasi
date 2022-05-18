using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace yazılımYapimiProje
{
    internal class KayitGetirmeSql2
    {
        //Veri tabanı bağlama
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-IQ1GDIUE\\SQLEXPRESS;Initial Catalog=YazılımYapımı;Integrated Security=True");
        //List Oluşturma
        public List<AdminListeleme> AdminListe { get; set; }
        public KayitGetirmeSql2()
        {
            AdminListe = new List<AdminListeleme>();
            GetTablo();
        }
        private void GetTablo()
        {
            //Okuma ve DataGridViewe taşıma işlemi
            //Öğrencileri getirme kodları
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM KayitOgrTbl", baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                AdminListeleme db = new AdminListeleme();
                db.ID1 = dr[0].ToString();
                db.Ad1 = dr[1].ToString();
                db.Soyad1 = dr[2].ToString();
                db.KullaniciAd1 = dr[3].ToString();
                db.Sifre1= dr[4].ToString();
                db.Meslek1 = dr[5].ToString();
                AdminListe.Add(db);
            }
            dr.Close();
            baglanti.Close();

        }

    }
}
