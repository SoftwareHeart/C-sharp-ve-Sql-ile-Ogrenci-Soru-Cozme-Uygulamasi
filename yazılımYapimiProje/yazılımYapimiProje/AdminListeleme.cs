using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazılımYapimiProje
{
    public class AdminListeleme
    {
        //liste yapısında verileri getirmek için tablonun sütünları ile aynı adda değişkenler kullanıyoruz.
        string ID;
        string Ad;
        string Soyad;
        string KullaniciAd;
        string Sifre;
        string Meslek;

        public string ID1 { get => ID; set => ID = value; }
        public string Ad1 { get => Ad; set => Ad = value; }
        public string Soyad1 { get => Soyad; set => Soyad = value; }
        public string KullaniciAd1 { get => KullaniciAd; set => KullaniciAd = value; }
        public string Sifre1 { get => Sifre; set => Sifre = value; }
        public string Meslek1 { get => Meslek; set => Meslek = value; }
    }
}
