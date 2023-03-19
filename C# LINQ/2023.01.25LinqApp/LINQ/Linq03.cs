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
        /// Use Take to get first five elements of the list.
        /// </summary>
        public static void LinqTakeFirstElements()
        {
            OgrenciData ogrenciData = new OgrenciData(); ///Todo do not call this on all methods
            var Ilk5Ogrenci = ogrenciData.OgrenciListesi.Take(5); // Takes first five items in the list
            Console.WriteLine("Listedeki ilk 5 öğrenci :");

            foreach (var Ogrenci in Ilk5Ogrenci)
            {
                Console.WriteLine("{0} {1}", Ogrenci.Ad, Ogrenci.Soyad);
            }
            Console.WriteLine(Environment.NewLine);
        }

        /// <summary>
        /// Use Take to get Successful Students elements of the list.
        /// </summary>
        public static void LinqTakeSuccessfulStudentElements()
        {
            OgrenciData ogrenciData = new OgrenciData(); ///Todo do not call this on all methods
            var TakdirBelgesiAlacaklar =
                   ogrenciData.OgrenciListesi.SelectMany(Ogrenci => Ogrenci.Notlar.Where(Notlar => Notlar >= 85.00)
                                          ,
                                         (Ogrenci, Notu) => new { Ogrenci.Ad, Not = Notu }
                                        ).Take(5);

            Console.WriteLine("Takdir belgesi alan öğrenciler :");
            foreach (var Satir in TakdirBelgesiAlacaklar)
            {
                Console.WriteLine("{0} {1}", Satir.Ad, Satir.Not);
            }
            Console.WriteLine(Environment.NewLine);
        }

        /// <summary>
        /// Use Take to get Successful Students elements of the list.
        /// </summary>
        public static void LinqTakeThankfulStudentElements()
        {
            OgrenciData ogrenciData = new OgrenciData(); ///Todo do not call this on all methods
            var TakdirBelgesiAlacaklar =
                   ogrenciData.OgrenciListesi.SelectMany(Ogrenci => Ogrenci.Notlar.Where(
                       Notlar => Notlar >= 70 && Notlar < 85.00),
                                         (Ogrenci, Notu) => new { Ogrenci.Ad, Not = Notu }
                                        ).Take(5);

            Console.WriteLine("Teşekkür belgesi alan öğrenciler :");
            foreach (var Satir in TakdirBelgesiAlacaklar)
            {
                Console.WriteLine("{0} {1}", Satir.Ad, Satir.Not);
            }
            Console.WriteLine(Environment.NewLine);
        }

        /// <summary>
        /// It gets the last 2 students on the list
        /// </summary>
        public static void LinqSkipStudents()
        {
            OgrenciData ogrenciData = new OgrenciData(); ///Todo do not call this on all methods
            var Son2Ogrenci = ogrenciData.OgrenciListesi.Skip(ogrenciData.OgrenciListesi.Count() - 2);
            Console.WriteLine("Listedeki son 2 öğrenci :");

            foreach (var Ogrenci in Son2Ogrenci)
            {
                Console.WriteLine("{0} {1}", Ogrenci.Ad, Ogrenci.Soyad);
            }
            Console.WriteLine(Environment.NewLine);
        }

        /// <summary>
        /// It orders to students according to the avarage notes -Ascending order
        /// </summary>
        public static void LinqOrderStudentsAscending()
        {
            OgrenciData ogrenciData = new OgrenciData(); ///Todo do not call this on all methods
            var SiraliOgrenciListesi = ogrenciData.OgrenciListesi.OrderBy(Ogrenci => Ogrenci.Notlar[0]);
            Console.WriteLine("Notlara göre sıralı öğrenci listesi (Artan) :");

            foreach (var Ogrenci in SiraliOgrenciListesi)
            {
                Console.WriteLine("Not: {0} - Adı: {1} Soyadı: {2}", Ogrenci.Notlar[0], Ogrenci.Ad, Ogrenci.Soyad);
            }
            Console.WriteLine(Environment.NewLine);
        }

        /// <summary>
        /// It orders to students according to the avarage notes -Decending order
        /// </summary>
        public static void LinqOrderStudentsDecending()
        {
            OgrenciData ogrenciData = new OgrenciData(); ///Todo do not call this on all methods
            var SiraliOgrenciListesi = ogrenciData.OgrenciListesi.OrderByDescending(Ogrenci => Ogrenci.Notlar[0]);
            Console.WriteLine("Notlara göre sıralı öğrenci listesi (Azalan) :");

            foreach (var Ogrenci in SiraliOgrenciListesi)
            {
                Console.WriteLine("Not: {0} - Adı: {1} Soyadı: {2}", Ogrenci.Notlar[0], Ogrenci.Ad, Ogrenci.Soyad);
            }
            Console.WriteLine(Environment.NewLine);
        }

        /// <summary>
        /// Orders according to the name and surname ascending order.
        /// </summary>
        public static void LinqOrderWithNameAndSurname()
        {
            OgrenciData ogrenciData = new OgrenciData(); ///Todo do not call this on all methods
            var SiraliOgrenciListesi = ogrenciData.OgrenciListesi.OrderBy(Ogrenci => Ogrenci.Ad).ThenBy(Ogrenci => Ogrenci.Soyad);

            Console.WriteLine("Adı ve soyadına göre sıralı öğrenci listesi :");

            foreach (var Ogrenci in SiraliOgrenciListesi)
            {
                Console.WriteLine("{0} {1}",  Ogrenci.Ad, Ogrenci.Soyad);
            }
            Console.WriteLine(Environment.NewLine);
        }

        /// <summary>
        /// For grouping the students by their gender.
        /// </summary>
        public static void GroupStudentsAccordingToTheGender()
        {
            OgrenciData ogrenciData = new OgrenciData(); ///Todo do not call this on all methods
            var ogrenciler = ogrenciData.OgrenciListesi.OrderBy(Ogrenci => Ogrenci.Cinsiyet).GroupBy(Ogrenci => Ogrenci.Cinsiyet);
            Console.WriteLine("Cinsiyete göre öğrenciler ");

            foreach (var cinsiyeteGoreListe in ogrenciler) ///For Grouping
            {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine((!cinsiyeteGoreListe.Key ? "Erkek ":"Kadın ") +"Öğrenciler: ");
                
                foreach (var Ogrenci in cinsiyeteGoreListe)
                {
                    Console.WriteLine("{0} {1}", Ogrenci.Ad, Ogrenci.Soyad);
                }
            }
            Console.WriteLine(Environment.NewLine);
        }

        /// <summary>
        /// It gets if any of the studens get 100 pts as a boolean.
        /// </summary>
        public static void GetIfAnyStudentHasFullPts()
        {
            OgrenciData ogrenciData = new OgrenciData(); ///Todo do not call this on all methods
            bool tamNotAlanOgrenci = ogrenciData.OgrenciListesi.Any(Ogrenci => Ogrenci.Notlar[0] == 100.0);

            Console.WriteLine("Tam not alan öğrenci {0}.", tamNotAlanOgrenci ? "var" : "yok");
            Console.ReadLine();
        }
    }
}
