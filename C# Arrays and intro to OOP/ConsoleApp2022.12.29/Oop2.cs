using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Diagnostics;
using System.Text;

class Oop2
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
    Oop2() ///OOP 2 constructer
    {
        //Random sayi = new Random();
        //int no = sayi.Next(1, 50);
        //Console.WriteLine(no);

        //SayHi();
        //Yaz("Hayy!");
        //int result = Topla(10, 3);
        //Console.WriteLine(result);
        //Console.WriteLine(Topla(10, 3));

        //Bosluk();
        //Console.WriteLine("**************");
        //Bosluk();

        //Console.WriteLine(TipeBak(10));

        //for (int i = 0; i < 10; i++)
        //{
        //    Console.WriteLine(Rastgele());
        //}

        //Console.WriteLine(EnBuyuk(548,965));
        //Console.WriteLine(EnBuyuk(548, 465, 154));
        //EnBuyuk(1, 2, 3);
        //EnBuyuk(data: new int[] { 1, 2, 3 });

        //Console.WriteLine(HepisiniTopla(12, 12, 34, 4365, 457, 23, 345, 234));

        KullaniciEkle(
            soyad: "afaf",
            ad: "adada");

        // Named Parameter
        Ayarla(
            setting01: "",
            setting05: "",
            setting02: "",
            setting04: "",
            setting03: "");

        // Optional Parameter
        KullaniciEkleOptional("", "");
        KullaniciEkleOptional("", "", true);
        KullaniciEkleOptional2("", "", y: "");
        IsValid("cihan@deeplab.co");
        Console.WriteLine(GetAccountName(3));
    }

    /// <summary>
    /// Checks if the email is valid
    /// </summary>
    /// <param name="email"></param>
    /// <returns></returns>
    static bool IsValid(string email)
    {
        // RegEx (Regular Expression)
        bool isValid = false;
        if (email.Contains("@"))
        {
            isValid = true;
        }
        return isValid;
    }

    /// <summary>
    /// It gets the account name according to the account ID
    /// </summary>
    /// <param name="accountId"></param>
    /// <returns></returns>
    static string GetAccountName(int accountId)
    {
        string accountName = string.Empty;
        switch (accountId)
        {
            case 1:
                accountName = "Cihan";
                break;
            case 2:
                accountName = "Hakkı Bulut";
                break;
            case 3:
                accountName = "Murtaza Can";
                break;
            default:
                accountName = "Unknown";
                break;
        }
        return accountName;
    }

    /// <summary>
    /// It gets random integer.
    /// </summary>
    /// <returns></returns>
    public static int Rastgele()
    {
        Random rnd = new Random();
        return rnd.Next(1000, int.MaxValue);
    }

    /// <summary>
    /// It gets the biggest number of two.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    static int EnBuyuk(int a, int b)
    {
        if (a > b)
            return a;
        return b;
    }

    /// <summary>
    /// It gets the biggest number of 3.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    /// <returns></returns>
    public static int EnBuyuk(int a, int b, int c)
    {
        Console.WriteLine("int,int,int");
        return EnBuyuk(EnBuyuk(a, b), c);
    }

    /// <summary>
    /// It gets the biggest number of dynamic number of integers.
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    public static int EnBuyuk(params int[] data)
    {
        Console.WriteLine("params : " + data);
        return 0;
    }

    // İsimlendirilmiş Parametreler (Named Parameters)
    /// <summary>
    /// It adds user name and surname.
    /// </summary>
    /// <param name="ad"></param>
    /// <param name="soyad"></param>
    static void KullaniciEkle(string ad, string soyad)
    {
        Console.WriteLine("ad, soyad");
    }

    /// <summary>
    /// Adds user with optional parameter.
    /// </summary>
    /// <param name="ad"></param>
    /// <param name="soyad"></param>
    /// <param name="aktifMi"></param>
    static void KullaniciEkleOptional(string ad, string soyad, bool aktifMi = false)
    {
        Console.WriteLine("ad, soyad, bool");
    }

    /// <summary>
    /// Adds user with optional parameters.
    /// </summary>
    /// <param name="ad"></param>
    /// <param name="soyad"></param>
    /// <param name="x"></param>
    /// <param name="y"></param>
    static void KullaniciEkleOptional2(string ad, string soyad, string x = "", string y = "")
    {
        Console.WriteLine("ad, soyad, bool");
    }

    /// <summary>
    /// Settings method.
    /// </summary>
    /// <param name="setting01"></param>
    /// <param name="setting02"></param>
    /// <param name="setting03"></param>
    /// <param name="setting04"></param>
    /// <param name="setting05"></param>
    static void Ayarla(string setting01, string setting02, string setting03, string setting04, string setting05)
    {
        Console.WriteLine("ad, soyad, bool");
    }

    //static int EnBuyuk(int[] data)
    //{
    //    Console.WriteLine("params : " + data);
    //    return 0;
    //}


    /// <summary>
    /// İstediğim kadar int parametre göndereyim, ve en büyüğü dönsün.
    /// Çözüm : Variadic Parameters (Değişken Sayıda Parametre)
    /// </summary>
    /// <returns></returns>
    public static int HepisiniTopla(params int[] sayilar)
    {
        int toplam = 0;
        foreach (int sayi in sayilar) // Ayrıca int yerine var kullanılabilir.
        {
            toplam += sayi;
        }
        return toplam;
    }

    /// <summary>
    /// Method to write down static string to the console.
    /// </summary>
    public static void SayHi()
    {
        Console.WriteLine("Hi");
    }

    /// <summary>
    /// Method to write down parameter string to the console.
    /// </summary>
    /// <param name="txt"></param>
    public static void Yaz(string txt)
    {
        Console.WriteLine(txt);
    }

    /// <summary>
    /// To add to ints.
    /// </summary>
    /// <param name="sayi1"></param>
    /// <param name="sayi2"></param>
    /// <returns></returns>
    public static int Topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }

    /// <summary>
    /// Method for getting type of the object.
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static Type TipeBak(object obj)
    {
        return obj.GetType();
    }

    /// <summary>
    /// Satır boşluğu için kullanılır.
    /// </summary>
    public static void Bosluk()
    {
        Console.WriteLine(Environment.NewLine);
    }

    /// <summary>
    /// Dinamik satır boşluğu için
    /// </summary>
    /// <param name="bosSatirSayisi"></param>
    public static void Bosluk(int bosSatirSayisi)
    {
        for (int i = 1; i <= bosSatirSayisi; i++)
        {
            Console.WriteLine();
        }
    }

    /// <summary>
    /// To get user input.
    /// </summary>
    static void Bekle()
    {
        Console.ReadLine();
    }

    /// <summary>
    /// To add new user.
    /// </summary>
    /// <param name="ad"></param>
    /// <param name="soyad"></param>
    /// <param name="aktifMi"></param>
    static void KullaniciEkle(string ad, string soyad, bool aktifMi = false)
    {
        /// TODO implement functionality
    }
}
