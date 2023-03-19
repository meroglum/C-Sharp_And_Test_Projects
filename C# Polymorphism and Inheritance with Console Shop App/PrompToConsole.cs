using _2023._01._04_exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppExercise
{
    internal class PrompToConsole
    {
        /// <summary>
        /// Alışveriş için tüm soruları CLI'da göster.
        /// </summary>
        public static void CLIStore()
        {
            Product product = new Product();
            Console.WriteLine("--------------------");
            Console.WriteLine("     HOŞGELDİNİZ");
            Console.WriteLine("--------------------");
            Console.WriteLine("CLI Teknoloji Mağazası");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("1. Telefon");
            Console.WriteLine("2. Bilgisayar");
            product.SelectProductType();
            product.SelectProductModel();
            string stringToSave = product.GetLOGData();
            finalizeShopping(stringToSave);
        }

        /// <summary>
        /// Alışveriş sonuçlarını txt olarak kaydet.
        /// </summary>
        /// <param name="stringToSave"></param>
        /// <returns></returns>
        public static async Task SaveToTXT(string stringToSave)
        {
            using StreamWriter file = new("ShopResult.txt", append: true);
            await file.WriteLineAsync(stringToSave);
        }

        /// <summary>
        /// Alışverişi tamamla.
        /// </summary>
        /// <param name="stringToSave"></param>
        private static void finalizeShopping(string stringToSave)
        {
            int accepted = 0;
            Console.WriteLine("Ürünü onaylıyor musunuz ? \n 1: Evet 2: Hayır");
            try
            {
                accepted = int.Parse(Console.ReadLine()); //Klavyeden yanlış değer girilme ihtimaline karşı
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                accepted = 0;
            }
            if (accepted == 1)
            {
                Console.WriteLine("SİPARİŞ ALINDI");
                Console.ReadLine();
                SaveToTXT(stringToSave); ///Sipariş LOG kaydı yapar
            }
            else
            {
                Console.WriteLine("SİPARİŞ İPTAL EDİLDİ");
            }
        }
    }
}
