internal class Program
{
    private static void Main(string[] args)
    {
        // Action

        // Geriye değer döndürmeyen methodlar için kullanılır
        // Delegate'in geriye dönmeyen versiyonudur

        Action<int, string> action = new Action<int, string>(KullaniciBilgi);
        action(10, "Muhammed EROĞLU");

        // Func
        // Geriye değer dönebilen bir delegate versiyonudur.

        // Datetime function param. double return value
        Func<DateTime, double> func = new Func<DateTime, double>(GetUserAgeAtTime);
        var bDate = new DateTime(1996,04,01);
        double dateDiff = func(bDate);
        Console.WriteLine(dateDiff + " gündür yaşıyor bu hayatta");

    }

    static void KullaniciBilgi(int kullaniciID, string adSoyad)
    {
        Console.WriteLine("Kullanıcı ID: " + kullaniciID);
        Console.WriteLine("Ad Soyad : " + adSoyad);
    }

    static double GetUserAgeAtTime(DateTime birthDate)
    {
        return (DateTime.Now-birthDate).TotalDays;
    }
}