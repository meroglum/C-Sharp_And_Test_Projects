using ConsoleApp1;

// Lecture notes
class Program
{
    static void Main(string[] args)
    {
        // Statik sadece nesne üzerinden erişilebilen nesneler oluşturur.
        // Statik bir nesneye nesne örneği üzerinden erişilemez.

        //Kullanici k = new Kullanici();
        //k.Ad = "";
        //k.GetID();
        //Kullanici.ID = 1;

        var x = Encryption.Encrypt("asdada");
        var y = Encryption.Decrypt("adadadada");

        Console.WriteLine(x);
        Console.WriteLine(y); 

        //Encryption enc = new Encryption();
        //Encryption.Encrypt("adada");
    }
}