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
    public partial class Sonuclar : Form
    {
        public Sonuclar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-IQ1GDIUE\\SQLEXPRESS;Initial Catalog=YazılımYapımı;Integrated Security=True");
        private void Sonuclar_Load(object sender, EventArgs e)
        {
            //ToplamSoruSayisi
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select Count(*) From SoruTbl", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                ToplmaLbl.Text = dr1[0].ToString();

            }
            baglanti.Close();
            //Çözülen soru sayisi
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select Count(*) from SoruTbl where (Cevap='True' or Cevap='False') ", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CzlnTbl.Text = dr2[0].ToString();
            }
            baglanti.Close();
            //Doğru Çözülen soru sayisi
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select Count(*) from SoruTbl where Cevap='True' ", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                DogruSoruTbl.Text = dr3[0].ToString();
            }
            baglanti.Close();
            //Yanlış Çözülen soru sayisi
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select Count(*) from SoruTbl where Cevap='False' ", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                YanlisSoruTbl.Text = dr4[0].ToString();
            }
            baglanti.Close();





            //Mevsimler ve iklim toplam soru sayisi
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select Count(*) from SoruTbl where SoruAlani='MEVSİMLER VE İKLİM' ", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                MevsimTplmLbl.Text = dr5[0].ToString();
            }
            baglanti.Close();
            //Mevsimler ve iklim çözülen toplam soru sayisi
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select Count(*) from SoruTbl where SoruAlani='MEVSİMLER VE İKLİM' and (Cevap='True' or Cevap='False')", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                MevsimCzlnLbl.Text = dr6[0].ToString();
            }
            baglanti.Close();
            //Mevsimler ve iklim doğru çözülen toplam soru sayisi
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("Select Count(*) from SoruTbl where SoruAlani='MEVSİMLER VE İKLİM' and Cevap='True' ", baglanti);
            SqlDataReader dr7 = komut7.ExecuteReader();
            while (dr7.Read())
            {
                MevsimDogruLbl.Text = dr7[0].ToString();
            }
            baglanti.Close();
            //Mevsimler ve iklim yanlış çözülen toplam soru sayisi
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("Select Count(*) from SoruTbl where SoruAlani='MEVSİMLER VE İKLİM' and Cevap='False' ", baglanti);
            SqlDataReader dr8 = komut8.ExecuteReader();
            while (dr8.Read())
            {
                MevsimYanlısLbl.Text = dr8[0].ToString();
            }
            baglanti.Close();



            //DNA VE GENETİK KOD toplam soru sayisi
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("Select Count(*) from SoruTbl where SoruAlani='DNA VE GENETİK KOD' ", baglanti);
            SqlDataReader dr9 = komut9.ExecuteReader();
            while (dr9.Read())
            {
               DnaTplLbl.Text = dr9[0].ToString();
            }
            baglanti.Close();
            //DNA VE GENETİK KOD çözülen toplam soru sayisi
            baglanti.Open();
            SqlCommand komut10 = new SqlCommand("Select Count(*) from SoruTbl where SoruAlani='DNA VE GENETİK KOD' and (Cevap = 'True' or Cevap='False')", baglanti);
            SqlDataReader dr10 = komut10.ExecuteReader();
            while (dr10.Read())
            {
                DnaCzlnLbl.Text = dr10[0].ToString();
            }
            baglanti.Close();
            //DNA VE GENETİK KOD doğru çözülen toplam soru sayisi
            baglanti.Open();
            SqlCommand komut11 = new SqlCommand("Select Count(*) from SoruTbl where SoruAlani='DNA VE GENETİK KOD' and Cevap='True' ", baglanti);
            SqlDataReader dr11 = komut11.ExecuteReader();
            while (dr11.Read())
            {
               DnaDogruLbl.Text = dr11[0].ToString();
            }
            baglanti.Close();
            //DNA VE GENETİK KOD yanlış çözülen toplam soru sayisi
            baglanti.Open();
            SqlCommand komut12 = new SqlCommand("Select Count(*) from SoruTbl where SoruAlani= 'DNA VE GENETİK KOD' and Cevap='False' ", baglanti);
            SqlDataReader dr12 = komut12.ExecuteReader();
            while (dr12.Read())
            {
                DnaYanlisLbl.Text = dr12[0].ToString();
            }
            baglanti.Close();



            //BASINÇ Konusu toplam soru sayısı
            baglanti.Open();
            SqlCommand komut13 = new SqlCommand("Select Count(*) from SoruTbl where SoruAlani='BASINÇ' ", baglanti);
            SqlDataReader dr13 = komut13.ExecuteReader();
            while (dr13.Read())
            {
                BasTplLbl.Text = dr13[0].ToString();
            }
            baglanti.Close();
            //BASINÇ KOD çözülen toplam soru sayisi
            baglanti.Open();
            SqlCommand komut14 = new SqlCommand("Select Count(*) from SoruTbl where SoruAlani= 'BASINÇ' and (Cevap='True' or Cevap='False')", baglanti);
            SqlDataReader dr14 = komut14.ExecuteReader();
            while (dr14.Read())
            {
                BasCzlnLbl.Text = dr14[0].ToString();
            }
            baglanti.Close();
            //BASINÇ doğru çözülen toplam soru sayisi
            baglanti.Open();
            SqlCommand komut15 = new SqlCommand("Select Count(*) from SoruTbl where SoruAlani='BASINÇ' and Cevap='True' ", baglanti);
            SqlDataReader dr15 = komut15.ExecuteReader();
            while (dr15.Read())
            {
                BasDogruLbl.Text = dr15[0].ToString();
            }
            baglanti.Close();
            //BASINÇ yanlış çözülen toplam soru sayisi
            baglanti.Open();
            SqlCommand komut16 = new SqlCommand("Select Count(*) from SoruTbl where SoruAlani='BASINÇ' and Cevap='False' ", baglanti);
            SqlDataReader dr16 = komut16.ExecuteReader();
            while (dr16.Read())
            {
                BasYanlısLbl.Text = dr16[0].ToString();
            }
            baglanti.Close();



            //MADDE VE ENDÜSTRİ Konusu toplam soru sayısı
            baglanti.Open();
            SqlCommand komut17 = new SqlCommand("Select Count(*) from SoruTbl where SoruAlani='MADDE VE ENDÜSTRİ' ", baglanti);
            SqlDataReader dr17 = komut17.ExecuteReader();
            while (dr17.Read())
            {
                maddetplLbl.Text = dr17[0].ToString();
            }
            baglanti.Close();
            //MADDE VE ENDÜSTRİ  çözülen toplam soru sayisi
            baglanti.Open();
            SqlCommand komut18 = new SqlCommand("Select Count(*) from SoruTbl where SoruAlani= 'MADDE VE ENDÜSTRİ' and (Cevap='True' or Cevap='False')", baglanti);
            SqlDataReader dr18 = komut18.ExecuteReader();
            while (dr18.Read())
            {
              MaddeCzlnLbl.Text = dr18[0].ToString();
            }
            baglanti.Close();
            //MADDE VE ENDÜSTRİ doğru çözülen toplam soru sayisi
            baglanti.Open();
            SqlCommand komut19 = new SqlCommand("Select Count(*) from SoruTbl where SoruAlani='MADDE VE ENDÜSTRİ' and Cevap='True' ", baglanti);
            SqlDataReader dr19 = komut19.ExecuteReader();
            while (dr19.Read())
            {
                MaddeDgruLbl.Text = dr19[0].ToString();
            }
            baglanti.Close();
            //MADDE VE ENDÜSTRİ yanlış çözülen toplam soru sayisi
            baglanti.Open();
            SqlCommand komut20 = new SqlCommand("Select Count(*) from SoruTbl where SoruAlani='MADDE VE ENDÜSTRİ' and Cevap='False' ", baglanti);
            SqlDataReader dr20 = komut20.ExecuteReader();
            while (dr20.Read())
            {
               MaddeYnlsLbl.Text = dr20[0].ToString();
            }
            baglanti.Close();



            //BASİT MAKİNELER Konusu toplam soru sayısı
            baglanti.Open();
            SqlCommand komut21 = new SqlCommand("Select Count(*) from SoruTbl where SoruAlani='BASİT MAKİNELER' ", baglanti);
            SqlDataReader dr21 = komut21.ExecuteReader();
            while (dr21.Read())
            {
                BasitTplLbl.Text = dr21[0].ToString();
            }
            baglanti.Close();
            //BASİT MAKİNELER  çözülen toplam soru sayisi
            baglanti.Open();
            SqlCommand komut22 = new SqlCommand("Select Count(*) from SoruTbl where SoruAlani= 'BASİT MAKİNELER' and (Cevap='True' or Cevap='False')", baglanti);
            SqlDataReader dr22 = komut22.ExecuteReader();
            while (dr22.Read())
            {
                BasitCzlnLbl.Text = dr22[0].ToString();
            }
            baglanti.Close();
            //BASİT MAKİNELER doğru çözülen toplam soru sayisi
            baglanti.Open();
            SqlCommand komut23 = new SqlCommand("Select Count(*) from SoruTbl where SoruAlani='BASİT MAKİNELER' and Cevap='True' ", baglanti);
            SqlDataReader dr23 = komut23.ExecuteReader();
            while (dr23.Read())
            {
                BasitDgrLbl.Text = dr23[0].ToString();
            }
            baglanti.Close();
            //BASİT MAKİNELER yanlış çözülen toplam soru sayisi
            baglanti.Open();
            SqlCommand komut24 = new SqlCommand("Select Count(*) from SoruTbl where SoruAlani='BASİT MAKİNELER' and Cevap='False' ", baglanti);
            SqlDataReader dr24 = komut24.ExecuteReader();
            while (dr24.Read())
            {
                BasitYnlsLbl.Text = dr24[0].ToString();
            }
            baglanti.Close();



            //ENERJİ DÖNÜŞÜMLERİ VE ÇEVRE BİLİMİ Konusu toplam soru sayısı
            baglanti.Open();
            SqlCommand komut25 = new SqlCommand("Select Count(*) from SoruTbl where SoruAlani='ENERJİ DÖNÜŞÜMLERİ VE ÇEVRE BİLİMİ' ", baglanti);
            SqlDataReader dr25 = komut25.ExecuteReader();
            while (dr25.Read())
            {
                EnerjiTplmLbl.Text = dr25[0].ToString();
            }
            baglanti.Close();
            //ENERJİ DÖNÜŞÜMLERİ VE ÇEVRE BİLİMİ  çözülen toplam soru sayisi
            baglanti.Open();
            SqlCommand komut26 = new SqlCommand("Select Count(*) from SoruTbl where SoruAlani= 'ENERJİ DÖNÜŞÜMLERİ VE ÇEVRE BİLİMİ' and (Cevap='True' or Cevap='False')", baglanti);
            SqlDataReader dr26 = komut26.ExecuteReader();
            while (dr26.Read())
            {
                EnerjiClznLbl.Text = dr26[0].ToString();
            }
            baglanti.Close();
            //ENERJİ DÖNÜŞÜMLERİ VE ÇEVRE BİLİMİ doğru çözülen toplam soru sayisi
            baglanti.Open();
            SqlCommand komut27 = new SqlCommand("Select Count(*) from SoruTbl where SoruAlani='ENERJİ DÖNÜŞÜMLERİ VE ÇEVRE BİLİMİ' and Cevap='True' ", baglanti);
            SqlDataReader dr27 = komut27.ExecuteReader();
            while (dr27.Read())
            {
                EnerjiDgrLbl.Text = dr27[0].ToString();
            }
            baglanti.Close();
            //ENERJİ DÖNÜŞÜMLERİ VE ÇEVRE BİLİMİ yanlış çözülen toplam soru sayisi
            baglanti.Open();
            SqlCommand komut28 = new SqlCommand("Select Count(*) from SoruTbl where SoruAlani='ENERJİ DÖNÜŞÜMLERİ VE ÇEVRE BİLİMİ' and Cevap='False' ", baglanti);
            SqlDataReader dr28 = komut28.ExecuteReader();
            while (dr28.Read())
            {
                EnerjiYnlLbl.Text = dr28[0].ToString();
            }
            baglanti.Close();
            
            TplSoruBasari.Text=Convert.ToString(Hesapla(DogruSoruTbl.Text, YanlisSoruTbl.Text));
            MevsimBasari.Text = Convert.ToString(Hesapla(MevsimDogruLbl.Text, MevsimYanlısLbl.Text));
            DnaBasari.Text = Convert.ToString(Hesapla(DnaDogruLbl.Text, DnaYanlisLbl.Text));
            BasincBasari.Text = Convert.ToString(Hesapla(BasDogruLbl.Text, BasYanlısLbl.Text));
            MaddeBasari.Text = Convert.ToString(Hesapla(MaddeDgruLbl.Text, MaddeYnlsLbl.Text));
            BasitBasari.Text = Convert.ToString(Hesapla(BasitDgrLbl.Text, BasitYnlsLbl.Text));
            EnerjiBasari.Text = Convert.ToString(Hesapla(EnerjiDgrLbl.Text, EnerjiYnlLbl.Text));



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Show();
            this.Close();
        }
        public double Hesapla(string A,string B)
        { 
        //basari oranı hesaplama
            double sayi1;
            double sayi2;
            //labellarda yazan degerleri int değerlere döndürüyoruz
            sayi1 = Convert.ToInt32(A);
            sayi2 = Convert.ToInt32(B);
            if (sayi2==0)
            {
                return 0;
            }
            else
            {
            return (sayi1/(sayi1+sayi2)) * 100;
            }
            
        }

    }
}
