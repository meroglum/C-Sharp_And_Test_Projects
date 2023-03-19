internal class Program
{
    delegate int Hesap(int x, int y);
    private static void Main(string[] args)
    {
        // Topla(3,4);
        Hesap hesap = Topla;
        var x1 = hesap(3, 4);
        Console.WriteLine(x1);

        hesap = Carp;
        var x2 = hesap(2, 3);
        Console.WriteLine(x2);

        Console.WriteLine("-----------------------------");
        /// Diğer kullanım yöntemleri. Yukarıdaki ile aynı
        Hesap hesap1 = new Hesap(Cikar);
        var x3 = hesap1.Invoke(4,3);
        Console.WriteLine(x3);
    }

    static int Topla(int a, int b)
    {
        return a + b;
    }

    static int Cikar(int a, int b)
    {
        return a - b;
    }

    static int Carp(int a, int b)
    {
        return a * b;
    }

    static int Bol(int a, int b)
    {
        return a / b;
    }
}