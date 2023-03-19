internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Thread Id: " + Thread.CurrentThread.ManagedThreadId);
        Console.WriteLine("İşlemci çekirdek sayısı: " + Environment.ProcessorCount);
        Console.WriteLine("*******************");

        AddParams addParams = new AddParams(10,10);
        Thread thread = new Thread(new ParameterizedThreadStart(Add));
        thread.Start(addParams);
    }

    static void Add(object data)
    {
        if(data is AddParams)
        {
            Console.WriteLine("Id of thread in main(): {0}", Thread.CurrentThread.ManagedThreadId);
            AddParams ap = (AddParams)data;
            Console.WriteLine("{0} + {1} = {2}", ap.a,ap.b,ap.a+ap.b);
        }
    }
}

class AddParams
{
    public int a;
    public int b;

    public AddParams(int num1, int num2)
    {
        a= num1;
        b= num2;
    }
}