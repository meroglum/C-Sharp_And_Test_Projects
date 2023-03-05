using ConsoleApp1;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Diagnostics;
using System.Text;

/// <summary>
// LECTURE NOTES.
/// </summary>
class Program
{
    /*

               Kendi sınıfınızı yazacaksanız, öncelikle C# dilinde nesnelerin birbirleriyle ilişki kurarken 
                hangi erişim kontrolleri ile çalıştığını bilmeniz önemlidir. 
               Erişim belirleyiciler (access modifiers), sınıflara nerelerden ve ne şekilde erişileceğini belirtir.

               Public              : Her yerden erişilebilir.
               Private             : Sadece tanımlandığı sınıf içerisinden erişilebilir.
               Internal            : Sadece bulunduğu projede erişilebilir.
               Protected           : Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.
               Protected Internal  : Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir. 
                                     Ayrıca tanımlamanın aynı proje içerisinde olma şartı yoktur. 
                                     Protected'dan farkı budur.

               Eğer erişim belirleyici belirtilmemişse, sınıflar internal’dır.

               CLASS Bileşenleri

               Fields              : Değer tutan yapılar
               Properties          : Nesnenin özellikleri
               Methods             : Nesnenin yapabildikleri/kabiliyetleri
               Construction        : Nesne oluşurken/kurulurken yapılacak işlemler
               Events / Delegate   : Nesnenin reaksiyonları

            */
    public static void Main(string[] args)
    {
        //Kutu k = new Kutu();
        //k.SetUzunluk(45);
        //var x = k.GetUzunluk();
        //Console.WriteLine(x);

        //k.Genislik = 1;
        //var x = k.Genislik;
        //Console.WriteLine(x);

        Kutu k = new Kutu();
        //for (int i = 0; i < 10; i++)
        //{
        //    k.GetMyGuid();
        //}
        Kutu k2 = new Kutu(11, 22, 33);
        Console.WriteLine(k2.Genislik);
        k2.GetMyGuid();
    }
}