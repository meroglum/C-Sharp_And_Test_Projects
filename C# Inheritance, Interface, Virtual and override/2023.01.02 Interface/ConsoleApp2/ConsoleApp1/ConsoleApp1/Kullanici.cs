using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Interface sample.
    internal class Kullanici : Program, IKullanici, IYetki, IDisposable
    {
        public int YetkiId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int KullaniciId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Aktif(int kullaniciId)
        {
            throw new NotImplementedException();
        }

        public void Ata(int kullaniciId, int yetkiId)
        {
            throw new NotImplementedException();
        }

        public void Ekle(string kullaniciAd, string email, string sifre)
        {
            throw new NotImplementedException();
        }

        public KullaniciInfo Getir(int kullaniciId)
        {
            KullaniciInfo info = new KullaniciInfo();
            info.ID = 10;
            info.Ad = "CO";
            info.Soyad = "XX";
            return info;
        }

        public List<KullaniciInfo> KullanicilariGetir()
        {
            List<KullaniciInfo> data = new List<KullaniciInfo>();
            data.Add(new KullaniciInfo() { ID = 12, Ad = "Murtaza", Soyad = "Can" });
            data.Add(new KullaniciInfo() { ID = 14, Ad = "Cabbar", Soyad = "Can" });
            return data;
        }

        public bool Giris(string email, string sifre)
        {
            throw new NotImplementedException();
        }

        public void Guncelle(int kullaniciId, string kullaniciAd, string email, string sifre)
        {
            throw new NotImplementedException();
        }

        public void Kaldir(int kullaniciId, int yetkiId)
        {
            throw new NotImplementedException();
        }

        public void Pasif(int kullaniciId)
        {
            throw new NotImplementedException();
        }

        public void Sil(int kullaniciId)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this); ///Manually enable the dispose method for the class object
        }
    }
}
