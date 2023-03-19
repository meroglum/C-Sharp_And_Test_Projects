using _2023._01._25LINQ;
using _2023._01._25LinqApp.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

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
        public static IEnumerable<Ogrenci> LinqTakeSuccessfulStudentElements()
            //Where(Notlar => Notlar >= 85.00)
        {
            OgrenciData ogrenciData = new OgrenciData(); ///Todo do not call this on all methods
            IEnumerable<Ogrenci> TakdirBelgesiAlacaklar =
                   ogrenciData.OgrenciListesi.Where(Ogrenci => Ogrenci.NotOrtalaması >= 85.0);

            Console.WriteLine("Takdir belgesi alan öğrenciler :");
            foreach (var Satir in TakdirBelgesiAlacaklar)
            {
                Console.WriteLine("{0} {1}", Satir.Ad, Satir.NotOrtalaması);
            }
            Console.WriteLine(Environment.NewLine);
            return TakdirBelgesiAlacaklar;
        }

        /// <summary>
        /// Use Take to get Successful Students elements of the list.
        /// </summary>
        public static IEnumerable<Ogrenci> LinqTakeThankfulStudentElements()
        {
            OgrenciData ogrenciData = new OgrenciData(); ///Todo do not call this on all methods
            IEnumerable<Ogrenci> TesekkurBelgesiAlacaklar =
                ogrenciData.OgrenciListesi.Where(Ogrenci => Ogrenci.NotOrtalaması >= 70.0 && Ogrenci.NotOrtalaması < 85.00);

            Console.WriteLine("Teşekkür belgesi alan öğrenciler :");
            foreach (var Satir in TesekkurBelgesiAlacaklar)
            {
                Console.WriteLine("{0} {1}", Satir.Ad, Satir.NotOrtalaması);
            }
            Console.WriteLine(Environment.NewLine);
            return TesekkurBelgesiAlacaklar;
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
        public static IEnumerable<Ogrenci> LinqOrderStudentsAscending()
        {
            OgrenciData ogrenciData = new OgrenciData(); ///Todo do not call this on all methods
            var SiraliOgrenciListesi = ogrenciData.OgrenciListesi.OrderBy(Ogrenci => Ogrenci.NotOrtalaması);
            Console.WriteLine("Notlara göre sıralı öğrenci listesi (Artan) :");

            foreach (var Ogrenci in SiraliOgrenciListesi)
            {
                Console.WriteLine("Not: {0} - Adı: {1} Soyadı: {2}", Ogrenci.NotOrtalaması, Ogrenci.Ad, Ogrenci.Soyad);
            }
            Console.WriteLine(Environment.NewLine);
            return SiraliOgrenciListesi;
        }

        /// <summary>
        /// It orders to students according to the avarage notes -Decending order
        /// </summary>
        public static IEnumerable<Ogrenci> LinqOrderStudentsDecending()
        {
            OgrenciData ogrenciData = new OgrenciData(); ///Todo do not call this on all methods
            var SiraliOgrenciListesi = ogrenciData.OgrenciListesi.OrderByDescending(Ogrenci => Ogrenci.NotOrtalaması);
            Console.WriteLine("Notlara göre sıralı öğrenci listesi (Azalan) :");

            foreach (var Ogrenci in SiraliOgrenciListesi)
            {
                Console.WriteLine("Not: {0} - Adı: {1} Soyadı: {2}", Ogrenci.NotOrtalaması, Ogrenci.Ad, Ogrenci.Soyad);
            }
            Console.WriteLine(Environment.NewLine);
            return SiraliOgrenciListesi;
        }

        /// <summary>
        /// Orders according to the name and surname ascending order.
        /// </summary>
        public static IEnumerable<Ogrenci> LinqOrderWithNameAndSurname()
        {
            OgrenciData ogrenciData = new OgrenciData(); ///Todo do not call this on all methods
            var SiraliOgrenciListesi = ogrenciData.OgrenciListesi.OrderBy(Ogrenci => Ogrenci.Ad).ThenBy(Ogrenci => Ogrenci.Soyad);

            Console.WriteLine("Adı ve soyadına göre sıralı öğrenci listesi :");

            foreach (var Ogrenci in SiraliOgrenciListesi)
            {
                Console.WriteLine("{0} {1}",  Ogrenci.Ad, Ogrenci.Soyad);
            }
            Console.WriteLine(Environment.NewLine);
            return SiraliOgrenciListesi;
        }

        /// <summary>
        /// For grouping the students by their gender.
        /// </summary>
        public static IEnumerable<dynamic> GroupStudentsAccordingToTheGender()
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
            return ogrenciler;
        }

        /// <summary>
        /// It gets if any of the studens get 100 pts as a boolean.
        /// </summary>
        public static void GetIfAnyStudentHasFullPts()
        {
            OgrenciData ogrenciData = new OgrenciData(); ///Todo do not call this on all methods
            bool tamNotAlanOgrenci = ogrenciData.OgrenciListesi.Any(Ogrenci => Ogrenci.NotOrtalaması == 100.0);

            Console.WriteLine("Tam not alan öğrenci {0}.", tamNotAlanOgrenci ? "var" : "yok");
            Console.ReadLine();
        }
    }
}
