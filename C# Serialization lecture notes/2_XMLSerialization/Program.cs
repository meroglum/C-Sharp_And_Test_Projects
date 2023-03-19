using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _1_XMLSerialization
{
    /// <summary>
    /// This is the lecture notes.
    /// </summary>
    // http://www.csharpstar.com/serialize-and-deserialize-data-csharp/
    class Program
    {
        static void Main(string[] args)
        {
            // XML Serialization'da private, grafik ve dosyalar serialize edilmez.

            #region Serialization Basic

            // XML Serialization İşlemi

            //string data = "Cihan Özhan / cihanozhan.com";
            //FileStream stream = new FileStream("XMLSerializaed.xml", FileMode.Create);
            //XmlSerializer xs = new XmlSerializer(typeof(string));
            //xs.Serialize(stream, data);
            //stream.Close();

            // XML Deserialization İşlemi

            //FileStream stream = new FileStream("XMLSerializaed.xml", FileMode.Open);
            //XmlSerializer xs = new XmlSerializer(typeof(string));
            //string data = (string)xs.Deserialize(stream);
            //stream.Close();
            //Console.WriteLine("Sonuç : " + data);

            //using (FileStream stream = new FileStream("XMLSerializaed.xml", FileMode.Open))
            //{
            //    XmlSerializer xs = new XmlSerializer(typeof(string));
            //    string data = (string)xs.Deserialize(stream);
            //    //stream.Close();
            //}

            #endregion

            #region Örnek : User

            //User user = new User(2, "Cihan", "Özhan", "CO", "cihan.ozhan@hotmail.com", "1234", 1200);
            //XmlSerializer xs = new XmlSerializer(typeof(User));
            //FileStream stream = new FileStream("User.XML", FileMode.Create);
            //xs.Serialize(stream, user);
            //stream.Close();

            #endregion

            #region Örnek : domains

            //List<string> domains = new List<string>();
            //domains.Add("http://wwww.cihanozhan.com");
            //domains.Add("http://wwww.google.com");
            //domains.Add("http://wwww.microsoft.com");

            //Serialize(domains);

            #endregion

            #region Örnek : Kullanıcı

            Kullanici kul = new Kullanici(2, "CO", "cihan@ozhan.com");
            XmlSerializer xs = new XmlSerializer(typeof(Kullanici));
            FileStream stream = new FileStream("Kullanici.XML", FileMode.Create);
            xs.Serialize(stream, kul);
            stream.Close();

            #endregion
            
            #region Örnek 2

            XmlSerializer serializer = new XmlSerializer(typeof(Person));
            string xml;
            using (StringWriter stringWriter = new StringWriter())
            {
                Person p = new Person
                {
                    FirstName = "Steve",
                    LastName = "Smith",
                    Age = 51
                };
                serializer.Serialize(stringWriter, p);
                xml = stringWriter.ToString();
            }
            Console.WriteLine(xml);
            using (StringReader stringReader = new StringReader(xml))
            {
                Person p = (Person)serializer.Deserialize(stringReader);
                Console.WriteLine("{0} {1} is {2} years old", p.FirstName, p.LastName, p.Age);
            }

            #endregion

            //Console.ReadLine();

        }

        // Örnek : domains
        static void Serialize(List<string> data)
        {
            FileStream stream = new FileStream("domains.xml", FileMode.Create);
            XmlSerializer xs = new XmlSerializer(typeof(List<string>));
            xs.Serialize(stream, data);
            stream.Close();
        }

        // Örnek : domains
        static List<string> Deserialize()
        {
            FileStream stream = new FileStream("domains.xml", FileMode.Create);
            XmlSerializer xs = new XmlSerializer(typeof(List<string>));
            List<string> liste = (List<string>)xs.Deserialize(stream);
            stream.Close();
            return liste;
        }
        
    }

    // Örnek 2
    [Serializable]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
