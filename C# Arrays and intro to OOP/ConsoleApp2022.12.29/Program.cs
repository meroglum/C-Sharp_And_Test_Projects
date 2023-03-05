using System;
using System.Collections;
using System.Diagnostics;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        // Koleksiyonlar
        // Jenerik (Generic)
        // Herhangi bir veri türünü alacak şekilde oluşturulabilirler.
        // Jenerik Olmayanlar (NonGeneric)
        // Object alırlar.

        #region NonGeneric

        //  Farklı türlerdeki verilerin bir arada saklanabildiği koleksiyon türleridir.
        //  İçerisindeki verinin elde edilip kullanılabilmesi için boxing/unboxing işlemine tabi tutulması gerekir.
        //  System.Collections namespace'inde yer alırlar.
        // İçerikler : ArrayList, HashTable, SortedList

        #region ArrayList Example

        //ArrayList Sehirler = new ArrayList();
        //Sehirler.Add("İstanbul");
        //Sehirler.Add("Ankara");
        //Sehirler.Add("İzmir");
        //Sehirler.Add("Antalya");
        //Sehirler.Add("Adana");

        //foreach (var sehir in Sehirler)
        //{
        //    Console.WriteLine(sehir);
        //}

        //Console.WriteLine("Count : " + Sehirler.Count); // Length
        //Console.WriteLine("Capacity : " + Sehirler.Capacity);
        //Sehirler.Capacity = 100;
        //Console.WriteLine("Capacity : " + Sehirler.Capacity);

        //var result = Sehirler.Contains("İzmir");
        //Console.WriteLine(result ? "var" : "yok");

        //Sehirler.Add(new Program());
        //Sehirler.Add(true);

        //var x = Sehirler[1];
        //Console.WriteLine(x);

        //Array array = Array.CreateInstance(typeof(int), 10);

        //
        //object[] sehirX = Sehirler.ToArray();
        //foreach (var s in sehirX)
        //{
        //    Console.WriteLine(s);
        //}

        //Console.WriteLine(Sehirler.GetType());

        #endregion

        #region HashTable

        //Hashtable siniflar = new Hashtable();
        //siniflar.Add("001", "Sistem ve Ağ Uzmanlığı");
        //siniflar.Add("002", "Yazılım ve Veritabanı Uzmanlığı");
        //siniflar.Add("003", "Web Yazılım Uzmanlığı");

        //foreach (var sinif in siniflar)
        //{
        //    Console.WriteLine(sinif);
        //}

        //foreach (DictionaryEntry sinif in siniflar)
        //{
        //    Console.WriteLine(sinif.Key);
        //}

        #endregion

        #endregion

        #region Generics

        // System.Collections.Generic namespace'i içerisinde yer alır.
        // Veriler object türünde değil, belirtilen türde alınırlar. 
        // Boxing/Unboxing işlemine gerek olmadığını gösterir.
        // Oluşturma sırasında veri tipini belirtmek zorundadır.
        // ArrayList gibi NonGeneric yapılara göre daha performanslı çalışır.

        // İçerikler; List, Stack, Queue, LinkedList, Dictionary, SortedDictionary, SortedSet, HashSet

        #region List

        List<string> diller = new List<string>();
        diller.Add("C");
        diller.Add("C++");
        diller.Add("C#");
        //diller.Add(2);

        //foreach (var dil in diller)
        //{
        //    Console.WriteLine(dil);
        //}

        //for (int i = 0; i < diller.Count; i++)
        //{
        //    Console.WriteLine(diller[i]);
        //}

        List<double> d = new List<double>();
        d.Add(1.3);
        d.Add(3.5);

        #endregion

        #region Dictionary

        Dictionary<int, string> Kullanicilar = new Dictionary<int, string>();
        Kullanicilar.Add(2, "Ali");
        Kullanicilar.Add(4, "Murtaza");

        //foreach (var k in Kullanicilar)
        //{
        //    Console.WriteLine(k);
        //    //Console.WriteLine(k.Key);
        //    //Console.WriteLine(k.Value);
        //}

        //foreach (KeyValuePair<int, string> k in Kullanicilar)
        //{

        //}

        //KeyValuePair<int, string> kullanici = Kullanicilar.First();
        //Console.WriteLine(kullanici.Key + " " + kullanici.Value);

        Dictionary<int, string> pDiller = new Dictionary<int, string>()
        {
            { 1, "Go" },
            { 2, "Rust"}
        };

        //foreach (KeyValuePair<int, string> p in pDiller)
        //{
        //    Console.WriteLine(p.Value);
        //}

        List<string> dilList = diller.ToList();


        #endregion

        #endregion
    }
}