//using System.Collections;

class GenericClasses
{
    // Advanced C#
    GenericClasses()
    {
        //  List<string> isimler = new List<string>();  // Generic
        //  isimler.Add("Ali");
        //  ArrayList liste = new ArrayList();    // Nongeneric

        //  List<User> users = new List<User>();
        //  users.Add(new User());

        Liste l1 = new Liste();

        Liste<bool> l2 = new Liste<bool>();
        l2.Add(true);
        l2.Add(false);

        Liste<int, string> l3 = new Liste<int, string>();
        l3.Add(34, "İstanbul");
        l3.Add(1, "Adana");
        l3.Get();

        Liste<int, string, double, float, bool, User, int, int, int, int, int, int, int, int, int, int, int, int, int, int, string, int, int> xxx = new Liste<int, string, double, float, bool, User, int, int, int, int, int, int, int, int, int, int, int, int, int, int, string, int, int>();
        //xxx.Add();
    }
}

class User
{

}

class Liste
{

}

/// <summary>
/// In the below part generic class definitions can be observed.
/// </summary>
/// <typeparam name="T"></typeparam>
class Liste<T>
{
    List<T> list = new List<T>();

    public void Add(T obj)
    {
        list.Add(obj);
    }

    public void Get()
    {
        foreach (var t in list)
        {
            Console.WriteLine("t - >" + t);
        }
    }
}

class Liste<T, K>
{
    T inT;
    K inK;

    public Liste()
    {
        Console.WriteLine("T -> " + typeof(T));
        Console.WriteLine("K -> " + typeof(K));
    }

    public void Add(T t, K k)
    {
        inT = t;
        inK = k;
    }

    public void Get()
    {
        Console.WriteLine("T değer : " + inT);
        Console.WriteLine("K değer : " + inK);
    }
}

class Liste<T, K, V>
{
    public Liste()
    {

    }
}

class Liste<A, B, C, D, E, F, G, I, K, L, J, H, M, N, Y, T, R, Z, X, V, P, O, W>
{
    public Liste()
    {

    }

    public void Add(A a, B b, C c, D d, E e, F f, G g, I i, K k, L l, J j, H h, M m, N n, Y y, T t, R r, Z z, X x, V v, P p, O o, W w)
    {

    }
}