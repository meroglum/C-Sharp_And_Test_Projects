using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IKullanici
    {
        void Ekle(string kullaniciAd, string email, string sifre);
        void Guncelle(int kullaniciId, string kullaniciAd, string email, string sifre);
        void Sil(int kullaniciId);  // Delete
        KullaniciInfo Getir(int kullaniciId);   // Get
        List<KullaniciInfo> KullanicilariGetir();   // GetUsers
        void Aktif(int kullaniciId);
        void Pasif(int kullaniciId);
        bool Giris(string email, string sifre);
    }
}
