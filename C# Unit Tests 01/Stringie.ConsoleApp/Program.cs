using Stringie;
using System;

class Program
{
    /// <summary>
    /// Lecture notes.
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        var empty = "Hello, world!".Remove();
        if (string.IsNullOrEmpty(empty))
        {
            Console.WriteLine("Remove: OK");
        }
        else 
        {
            Console.WriteLine($"Remove failed. Expected: ''. But it was: {empty}");
        }
        Console.ReadKey();
    }
}