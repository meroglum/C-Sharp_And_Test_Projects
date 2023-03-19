using _2023._01._25LinqApp.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._01._25LinqApp
{
    public static partial class LinqMethods
    {
        /// <summary>
        /// Take name of the student with Select().
        /// </summary>
        public static void LinqSelectExample0()
        {
            OgrenciData ogrenciData = new OgrenciData(); ///Todo do not call this on all methods
            var OgrenciSoyadlari = ogrenciData.OgrenciListesi.Select(Ogrenci => Ogrenci.Ad);
            Console.WriteLine("Öğrencilerin adları :");
            foreach (var Soyad in OgrenciSoyadlari)
            {
                Console.WriteLine(Soyad);
            }
            Console.WriteLine(Environment.NewLine);
        }

        /// <summary>
        /// Take surname of the student with Select().
        /// </summary>
        public static void LinqSelectExample1()
        {
            OgrenciData ogrenciData = new OgrenciData(); ///Todo do not call this on all methods
            var OgrenciSoyadlari = ogrenciData.OgrenciListesi.Select(Ogrenci => Ogrenci.Soyad);
            Console.WriteLine("Öğrencilerin soyadları :");
            foreach (var Soyad in OgrenciSoyadlari)
            {
                Console.WriteLine(Soyad);
            }
            Console.WriteLine(Environment.NewLine);
        }

        /// <summary>
        /// Take surname of the student with Select().
        /// </summary>
        public static void LinqSelectExample2()
        {
            int[] Sayilar = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            Console.WriteLine("Sayi Listesi: ");
            foreach (var item in Sayilar)
            {
                Console.Write(item +", ");
            }
            var SayilarArtiBir = Sayilar.Select(Sayi => Sayi + 1);
            Console.WriteLine("\nSayilar + 1:");
            foreach (var i in SayilarArtiBir);
            {
                Console.WriteLine();
            }
            Console.WriteLine(Environment.NewLine);
        }

        /// <summary>
        /// Increases every element of an array by 1.
        /// </summary>
        public static void IncreasNumbersWithSelect()
        {
            int[] Sayilar = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            Console.WriteLine("Sayi Listesi: ");
            foreach (var item in Sayilar)
            {
                Console.Write(item + ", ");
            }
            var SayilarArtiBir = Sayilar.Select(Sayi => Sayi + 1);
            Console.WriteLine("\nSayılar + 1:");
            foreach (var i in SayilarArtiBir)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine(Environment.NewLine);
        }
    }
}
