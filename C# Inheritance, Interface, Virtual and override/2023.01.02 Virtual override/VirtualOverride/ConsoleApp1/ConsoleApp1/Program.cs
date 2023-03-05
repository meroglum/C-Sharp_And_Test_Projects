// Virtual/Override
using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        //
        //Muhendis m = new Muhendis();
        //m.Ad = "Murtaza";
        //m.Soyad = "Canberk";
        //m.Unvan = "Johnberk";
        //m.Departman = "Çocuk Bakıcısı, PHP'ci";
        //Console.WriteLine(m.MaasHesapla());

        //
        Muhendis m = new Muhendis();
        m.Ad = "Murtaza";
        m.Soyad = "Canberk";
        m.Unvan = "Johnberk";
        m.Departman = "Çocuk Bakıcısı, PHP'ci";
        Console.WriteLine(m.MaasHesapla());

        // 
        Calisan c = new Calisan();
        c.Ad = "Murtaza";
        c.Soyad = "Canberk";
        c.Unvan = "Johnberk";
        //c.Departman = "Çocuk Bakıcısı, PHP'ci";
        Console.WriteLine(c.MaasHesapla());
    }
}