using System.Collections;

class GenericClasses2
{
    // Advanced C#
    // Generic metod ile default operator örneği
    GenericClasses2()
    {
        Islemler<double> sinif = new Islemler<double>();
        double sonuc = sinif.IslemYap(4.3, -2);

        Console.WriteLine(sonuc);
    }
}

/// <summary>
/// T can be any data type.
/// </summary>
/// <typeparam name="T"></typeparam>
class Islemler<T>
{
    public T IslemYap(T t, int param)
    {
        if (param >= 0)
        {
            return t;
        }
        else
        {
            return default(T);
        }
    }
}