using System;
using System.Diagnostics;
using System.Text;

/// <summary>
/// Muhammed EROGLU C# Notes
/// </summary>
class Program
{
    public static void Main(string[] args)
    {
        /*
            
                +          Toplama
                -          Çıkarma
                *          Çarpma
                /          Bölme
                %          Bölümden Kalan
                ++         Arttırma
                --         Eksiltme

                + , ‐ , * , /, ++ , -- ve % aritmetik  operatörlerdir.
                /, *, + ve – operatörleri matematiksel işlemler yapar.
                % operatörü ise bölümden sonra kalanı bulmak yani "mod" almak için kullanılır.
                ++ ve -- işlemin uygulandığı sayıyı 1 arttırır veya 1 azaltır.
                *, /, % operatörleri aynı satırdaysa eşit önceliğe sahiptir. + ve – operatörleri de aynı satırdaysa eşit önceliklidir fakat  *, /, % operatörlerinin + ve – operatörlerine göre önceliği vardır.
     */
       
        int x = 100;
        int y = 5;

        Console.WriteLine("x + y = {0}", x + y);
        Console.WriteLine("x - y = {0}", x - y);
        Console.WriteLine("x * y = {0}", x * y);
        Console.WriteLine("x / y = {0}", x / y);

        int toplam = 0, fark = 0, carpim = 0, modulo = 0;
        float bolum = 0; //0f de yazılabilir
        int sayi1 = 10, sayi2 = 2;
        toplam = sayi1 + sayi2;
        fark = sayi1 + sayi2;
        carpim = sayi1 * sayi2;
        bolum = sayi1 / sayi2;
        modulo = 3 % sayi2;         //  3/2 nin kalanı (1)

        Console.WriteLine("sayı1 = {0}, sayı2 = {1}", sayi1, sayi2);
        Console.WriteLine(); // Komsolda satır boşluğu bırakmak için kullanılır.
        Console.WriteLine("{0} + {1} = {2}", sayi1, sayi2, toplam); // {1} : sayi2 indexe göre yazdır.
        Console.WriteLine("{0} - {1} = {2}", sayi1, sayi2, fark);
        Console.WriteLine("{0} * {1} = {2}", sayi1, sayi2, carpim);
        Console.WriteLine("{0} / {1} = {2}", sayi1, sayi2, bolum);
        Console.WriteLine();
        Console.WriteLine("3 sayısı {0} ile bölününce {1} kalır.", sayi2, modulo);

        /*
            Çok Boyutlu Dizi Türleri
                - Düzenli Çok Boyutlu Diziler
                    - İki Boyutlu Diziler
                    - Üç Boyutlu Diziler
                - Düzensiz (Jagged) Çok Boyutlu Diziler
            https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/multidimensional-arrays
            https://www.w3schools.com/cs/cs_arrays_multi.php
         */

        //int x = 100;
        //        int y = 5;

        //        Console.WriteLine("x + y = {0}", x + y);
        //        Console.WriteLine("x - y = {0}", x - y);
        //        Console.WriteLine("x * y = {0}", x * y);
        //        Console.WriteLine("x / y = {0}", x / y);

        //int toplam = 0, fark = 0, carpim = 0, modulo = 0;
        //        float bolum = 0;
        //        int sayi1 = 10, sayi2 = 2;
        //        toplam = sayi1 + sayi2;
        //        fark = sayi1 + sayi2;
        //        carpim = sayi1 * sayi2;
        //        bolum = sayi1 / sayi2;
        //        modulo = 3 % sayi2;         //  3/2 nin kalanı

        //        Console.WriteLine("sayı1 = {0}, sayı2 = {1}", sayi1, sayi2);
        //        Console.WriteLine();
        //        Console.WriteLine("{0} + {1} = {2}", sayi1, sayi2, toplam);
        //        Console.WriteLine("{0} - {1} = {2}", sayi1, sayi2, fark);
        //        Console.WriteLine("{0} * {1} = {2}", sayi1, sayi2, carpim);
        //        Console.WriteLine("{0} / {1} = {2}", sayi1, sayi2, bolum);
        //        Console.WriteLine();
        //        Console.WriteLine("3 sayısı {0} ile bölününce {1} kalır.", sayi2, modulo);

        // ++  ve  --

        //int x = 1;
        //Console.WriteLine(x++);
        //Console.WriteLine(++x);

        //int xx = 1;
        //xx = xx + 1;
        //xx += 1;
        //x++;

        //int x = 100;
        //        int y = 5;
        
        //  Console.WriteLine("x + y = {0}", x + y);
        //  Console.WriteLine("x - y = {0}", x - y);
        //  Console.WriteLine("x * y = {0}", x * y);
        //  Console.WriteLine("x / y = {0}", x / y);

      
        //int toplam = 0, fark = 0, carpim = 0, modulo = 0;
        //  float bolum = 0;
        //  int sayi1 = 10, sayi2 = 2;
        //  toplam = sayi1 + sayi2;
        //  fark = sayi1 + sayi2;
        //  carpim = sayi1 * sayi2;
        //  bolum = sayi1 / sayi2;
        //  modulo = 3 % sayi2;         //  3/2 nin kalanı

        Console.WriteLine("sayı1 = {0}, sayı2 = {1}", sayi1, sayi2);
        Console.WriteLine();
        Console.WriteLine("{0} + {1} = {2}", sayi1, sayi2, toplam);
        Console.WriteLine("{0} - {1} = {2}", sayi1, sayi2, fark);
        Console.WriteLine("{0} * {1} = {2}", sayi1, sayi2, carpim);
        Console.WriteLine("{0} / {1} = {2}", sayi1, sayi2, bolum);
        Console.WriteLine();
        Console.WriteLine("3 sayısı {0} ile bölününce {1} kalır.", sayi2, modulo);


        // ++  ve  --

        //int x = 1;
        //Console.WriteLine(x++);
        //Console.WriteLine(++x);

        //int xx = 1;
        //xx = xx + 1;
        //xx += 1;
        //x++;

         /*
         == Operatörü    : Eşittir anlamındadır.
         != Operatörü    : Eşit değil (farklı) anlamındadır.
         > Operatörü     : Büyüktür anlamındadır.Bu operatör string işlemlere uygulanmaz.
         < Operatörü     : Küçüktür anlamındadır.Bu operatör string işlemlere uygulanmaz.
         >= Operatörü    : Büyük veya eşit anlamındadır. Bu operatör string işlemlere uygulanmaz.
         <= Operatörü    : Küçük veya eşit anlamındadır.Bu operatör string işlemlere uygulanmaz.
         */

        /*
        (veya) operatörü      iki değerden birisi doğru ise doğru, ikisi de yanlış ise yanlış değerini döndürür ayrıca önceliği en az olan mantıksal operatördür.
        &&(ve) operatörü        iki değerin ikisi de doğru ise doğru, en az birisi yanlış ise yanlış değerini döndürür.
        &&(ve), (veya) operatörleri aritmetik, karşılaştırma ve bitsel operatörlere göre düşük önceliklidir fakat kendi aralarındaki öncelik sıralaması &&(ve), ||(veya) şeklindedir.
        !(değil) operatörü      aritmetik operatörlerden (++)arttırma ve (--)eksiltme operatörleri ile eşit önceliklidir.
        */

   
        //int x = 100;
        //        int y = 5;
        
        //  Console.WriteLine("x + y = {0}", x + y);
        //  Console.WriteLine("x - y = {0}", x - y);
        //  Console.WriteLine("x * y = {0}", x * y);
        //  Console.WriteLine("x / y = {0}", x / y);


        //int toplam = 0, fark = 0, carpim = 0, modulo = 0;
        //  float bolum = 0;
        //  int sayi1 = 10, sayi2 = 2;
        //  toplam = sayi1 + sayi2;
        //  fark = sayi1 + sayi2;
        //  carpim = sayi1 * sayi2;
        //  bolum = sayi1 / sayi2;
        //  modulo = 3 % sayi2;         //  3/2 nin kalanı

        Console.WriteLine("sayı1 = {0}, sayı2 = {1}", sayi1, sayi2);
        Console.WriteLine();
        Console.WriteLine("{0} + {1} = {2}", sayi1, sayi2, toplam);
        Console.WriteLine("{0} - {1} = {2}", sayi1, sayi2, fark);
        Console.WriteLine("{0} * {1} = {2}", sayi1, sayi2, carpim);
        Console.WriteLine("{0} / {1} = {2}", sayi1, sayi2, bolum);
        Console.WriteLine();
        Console.WriteLine("3 sayısı {0} ile bölününce {1} kalır.", sayi2, modulo);

       
        // ++  ve  --

        //int x = 1;
        //Console.WriteLine(x++);
        //Console.WriteLine(++x);

        //int xx = 1;
        //xx = xx + 1;
        //xx += 1;
        //x++;

        // Üçlü Operatör - Ternary Operator

        // operand1 ? operand2 : operand2

        string mesaj = string.Empty;
        bool aktifMi = true;
        mesaj = aktifMi ? "Evet" : "Hayır";
        //mesaj = aktifMi ? function1() : function2();
        Console.WriteLine("Aktif mi : " + mesaj);

        // Bitsel operatörler

        /*
            Bitsel operatörler &(bitsel ve), ~(bitsel değil), |(bitsel veya), ^(bitsel özel veya) operatörleridir. 
            Sayıların kendileri yerine bitlerini kullanan operatörlerdir.
            
            ~ : Tilde
            &(ve) işlemi karşılıklı basamaklardan her ikisi de 1 ise ilgili basamağında 1 tutar, diğer durumlarda 0 tutar.
            ~(değil) operatörü operandının her basamağını tersleştirip tutar.
            |(veya) işlemi karşılıklı basamaklarından herhangi birisi 1 ise ilgili basamağında 1 tutar, diğer durumlarda 0 tutar.
            ^(özel veya) işlemi karşılıklı basamakları farklıysa ilgili basamağında 1 tutar, diğer durumlarda 0 tutar.
            Bitsel operatörler aritmetik operatörler ve karşılaştırma operatörlerinden düşük önceliklidir fakat bu operatörler aynı satırda olduklarında aralarındaki öncelik sıralaması &(bitsel ve), ^ (bitsel özel veya), |(bitsel veya) şeklindedir.

            Console.WriteLine(9<<2); // 36 Olarak Ekrana Çıktı Gösterir.
            Console.WriteLine(9>>2); // 2 Olarak Ekrana Çıktı Gösterir.

            İlk örneğimiz üzerinde girdiğimiz 9 değerinin binary karşılığı 1001‘e karşılık gelir.
            Bu sayıyı 2 bit değerinde sağa kaydırdığımız zaman yeni elde edeceğimiz değer 0010 olur
            ve bu değerin karşılığı 2’ye denk gelir. Aynı şekilde işlemi 2 bit sola kaydıracağımız zaman
            ise değerimiz 100100 olur. Bu bitsel sonucun değeri de 36’ya karşılık gelmektedir.

            Açıklamadan anlaşılacağı üzere burada değerlerin kendileri değil binary karşılıkları işleme tabi tutulur.
         */

        /*
            () tür dönüştürme operatörü:    Tür değiştirmek için kullanılan bir operatördür.   (değiştirilecek tür) değişken_yada_sabit
            [] operatörü:                   Dizilerde elemanın dizinini belirtmek için kullanılır.
            + ve – operatörü:               Bir değişkenin pozitif veya negatif olmasını sağlar. Ayrıca + operatörü iki string(katar)’i birleştirmekte de kullanılır. Kullanımı şu şekildedir;
            typeof operatörü:               Herhangi bir değişken türünün CTS (Common Type System - Ortak Tip Sistemi) karşılığını type(tip) olarak tutar.
            sizeof operatörü:               Temel türlerin ve yapıların bellekte ne kadar alan kapladıklarını verir. "sizeof" operatörü sınıflar için kullanılamaz ancak tanımlanacak yapılar için kullanılabilir.
            new operatörü:                  Yeni bir nesne oluşturmak için kullanılan operatörlerdir.
         */

        #region İki Boyutlu Diziler

        //int[,] ikiBoyut;
        //int[,] ikiBoyut = new int[4,2];
        //int[,] ikiBoyut = {
        //                { 1, 2 },
        //                { 3, 4 },
        //                { 5, 6 },
        //                { 7, 8 }
        //              };

        //Console.WriteLine(ikiBoyut.Length);

        //for (int i = 0; i < 4; i++)
        //{
        //    for (int j = 0; j < 2; j++)
        //    {
        //        Console.WriteLine(ikiBoyut[i, j]);
        //    }
        //}

        //Console.WriteLine("---------------->");

        //ikiBoyut[0, 0] = 10;
        //ikiBoyut[0, 1] = 20;
        //ikiBoyut[1, 0] = 30;
        //ikiBoyut[1, 1] = 40;
        //ikiBoyut[2, 0] = 50;
        //ikiBoyut[2, 1] = 60;
        //ikiBoyut[3, 0] = 70;
        //ikiBoyut[3, 1] = 80;

        // for (int i = 0; i < 4; i++)
        // {
        //    for (int j = 0; j < 2; j++)
        //    {
        //        Console.WriteLine(ikiBoyut[i, j]);
        //    }
        // }

        #endregion

        #region Üç Boyutlu Diziler

        //int[,,] ucBoyut;
        //int[,,] ucBoyut = new int[4, 2, 2];
        //int[,,] ucBoyut = {
        //                           {{1,2},{3,4}},
        //                           {{5,6},{7,8}},
        //                           {{9,10},{11,12}},
        //                           {{13,14},{15,16}}
        //                       };

        //for (int i = 0; i < 4; i++)
        //{
        //    for (int j = 0; j < 2; j++)
        //    {
        //        for (int k = 0; k < 2; k++)
        //        {
        //            Console.WriteLine(ucBoyut[i, j, k]);
        //        }
        //    }
        //}

        //ucBoyut[0, 0, 0] = 10;
        //ucBoyut[0, 0, 1] = 20;
        //ucBoyut[0, 1, 0] = 30;
        //ucBoyut[0, 1, 1] = 40;
        //ucBoyut[1, 0, 0] = 50;
        //ucBoyut[1, 0, 1] = 60;

        #endregion

        #region Düzensiz(Jagged) Diziler

        //int[][] jagged =
        //{
        //    new int[] { 1, 2, 3, 4, 5, 6 },
        //    new int[] { 1, 2 },
        //    new int[] { 1, 2, 3, 4 },
        //    new int[] { 1 }
        //};

        //Console.WriteLine(jagged.Length);

        //foreach (var jag in jagged)
        //{
        //    foreach (var ged in jag)
        //    {
        //        Console.Write(ged);
        //    }
        //    Console.WriteLine();
        //}

        #endregion

        //  int x = 100;
        //  int y = 5;

        //  Console.WriteLine("x + y = {0}", x + y);
        //  Console.WriteLine("x - y = {0}", x - y);
        //  Console.WriteLine("x * y = {0}", x * y);
        //  Console.WriteLine("x / y = {0}", x / y);

        //  int toplam = 0, fark = 0, carpim = 0, modulo = 0;
        //  float bolum = 0;
        //  int sayi1 = 10, sayi2 = 2;
        //  toplam = sayi1 + sayi2;
        //  fark = sayi1 + sayi2;
        //  carpim = sayi1 * sayi2;
        //  bolum = sayi1 / sayi2;
        //  modulo = 3 % sayi2;         //  3/2 nin kalanı

        //  Console.WriteLine("sayı1 = {0}, sayı2 = {1}", sayi1, sayi2);
        //  Console.WriteLine();
        //  Console.WriteLine("{0} + {1} = {2}", sayi1, sayi2, toplam);
        //  Console.WriteLine("{0} - {1} = {2}", sayi1, sayi2, fark);
        //  Console.WriteLine("{0} * {1} = {2}", sayi1, sayi2, carpim);
        //  Console.WriteLine("{0} / {1} = {2}", sayi1, sayi2, bolum);
        //  Console.WriteLine();
        //  Console.WriteLine("3 sayısı {0} ile bölününce {1} kalır.", sayi2, modulo);

        //  static void Main(string[] args)
        //  {
        // Akış Kontrolü : if ve switch (switch case)
        // 1
        //   if (true)
        //    Console.WriteLine("adada");
        // 2
        //   bool isValid = true;
        //   if (isValid)
        //    Console.WriteLine("Doğru");
        //   else
        //    Console.WriteLine("Yanlış"); 
        //    Console.WriteLine("Yanlış mı");     // ?
        // 3
        //   bool isValid = true;
        //  if (isValid)
        //    Console.WriteLine("Doğru");
        //   else
        //   {
        //    Console.WriteLine("Yanlış");
        //    Console.WriteLine("Yanlış mı");
        //  }
        // 4
        //  int x = 1, y = 3;
        //  if (x > y)
        // {
        //}
        //else
        //  {
        //  }
        // 5
        //  int x = 1, y = 3;
        // if (x <= y)
        //  {
        //  }
        //  else if (x == y)
        // {
        //  }
        // else if (x >= y)
        //  {
        //  }
        //  else
        // {
        //  }
        // 6
        //  if (true)
        //  {
        // if (true)
        // {
        //  if (true)
        //  {
        //  }
        //    }
         //}
         //else
         //{
        //}
        // 7
        //int sayi1 = 8, sayi2 = 9, sonuc = 0;
        //if (sayi1 < sayi2)
        //{
        //    sayi1++;
        //    //sonuc = sayi1++;
        //    Console.WriteLine("Küçüktür.");
        //}
        //else if (sayi1 == sayi2)
        //{
        //    Console.WriteLine("Eşittir.");
        //}
        //else
        //{
        //    sonuc = sayi1 + sayi2;
        //    Console.WriteLine("Büyüktür.");
        //}
        //Console.WriteLine("Sonuç : " + sonuc);
        
        // 8

        //  byte ay = Convert.ToByte(Console.ReadLine());

        //  if (ay == 1)
        //      Console.WriteLine("Ocak");
        //  else if (ay == 2)
        //      Console.WriteLine("Şubat");
        //  else if (ay == 3)
        //      Console.WriteLine("Mart");
        //  else if (ay == 4)
        //      Console.WriteLine("Nisan");
        //  else if (ay == 5)
        //      Console.WriteLine("Mayıs");
        //  else if (ay == 6)
        //      Console.WriteLine("Haziran");
        //  else if (ay == 7)
        //      Console.WriteLine("Temmuz");
        //  else if (ay == 8)
        //      Console.WriteLine("Ağustos");
        //  else if (ay == 9)
        //      Console.WriteLine("Eylül");
        //  else if (ay == 10)
        //      Console.WriteLine("Ekim");
        //  else if (ay == 11)
        //      Console.WriteLine("Kasım");
        //  else if (ay == 12)
        //      Console.WriteLine("Aralık");
        //  else
        //      Console.WriteLine("1-12 arası sayı girmelisiniz");
        //  }
    }
}
