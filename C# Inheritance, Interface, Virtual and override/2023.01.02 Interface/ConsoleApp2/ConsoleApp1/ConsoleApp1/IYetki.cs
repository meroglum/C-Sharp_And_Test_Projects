namespace ConsoleApp1
{
    interface IYetki
    {
        int YetkiId { get; set; }
        int KullaniciId { get; set; }
        void Ata(int kullaniciId, int yetkiId);
        void Kaldir(int kullaniciId, int yetkiId);
    }
}
