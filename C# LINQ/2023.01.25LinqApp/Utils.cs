using _2023._01._25LinqApp.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._01._25LinqApp
{
    public static class Utils
    {
        /// <summary>
        /// loads student list.
        /// </summary>
        public static void GetStudentList()
        {
            Console.WriteLine("----------STUDENT LIST----------");
            Console.WriteLine(Environment.NewLine);
            OgrenciData ogrenciData = new OgrenciData();
            foreach (var ogrenci in ogrenciData.OgrenciListesi)
            {
                Console.WriteLine("{0}, {1} {2}, {3}, {4}",
                    ogrenci.Id,ogrenci.Ad, ogrenci.Soyad, ogrenci.Cinsiyet?"Female":"Male", ogrenci.DogumTarih.Year);
            }
            SelectAnAction();
        }

        /// <summary>
        /// To select an action.
        /// </summary>
        public static void SelectAnAction()
        {
            int selection = -1;
            
            while (selection != 0)
            {
                showOnConsole();
                proccessSelectedOption(ref selection);
            }
         
        }

        /// <summary>
        /// To show the availabe selections in the console
        /// </summary>
        private static void showOnConsole()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Lütfen seçin yapınız");
            Console.WriteLine("1 Başarılı Öğrenciler Listsi");
            Console.WriteLine("2 Başarısız Öğrenciler Listsi");
            Console.WriteLine("3 Soyadı filtrelenmiş Öğrenciler Listsi");
            Console.WriteLine("4 Adı Soyadı filtrelenmiş Öğrenciler Listsi");
            Console.WriteLine("5 Doğum yılları filtrelenmiş Öğrenciler Listsi");
            Console.WriteLine("6 Öğrencilerin adları");
            Console.WriteLine("6 Öğrencilerin soyadları");
            Console.WriteLine("7 Listedeki ilk 5 öğrenci");
            Console.WriteLine("8 Takdir belgesi alan öğrenciler");
            Console.WriteLine("9 Teşekkür belgesi alan öğrenciler");
            Console.WriteLine("10 Listedeki son 2 öğrenci");
            Console.WriteLine("11 Notlara göre sıralı öğrenci listesi (Artan)");
            Console.WriteLine("12 Notlara göre sıralı öğrenci listesi (Azalan)");
            Console.WriteLine("13 Adı ve soyadına göre sıralı öğrenci listesi");
            Console.WriteLine("14 Cinsiyete göre öğrenciler");
            Console.WriteLine("15 Tam not alan öğrenciler");
            Console.WriteLine("0 Çıkış Yap");
        }

        /// <summary>
        /// Act depending on the user selection, ref is used for using and changing outside var.
        /// </summary>
        /// <param name="selection"></param>
        private static void proccessSelectedOption(ref int selection)
        {
            try
            {
                selection = int.Parse(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        LinqMethods.WhereExample00();
                        break;
                    case 2:
                        LinqMethods.WhereExample01();
                        break;
                    case 3:
                        LinqMethods.LinqWhereExample02();
                        break;
                    case 4:
                        LinqMethods.LinqWhereExample03();
                        break;
                    case 5:
                        LinqMethods.LinqWhereExample04();
                        break;
                    case 6:
                        LinqMethods.LinqSelectExample0();
                        break;
                    case 7:
                        LinqMethods.LinqTakeFirstElements();
                        break;
                    case 8:
                        LinqMethods.LinqTakeSuccessfulStudentElements();
                        break;
                    case 9:
                        LinqMethods.LinqTakeThankfulStudentElements();
                        break;
                    case 10:
                        LinqMethods.LinqSkipStudents();
                        break;
                    case 11:
                        LinqMethods.LinqOrderStudentsAscending();
                        break;
                    case 12:
                        LinqMethods.LinqOrderStudentsDecending();
                        break;
                    case 13:
                        LinqMethods.LinqOrderWithNameAndSurname();
                        break;
                    case 14:
                        LinqMethods.GroupStudentsAccordingToTheGender();
                        break;
                    case 15:
                        LinqMethods.GetIfAnyStudentHasFullPts();
                        break;
                    default:
                        selection = 0;
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
