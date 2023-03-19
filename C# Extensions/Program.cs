using _2023._01._16;
using System.Collections;

internal class Program
{
    // Extension method 
    private static void Main(string[] args)
    {
        // object obj1 = new object();
        // obj1 = new Program();
        // obj1.DisplayAssemblyInfo();

        // Program prg = new Program();
        // object türünde extension olduğu için istediğimiz nesne tipinde kullanabiliyoruz.
        // prg.DisplayAssemblyInfo();

        // int x = 3;
        // Console.WriteLine(x.Square());

        ArrayList list = new ArrayList();
        list.Add("item 1");
        list.Add("item 2");
        list.ShowItems(); // extension method written by us.
        // AddFullStopToString is a custom extension.
        Console.WriteLine("Sonuna extension ile nokta gelecek string".AddFullStopToString());
    }
}