internal class Program
{
    delegate void MyGenericDelegate<T>(T obj);
    private static void Main(string[] args)
    {
        MyGenericDelegate<string> strDelegate = new MyGenericDelegate<string>(StringT);
        strDelegate("Muhammed EROĞLU");

        MyGenericDelegate<int>  intDelegate = new MyGenericDelegate<int>(IntT);
        intDelegate(3);
    }

    static void StringT(string s)
    { 
        Console.WriteLine("Arg veri : " + s.ToUpper()); 
    }

    static void IntT(int i)
    {
        Console.WriteLine("Arg veri : " + ++i);
    }
}
