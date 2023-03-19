using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_SoapSerialization
{   
    /// <summary>
    /// This is the lecture note.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Serialize();

            Hashtable h = Deserialize();

            foreach (DictionaryEntry item in h)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }


            Console.ReadLine();
        }

        static void Serialize()
        {
            Hashtable adres = new Hashtable();
            adres.Add("Ali", "İstanbul");
            adres.Add("Veli", "Angara");

            SoapFormatter formatter = new SoapFormatter();
            try
            {
                using (FileStream fs = new FileStream("veri.soap", FileMode.Create))
                {
                    formatter.Serialize(fs, adres);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Hata : " + ex.Message);
            }
        }

        static Hashtable Deserialize()
        {
            Hashtable veri = null;
            SoapFormatter formatter = new SoapFormatter();
            try
            {
                FileStream fs = new FileStream("veri.soap", FileMode.Open);
                veri = (Hashtable)formatter.Deserialize(fs);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return veri;
        }
    }
}
