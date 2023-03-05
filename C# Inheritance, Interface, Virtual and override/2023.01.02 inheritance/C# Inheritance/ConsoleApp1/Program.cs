using ConsoleApp1;

/// <summary>
// LECTURE NOTES.
/// </summary>
class Program
{
    // Inheritance

    static void Main(string[] args)
    {

      IkiBoyut iki = new IkiBoyut();
      iki.Genislik = 100;
      iki.Yukseklik = 20;
      iki.Goster();

        Console.WriteLine("*******************");
        Ucgen uc = new Ucgen();
        //uc.Genislik = 100;
        //uc.Yukseklik = 20;
        uc.Stil = "Üçgen";
        uc.Goster();
        Console.WriteLine(uc.AlanHesapla());
    }
}

class A // Base Class
{
    public int ProbA { get; set; }
}

class B : A // Derived/Türemiş Class
{
    public int ProbB { get; set; }
}

class C : B
{
    public int ProbC { get; set; }
    public void IncreaseProbs()
    {
        ProbA++;
        ProbB++;
        ProbC++;
    }
}