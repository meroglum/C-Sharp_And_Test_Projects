using _2023._01._09;

//Lecture notes.
internal class Program
{
    private static void Main(string[] args)
    {
        Isci isci = new Isci();
        isci.Ad = "A";
        isci.Soyad = "a";
        Console.WriteLine(isci.GetFullName());

        Muhendis muhendis = new Muhendis();
        muhendis.Ad = "Roketatar";
        muhendis.Soyad = "Sabri";
        Console.WriteLine(muhendis.GetFullName());

        ///Çalışan sınıfı absract olduğu için başka sınıfta
        ///initialize edilemez ancak inheritance (miras yoluyla kullanılabilir)
        // Calisan calisan = new Calisan(); 
    }
}