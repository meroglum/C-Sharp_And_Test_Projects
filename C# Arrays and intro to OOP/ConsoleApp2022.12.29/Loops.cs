using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2022._12._29
{
    internal class Loops
    {
        /*
              Döngüler (Loops)
                  - for
                  - while
                  - do while
                  - foreach
                  - break - continue
        */

        #region FOR

        //for (ifade1; ifade2; ifade3)

        // ifade1 : Döngü içerisinde kullanılan/artılıp/eksiltilen değişken
        // ifade2 : Döngü şartımız
        // ifade3 : Döngü değişkeninin artırma/eksiltme işlemini yapan kısım

        //
        //for (int i=0; i <= 5; i++)
        //{
        //    Console.WriteLine("XYZ : " + i);
        //}

        //
        //int sonuc = 0;
        //for (int i = 0; i <= 7; i++)
        //{
        //    sonuc += i;
        //}
        //Console.WriteLine("Sonuç : " + sonuc);

        //
        //int[] dizi = new int[10];
        //int i = 0, x = 0;
        //for (; i < dizi.Length ;)
        //{
        //    x = dizi.Length;
        //    i++;
        //}
        //Console.WriteLine(x - i);

        // 
        //for (int i = 1; i <= 100; i++)
        //{
        //    if (i != 7)
        //    {
        //        Console.WriteLine("Değer : " + i);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Hediye kazandınız!");
        //    }
        //}

        // 20'den 0'a doğru
        //for (int i = 20; i >= 1; i--)
        //{
        //    Console.WriteLine(i);
        //}

        // 1-100 arasında beşe bölünebilen ve bölünemeyen sayıları bulalım.
        //int bolunebilen = 0, bolunemeyen = 0;
        //for (int i = 1; i <= 100; i++)
        //{
        //    if (i%5 == 0)
        //    {
        //        Console.WriteLine("-> Beşe Bölünebilen : " + i);
        //        bolunebilen++;
        //    }
        //    else if (i%5 != 0)
        //    {
        //        Console.WriteLine("Beşe Bölünemeyen : " + i);
        //        bolunemeyen++;
        //    }
        //}
        //Console.WriteLine("Bölünebilen Sayı Toplam : " + bolunebilen);
        //Console.WriteLine("Bölünemeyen Sayı Toplam : " + bolunemeyen);

        // Üsttekinin kullanıcı yönetimli versiyonu
        //Console.Write("Sayı : ");
        //int sayi = Convert.ToInt32(Console.ReadLine());     // hata yönetimi yapılmalı(try-catch)
        //Console.Write("Kaça : ");
        //int kacaBol = Convert.ToInt32(Console.ReadLine());  // hata yönetimi yapılmalı(try-catch)
        //// sayi ve kacaBol değerleri 0'dan büyük olma kontrolü.

        //int bolunebilen = 0, bolunemeyen = 0;
        //for (int i = 1; i <= sayi; i++)
        //{
        //    if (i % kacaBol == 0)
        //    {
        //        Console.WriteLine("-> Beşe Bölünebilen : " + i);
        //        bolunebilen++;
        //    }
        //    else if (i % kacaBol != 0)
        //    {
        //        Console.WriteLine("Beşe Bölünemeyen : " + i);
        //        bolunemeyen++;
        //    }
        //}
        //Console.WriteLine(Environment.NewLine);
        //Console.WriteLine("**********************");
        //Console.WriteLine(Environment.NewLine);
        //Console.WriteLine(bolunebilen + " adet BÖLÜNEBİLEN sayı bulundu!");
        //Console.WriteLine(bolunemeyen + " adet BÖLÜNEMEYEN sayı bulundu!");

        #endregion

        #region WHILE

        //
        //while (true)
        //{
        //}

        //
        //while (true)
        //    Console.WriteLine("");

        //int i = 0;
        //while (i <= 10)
        //{
        //    Console.WriteLine("CO : " + i);
        //    i++;
        //}

        //int x = 0;
        //for (; x <= 10;)
        //{
        //    Console.WriteLine("CO : " + x);
        //    x++;
        //}

        //
        //Console.Write("Sayı : ");
        //int sayi = Convert.ToInt32(Console.ReadLine());     // hata yönetimi yapılmalı(try-catch)
        //Console.Write("Kaça : ");
        //int kacaBol = Convert.ToInt32(Console.ReadLine());  // hata yönetimi yapılmalı(try-catch)
        //// sayi ve kacaBol değerleri 0'dan büyük olma kontrolü.

        //int bolunebilen = 0, bolunemeyen = 0, i = 1;
        //while (i <= sayi)
        //{
        //    if (i % kacaBol == 0)
        //    {
        //        Console.WriteLine("-> Beşe Bölünebilen : " + i);
        //        bolunebilen++;
        //    }
        //    else if (i % kacaBol != 0)
        //    {
        //        Console.WriteLine("Beşe Bölünemeyen : " + i);
        //        bolunemeyen++;
        //    }
        //    i++;
        //}
        //Console.WriteLine(Environment.NewLine);
        //Console.WriteLine("**********************");
        //Console.WriteLine(Environment.NewLine);
        //Console.WriteLine(bolunebilen + " adet BÖLÜNEBİLEN sayı bulundu!");
        //Console.WriteLine(bolunemeyen + " adet BÖLÜNEMEYEN sayı bulundu!");

        #endregion

        #region Do While

        //
        //do
        //{
        //    Console.WriteLine("CO");
        //}
        //while (false);

        //
        //string str;
        //do
        //{
        //    Console.Write("Şifre : ");
        //    str = Console.ReadLine();

        //} while (str != "12345");
        //Console.WriteLine();
        //Console.WriteLine("Döngüden çıkıldı.");

        //
        //string str;
        //int counter = 0, length = 0;
        //do
        //{
        //    Console.Write("Şifre : ");
        //    str = Console.ReadLine();
        //    length = str.Length;
        //    counter++;

        //} while (str != "12345");
        //Console.WriteLine();
        //Console.WriteLine("Deneme Sayısı : " + counter);
        //Console.WriteLine("Şifre Uzunluk : " + length);
        //Console.WriteLine("Döngüden çıkıldı.");

        //
        //string str;
        //int counter = 0, length = 0, pwd_length_err = 0;
        //do
        //{
        //    Console.Write("Şifre : ");
        //    str = Console.ReadLine();
        //    length = str.Length;
        //    // pwd 5-15 karakter arasında olabilir.
        //    // 5-15 karakter arasında olmayan şifre denemelerini topla-kaydet.
        //    if (length < 5 || length > 15)
        //        pwd_length_err++;
        //    if (pwd_length_err > 3)
        //        Console.WriteLine("IP'niz geçici olarak banlandı. Lütfen Jafer'e ulaşınız!");
        //        //break;
        //    counter++;

        //} while (str != "12345");
        //Console.WriteLine();
        //Console.WriteLine("Deneme Sayısı : " + counter);
        //Console.WriteLine("Şifre Uzunluk : " + length);
        //Console.WriteLine("Şifre Deneme Hatası : " + (counter - 1));
        //Console.WriteLine("Şifre Uzunluk Hatası : " + pwd_length_err);
        //Console.WriteLine("Döngüden çıkıldı.");

        //
        //string pwd, pwd_db = "12345", msg = string.Empty;
        //int counter = 0, length = 0, pwd_length_err = 0;
        //bool isValid = false;
        //do
        //{
        //    Console.Write("Şifre : ");
        //    pwd = Console.ReadLine();
        //    length = pwd.Length;
        //    // pwd 5-15 karakter arasında olabilir.
        //    // 5-15 karakter arasında olmayan şifre denemelerini topla-kaydet.
        //    if (length < 5 || length > 15)
        //        pwd_length_err++;
        //    if (pwd_length_err > 3)
        //    {
        //        Console.WriteLine("IP'niz geçici olarak banlandı. Lütfen Jafer'e ulaşınız!");
        //        break;
        //    }
        //    if (pwd == pwd_db)
        //    {
        //        isValid = true;
        //    }
        //    counter++;

        //} while (pwd != pwd_db);
        //Console.WriteLine();
        //Console.WriteLine("**************");
        //msg = isValid ? "başarılı" : "başarısız";
        //Console.WriteLine("Giriş " + msg + "!");
        //Console.WriteLine("**************");
        //Console.WriteLine("Deneme Sayısı : " + counter);
        //Console.WriteLine("Şifre Uzunluk : " + length);
        //Console.WriteLine("Şifre Deneme Hatası : " + (counter - 1));
        //Console.WriteLine("Şifre Uzunluk Hatası : " + pwd_length_err);
        //Console.WriteLine("Döngüden çıkıldı.");

        #endregion

        #region Break - Continue

        // Continue
        //for (int i = 0; i <= 10; i++)
        //{
        //    if (i < 9)
        //    {
        //        continue;
        //    }
        //    Console.WriteLine(i);
        //}
        //Console.WriteLine("Döngü bitti.");

        // 
        //for (; ; )
        //{
        //    Console.Write("Bir sayı girin: ");
        //    int sayi = Convert.ToInt32(Console.ReadLine());

        //    if (sayi == 0)
        //        break;

        //    if (sayi == 5)
        //    {
        //        Console.WriteLine("Sayı değeri 5");
        //        continue;
        //    }
        //}
        //Console.WriteLine("Döngü bitti.");

        #endregion

        #region Foreach

        //int[] dizi = { 1, 2, 3, 4, 5, 6, 7 };
        //foreach (var sayi in dizi)
        //{
        //    Console.WriteLine(sayi);
        //}

    #endregion
}
}
