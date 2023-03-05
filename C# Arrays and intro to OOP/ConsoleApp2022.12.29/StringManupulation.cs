using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2022._12._29
{
    /// <summary>
    // Lecture notes.
    /// </summary>
    class StringManupulation
    {
        /// <summary>
        /// Tek Satırda İstediğimiz Kadar Yazı veya Karakter Yazmak
        /// Aşağıdaki kodda ben 50 defa yan yana çizgi yazdırmak için
        /// gerekli kodları yazdım istediğinize göre siz değiştirebilirsiniz.
        /// </summary>
        public static void WriteRequiredNumberOfCharOnSingleLine()
        {
            string cizgiEkle = new string('-', 50);
            Console.WriteLine(cizgiEkle.ToString());
        }

        /// <summary>
        /// Length : String ifadenin uzunluğunu bulmak için kullanılır. 
        /// </summary>
        public static void GetLengthOfTheString()
        {
            string yazi1 = "CihanOzhan.Com";
            Console.WriteLine(yazi1.Length);
        }

        /// <summary>
        /// Remove : String ifadeden belirtilen karakterleri silmek için kullanırız.
        /// </summary>
        public static void RemoveCharsFromString()
        {
            string yazi2 = "CihanOzhan.Com";
            string SilinmisYazi = yazi2.Remove(9, 4);
            Console.WriteLine(SilinmisYazi.ToString());
        }

        /// <summary>
        /// Replace : Herhangi bir karakteri istediğimiz karaktere çevirebiliyoruz.
        /// </summary>
        public static void ReplaceCharsOfString()
        {
            string kelime = "CihanOzhan.com";
            Console.WriteLine(kelime.Replace('a', 'A'));
            // Diğer kullanımı aşağıda
            string kelime2 = "CihanOzhan.Com";
            Console.WriteLine(kelime2.Replace("Atakan", "Atkn"));
            // Bir başka kullanım
            string kelime3 = "CihanOzhan";
            Console.WriteLine(kelime2.Replace("Com", String.Empty));
            // String.Empty silmeye yarar ve diğer kullanımı şu şekildedir : ""
            // Yani Com olan kısmı bu kodla siliyoruz
        }

        /// <summary>
        /// SubString : String içerisinde belli bir karakterden sonraki bölümü seçmemiz yarar.
        /// </summary>
        public static void StringSubstringing()
        {
            // İlk Kullanımı
            string isim1 = "Cihan Özhan"; //Burada "A" 0.karakterdir. Bunu unutmamak gerekiyor
            Console.WriteLine(isim1.Substring(12, 6)); //Ekran çıktısı olarak "Uludağ" ı verecektir. 12.karakterden başlayarak 6 adet karakteri alır.

            //İkinci Kullanımı
            string isim2 = "Cihan Özhan";
            Console.WriteLine(isim2.Substring(12)); //Ekran çıktısı olarak "Uludağ" yı verecektir. 12.karakterden başlayarak son karaktere kadar seçim yapar.
        }

        /// <summary>
        /// ToCharArray : String içeriğini karaktere ayırır. 2 türlü kullanımı vardır.
        /// </summary>
        public static void StringToCharArray()
        {
            string kelime = "CihanOzhan.com";
            // İlk Kullanım
            char[] karakterler = kelime.ToCharArray(); // Anahtar bölüm işte burası, burada karakterler adında char türünde bir dizi oluşturuluyor ve içerisine atılıyor. Yani aşağıdaki foreach yerine karakterler[sayi] diyerek ulaşabilirsiniz.
            foreach (char karakter in karakterler) // Foreach bu tarz işlemler için tam anlamıyla biçilmiş kaftandır. Örnekte iyi olacağını düşünüyorum
            {
                //listBox1.Items.Add(karakter); // Bu bölümde bulunan karakterleri listbox1 a sırayla ekliyor. Yani ekran çıktısı olarak sırasıyla alt alta;M,A,H,M,U,T, ,C,A,N, ,S,Ö,Z,E,R,İ dir. Boşluklarında dahil olduğunu unutmayalım. Burada bir if kontrolü ile boşlukları eklemeyebiliriz.
            }

            //İkinci Kullanım
            //char[] karakterler = kelime.ToCharArray(3, 5); //SubStringteki mantık ile çalışır yani 3.index numarasından başlar ve daha sonraki 5 karakteri alır.
        }

        /// <summary>
        ///  Trim : String ifadede ki boşlukları silmeye yarar.
        /// </summary>
        public static void TrimTheString()
        {
            // İlk Kullanımı
            string adSoyad = "   Cihan Özhan    ";
            Console.WriteLine(adSoyad.Trim()); //Çıktı olarak boşluksuz şekilde "Atakan Yasin Uludağ" yazacaktır. Kısaca ifadede ki boşlukları kaldırır.

            // İkinci Kullanım (TrimStart)
            string adSoyad2 = "   Cihan Özhan  ";
            Console.WriteLine(adSoyad2.TrimStart()); // TrimStart'da ise string ifadenin başındaki boşluğu kaldırır sonlarındaki boşlukları kaldırmaz. Çıktı olarak "Atakan Yasin Uludağ  " yazacaktır. (Sonunda boşluk olacak şekilde)

            // Üçüncü Kullanım (TrimEnd)
            string adSoyad3 = "  Cihan Özhan     ";
            Console.WriteLine(adSoyad3.TrimEnd()); // TrimEnd'da string ifadenin sonundaki boşluğu kaldırır başındaki boşlukları kaldırmaz. Çıktı olarak "  Atakan Yasin Uludağ" yazacaktır. (Başında boşluk olacak şekilde).
        }

        /// <summary>
        /// StartWidth & EndsWidth : String ifadenin başında(StartWidth) ya da sonunda(EndWidth)
        /// istediğimiz karakterle bitip bitmediğini kontrol edebiliriz.
        /// </summary>
        public static void startAndEndWith()
        {
            // İlk Kullanım
            string txt = "";    // textBox1.Text;
            string yazi = "Atkn";
            if (txt.StartsWith(yazi))
            {
                Console.WriteLine("Cümle Atkn ile başlıyor.");
            }
            else
            {
                Console.WriteLine("Cümle Atkn ile başlamıyor.");
            }

            // İkinci Kullanım
            string txt1 = "";    // textBox1.Text;
            string yazi11 = "Atkn";
            if (txt1.EndsWith(yazi11))
            {
                Console.WriteLine("Cümle Atkn ile bitiyor..");
            }
            else
            {
                Console.WriteLine("Cümle Atkn ile bitmiyor.");
            }
        }

        /// <summary>
        /// ToUpper : String ifadede ki tüm karakterleri büyük harfe çevirir.
        /// </summary>
        public static void StringToUpper()
        {
            string isim3 = "atakan yasin uludağ";
            Console.WriteLine(isim3.ToUpper()); //Çıktı olarak "ATAKAN YASİN ULUDAĞ" yazar.
        }

        /// <summary>
        /// ToLower : String ifadede ki tüm karakterleri küçük harfe çevirir.
        /// </summary>
        public static void StringToLower()
        {
            string isim4 = "CİHAN ÖZHAN";
            Console.WriteLine(isim4.ToLower()); //Çıktı olarak "atakan yasin uludağ" yazar.
        }

        /// <summary>
        /// Another important function which is used in string manipulation is the Insert function. 
        /// This function is used to insert string inside another string,
        /// starting from the specified index.Have a look at the example.
        /// </summary>
        public static void StringInsert()
        {
            string name = "Expert";
            string sub = name.Insert(2, "--");
            Console.WriteLine("İnserted String : " + sub);
        }

        /// <summary>
        /// PadLeft and PadRight.
        /// </summary>
        public static void StringPadding()
        {
            string name = "Expert";
            string sub = name.PadRight(5, '*');
            Console.WriteLine("String with padding: " + sub);
        }

        /// <summary>
        /// Split method is used to split the strings.
        /// By default, it uses whitespaces as the parameter to split strings.
        /// Have a look at the following example
        /// </summary>
        public static void StringSplitting()
        {
            string content = "I am a CSharp Expert";
            string[] str = content.Split();
            Console.WriteLine("Splitted string array: " + str);
        }

        /// <summary>
        /// The Join function does exactly opposite of Split function. 
        /// Join function takes a delimiting character and array of strings
        /// as an input and then join the words to form a string.
        /// Have a look at the following example.
        /// </summary>
        public static void StringJoining()
        {
            string[] str = "I am a CSharp Expert".Split(' ');
            string content = string.Join(",", str);
            Console.WriteLine("Joined string array : " + content);
        }

        /// <summary>
        /// Concat is a static string method. It is similar to Join in functionality
        /// but It doesn’t take any delimiting character as a parameter.
        /// Its functionality is as follows
        /// </summary>
        public static void StringConcat()
        {
            string name = string.Concat("I ", "am ", " a", " CSharp", " Expert");
            // Plus operator “+” is also used to Join strings in a similar manner as illustrated by the following code snippet.
            string name2 = "I " + "am " + " a" + " CSharp" + " Expert";
            Console.WriteLine("String with concat : " + name);
            Console.WriteLine("String with + operator: " + name2);

        }

    }
}
