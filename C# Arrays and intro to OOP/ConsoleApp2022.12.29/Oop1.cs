using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2022._12._29
{
    internal class Oop1
    {
        /*
            OOP (Object Oriented Programming, Nesne Yönelimli Programlama)

            Methods
            Class
            Namespace
            Nested Class
            Advanced Class
            Interface
            Inheritance
            Çok Biçimlilik 
            Struct
            Static
            Partial
            Virtual/Override
            Abstract
            Sealed
        */

        /// <summary>
        /// Basic method structure which returns void.
        /// </summary>
        public static void SayHi()
        {
            Console.WriteLine("Hi");
        }

        /// <summary>
        /// Basic method with input paramaters.
        /// </summary>
        /// <param name="txt"></param>
        public static void Yaz(string txt)
        {
            Console.WriteLine(txt);
        }

        /// <summary>
        /// Method with input parameters and returns an int value
        /// </summary>
        /// <param name="sayi1"></param>
        /// <param name="sayi2"></param>
        /// <returns></returns>
        public static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        /// <summary>
        /// Method to get type of the object.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Type TipeBak(object obj)
        {
            return obj.GetType();
        }

        /// <summary>
        /// To get newline space
        /// </summary>
        public static void Bosluk()
        {
            Console.WriteLine(Environment.NewLine);
        }

        /// <summary>
        /// To get new line space dynamically
        /// </summary>
        /// <param name="bosSatirSayisi"></param>
        static void Bosluk(int bosSatirSayisi)
        {
            for (int i = 1; i <= bosSatirSayisi; i++)
            {
                Console.WriteLine();
            }
        }

        /// <summary>
        /// To get user input
        /// </summary>
        public static void Bekle()
        {
            Console.ReadLine();
        }

        /// <summary>
        /// To add new user
        /// </summary>
        /// <param name="ad"></param>
        /// <param name="soyad"></param>
        /// <param name="aktifMi"></param>
        static void KullaniciEkle(string ad, string soyad, bool aktifMi = false)
        {
            /// TODO Implement functionality
        }
    }


}
