internal class Program
{
    // Lecture Notes.
    private static void Main(string[] args)
    {
        Printer printer = new Printer();
        Thread bgThread = new Thread(new ThreadStart(printer.PrintNumbers));
        bgThread.IsBackground = true;
        bgThread.Start();

        Console.WriteLine("---------------------");
        Console.WriteLine("Current thread state: " + Thread.CurrentThread.ThreadState.ToString());
        Console.WriteLine("bgThread Thread state: " + bgThread.ThreadState.ToString());
        Console.WriteLine("----------------------");
        Console.WriteLine("Current thread priority: " + Thread.CurrentThread.Priority.ToString());
        Console.WriteLine("bgThread Thread priority: " + bgThread.Priority.ToString());
    }
}

public class Printer
{
    public void PrintNumbers()
    {
        Console.WriteLine("-> is execting PrintNumbers()", Thread.CurrentThread.Name);
        Console.WriteLine("Your numbers: ");
        for (int i = 0; i < 10; i++)
        {
            Random r = new Random();
            Thread.Sleep(1000);
            Console.WriteLine(i + ", " + r);
        }
        Console.WriteLine();
    }
}