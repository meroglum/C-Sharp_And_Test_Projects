using _2023._01._25LINQ;
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
        /// Filter successfull.
        /// </summary>
        public static void WhereExample00()
        {
            OgrenciData ogrenciData = new OgrenciData(); ///Todo do not call this on all methods
            var basariliOgrenciler = ogrenciData.OgrenciListesi.Where(Ogrenci => Ogrenci.Notlar[0] >= 50.0);
            Console.WriteLine("Başarılı Öğrenciler Listesi");
            foreach (var Ogrenci in basariliOgrenciler)
            {
                Console.WriteLine(Ogrenci.Ad + " " + Ogrenci.Soyad);
            }
            Console.WriteLine(Environment.NewLine);
        }

        /// <summary>
        /// Filter failed students.
        /// </summary>
        public static void WhereExample01()
        {
            OgrenciData ogrenciData = new OgrenciData(); ///Todo do not call this on all methods
            var kalanOgrenciler = ogrenciData.OgrenciListesi.Where(Ogrenci => Ogrenci.Notlar[0] < 50);
            Console.WriteLine("Kalan Öğrenciler Listesi:");
            foreach (var Ogrenci in kalanOgrenciler)
            {
                Console.WriteLine(Ogrenci.Ad + " " + Ogrenci.Soyad);
            }
            Console.WriteLine(Environment.NewLine);
        }

        /// <summary>
        /// Get surnames with LINQ.
        /// </summary>
        public static void LinqWhereExample02()
        {
            OgrenciData ogrenciData = new OgrenciData();
            string input = string.Empty;
            try
            {
                Console.WriteLine("Lütfen soyad filtresi giriniz");
                input = Console.ReadLine();
            }catch(Exception e)
            {
                Console.WriteLine("Hata: " + e);
            }
            var soyadıAOgrenciler = ogrenciData.OgrenciListesi.Where(
                Ogrenci => Ogrenci.Soyad.StartsWith(input.First()));
            Console.WriteLine("LINQ ile Soyadı {0} içeren öğrenciler:" , input);
            foreach (var Ogrenci in soyadıAOgrenciler)
            {
                Console.WriteLine("{0}, {1}", Ogrenci.Soyad, Ogrenci.Ad);
            }
            Console.WriteLine(Environment.NewLine);
        }

        /// <summary>
        /// Get surnames and names with LINQ.
        /// </summary>
        public static void LinqWhereExample03()
        {
            OgrenciData ogrenciData = new OgrenciData();
            var soyadıAOgrenciler = ogrenciData.OgrenciListesi.Where(
                Ogrenci => Ogrenci.Soyad.StartsWith("C") && Ogrenci.Ad.StartsWith("K"));
            Console.WriteLine("LINQ ile Soyadı C Adı K ile başlayan öğrenciler...");
            foreach (var Ogrenci in soyadıAOgrenciler)
            {
                Console.WriteLine("{0}, {1}", Ogrenci.Soyad, Ogrenci.Ad);
            }
            Console.WriteLine(Environment.NewLine);
        }

        /// <summary>
        /// Get the birthdates of students whose names starts with a.
        /// </summary>
        public static void LinqWhereExample04()
        {
            OgrenciData ogrenciData = new OgrenciData();
            var BasariliOgrenciler = ogrenciData.OgrenciListesi.Where(Ogrenci => Ogrenci.Ad.StartsWith("A"));
            Console.WriteLine("LINQ ile Adı A ile başlayan öğrencilerin doğum yılları...");
            foreach (var Ogrenci in BasariliOgrenciler)
            {
                Console.WriteLine("{0}, {1}", Ogrenci.Soyad, Ogrenci.Ad);
                foreach (var SecilenOgrenci in Ogrenci)
                {
                    Console.Write("{0} ", SecilenOgrenci.DogumTarih.Year); // DoguDogumTarih.Year yerine ayrı bir liste de dönebilir
                }
                Console.WriteLine();
            }
            Console.WriteLine(Environment.NewLine);
        }

    }
}
