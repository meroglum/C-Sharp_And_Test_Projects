// See https://aka.ms/new-console-template for more information
using System;
using System.Security.Cryptography;
using System.Text;

class Program
{
    static void Main(String[] args)
    {
        int abc;
        int yas = 29;
        int değer = 2147483547;
        int a, b, c;
        //int a = 1, b = 2, c = 3;

        int x = new int();
        Console.WriteLine(x); ///Defalut int value is 0
                              ///If it would be bool the default value is false

        int? y; ///It is nullable, can be used when collecting data from database

        /// y = getData();
       
        ///Teknik olarak ayırmak için sonuna karakter koyuluyor
        double d1 = 1.20; //Double için souna karakter koymaya gerek yok
        float f1 = 2.1F; //Float için F
        decimal dec1 = 4.3M; //decimal için souna M koyulmalı 

        float ff1;
        ff1 = 2.3F;

        char ch = 'A'; //Tek tırnak olmalı çift tırnak String için kullanılır
        char ch1 = (char)54;
        Console.WriteLine(ch1);
        String adx = "Muhammed";

        /// Kod çok kalabalık olduğu zaman region kullanılabilir 
        #region önemli
        //CTRL+K+C yorum satırına alır
        ///açıklamalar
        //Console.Write(ch);
        //Console.Write(ch);
        //Console.Write(ch);
        //Console.Write(ch);
        //Console.Write(ch);
        #endregion

        #region önemli2
        //CTRL+K+C yorum satırına alır
        ///açıklamalar
        //Console.Write(ch);
        //Console.Write(ch);
        //Console.Write(ch);
        //Console.Write(ch);
        //Console.Write(ch);
        #endregion

        #region önemli3
        //CTRL+K+C yorum satırına alır
        ///açıklamalar
        //Console.Write(ch);
        //Console.Write(ch);
        //Console.Write(ch);
        //Console.Write(ch);
        //Console.Write(ch);
        #endregion

        int abc1 = 0;
        double abc2 = new double();
        bool abc3 = default(bool); ///bool tipinin defult değerini değişken olarak atar
        System.Int64 xxx = 3321231223131231312; ///32 bit int değeri yetersiz geldiğinde kullan
        int abc4 = default(int);///gets the defult int

        #region bir dairenin alanını hesaplama
        double radius;
        double area;
        radius = 10.0;
        area = radius * radius * 3.1418;
        Console.WriteLine("Alan : " +area);

        ///aynı kod çok daha kısa şekilde yapılabilir
        double radius2 = 10.0; double area2 = radius2 * radius2 * 3.1418;
        Console.WriteLine("Kısa kodala hesaplanmış Alan : " +area2);
        #endregion

        #region Hesaplama
        decimal amount;
        decimal rate_of_return;
        int years;
        amount = 1000.0m;
        rate_of_return = 0.07m;
        years = 10;
        Console.WriteLine("Original Investment: $" + amount);
        Console.WriteLine("Rate of return : " +rate_of_return);
        Console.WriteLine("Over " + years+" years");
        #endregion

        #region indirimli fiyat hesaplama
        decimal price, discount, discounted_price;
        ///Indirimli fiyat hesapla
        price = 19.95m;
        discount = 0.15m;
        discounted_price = price - (price * discount); ///indirimi hesapla
        Console.WriteLine("Discounted Price : $"+discounted_price);
        #endregion

        static decimal IndirimHesapla(decimal price, decimal discount)
        {
            if(price >0 && discount > 0)
            {
                return price - (price * discount);
            }
            return 0; ///Hata fırlatma kullanılabilir
        }

        #region String manupülasyon
        String ad, soyad, email, fb_profil, sonuc, ayirac = "********";
        ad = "Muhammed";
        soyad = "EROĞLU";
        email = "muhammedf.eroglu@gmail.com";
        fb_profil = "Yok";

        // Metin Birleştirme (String Concat)

        sonuc = ayirac + "\n" +
            "Ad : " + ad + "\n" +
            "Soyad : " + soyad + "\n" +
            "Email : " + email + "\n" +
            "Facebook : " + fb_profil + "\n" +
            ayirac;

        Console.WriteLine(sonuc);


        ///Bunu yapmanın diğer yolu ise String builder kullanmak
        ///String builder ile performans daha iyi olur 
        ///yukarıdaki karmaşık ve ayrıca yukarıdaki durum performans düşüklüğüne 
        ///neden olur 
        ///String builder performansı çok fazla yükseltir
        ///string sayısı arttıkça preformans farkı gözle görülür olur
        StringBuilder builder = new StringBuilder();
        builder.Append("Ad : " + ad);
        builder.Append(Environment.NewLine);
        builder.Append("Soyad : ");
        builder.Append(soyad);
        Console.WriteLine(builder.ToString());
        #endregion

        #region input alma
        Console.Write("Ad :");
        ad = Console.ReadLine();
        Console.Write("Soyad :");
        soyad = Console.ReadLine();
        Console.Write("E mail :");
        email = Console.ReadLine();
        Console.Write("facebook :");
        fb_profil = Console.ReadLine();
       

        // Metin Birleştirme (String Concat)

        sonuc = ayirac + "\n" +
            "Ad : " + ad + "\n" +
            "Soyad : " + soyad + "\n" +
            "Email : " + email + "\n" +
            "Facebook : " + fb_profil + "\n" +
            ayirac;

        Console.WriteLine(sonuc);
        String s2 = String.Empty;


        #endregion

        // Alt satıra inme
        // "\n"
        // environment variable
        // ASCI alt satıra inme karakteri

        #region nullable types
        int? num = null;
        double? numberdouble = null;
        bool? cinsiyet = null;

        //Eğer var anahtar kelimesi kullanarak bir değişken oluşturmak
        //isteniyor ve değeri belli değilse, aşağıdaki gibi tanımlanabilir.
        var isimX = (string)null;

        #endregion

        #region daire çevre ve alan
        // pi sayısını tanımlayalım
        const double pi = 3.14159;

        //Değişkenleri tanımlayalım
        double alan, cevre, yaricap;
        String yaricapGir;
        Console.WriteLine("Dairenin yarıçapını giriniz");
        yaricapGir = Console.ReadLine();
        yaricap = Convert.ToDouble(yaricapGir);
        cevre = 2 * pi * yaricap;
        alan = pi * Math.Pow(yaricap, 2);
        Console.WriteLine("Dairenin alanı = {0}",alan); //{0} is placeholder
        Console.WriteLine("Dairenin çevresi = {0}",cevre); //{0} is placeholder
        Console.ReadKey(); ///Konsol hemen kapanmasın diye
        #endregion

        #region TÜR DÖNÜŞÜMÜ
        //Tür dönüşümü: Bilinçli ve bilinçsiz kavramları
        //Tür dönüşümü: Type Casting
        //Tür dönüşümü: Convert sınıfı ile tür dönüşümü
        //Tür dönüşümü: (cast,convert,parse)

        //büyükten küçüğe

        double d = 12.3;
        Console.WriteLine(d);
        int i = Convert.ToInt32(d);
        Console.WriteLine(i);

        //küçükten büyüğe
        int i1 = 123456789;
        double d12 = 123456789.1;
        d12 = i1;

        ///Arada yazamadıklarım var onları fotoğraftan geçir

        public enum dayOfTheWeek
    {
        Sunday = 0,
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
    Saturday = 6,
    }
        #endregion

        #region Kapsayıcı

        #endregion

        #region var kullanımı

        #endregion

        #region obj ve var

        #endregion

        #region obj ve var

        #endregion
    }
}
 
