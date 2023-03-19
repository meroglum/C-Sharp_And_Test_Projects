using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace _2023._01._06_exercise
{
    class XMLDocumnet
    {   
        ///TODO dinamik yapmalisin. Sabit veriler kod içine yazilmaz.
        private readonly string xmlDocPath = "C:/Users/Z004PUCE/OneDrive - Siemens AG/" +
            "Desktop/Notlar/project files/xmlStudentData.xml"; //Dosya yolunu tutar.
        
        /// <summary>
        /// Yeni ogrenci eklemek için kullanılır.
        /// </summary>
        public void AddStudent()
        {
            int i = 0;
            for(; ; )
            {
                Console.WriteLine("---Yeni Öğrenci girişi---");
                Console.Write("Ad: ");
                string ad = Console.ReadLine();
                Console.Write("Soyad: ");
                string soyad = Console.ReadLine();
                Console.Write("Öğenci No: ");
                int studentID = 0;
                try
                {
                   studentID = int.Parse(Console.ReadLine());
                }
                catch (Exception e) 
                {
                    Console.WriteLine(e);
                }
                Console.Write("Bölüm: ");
                string department = Console.ReadLine();
                Console.Write("Yeni Öğrenci eklemek istiyor musunuz? 1: Evet, 2: Hayır");
                int selection = int.Parse(Console.ReadLine());
                SaveStudentData(studentID,ad,soyad,department,i);
                i++;
                if (selection == 2)
                    break;
            }
        }

        /// <summary>
        /// Eklenen ogrenciyi kaydetmek için kullanılır
        /// </summary>
        /// <param name="studentID"></param>
        /// <param name="ad"></param>
        /// <param name="soyad"></param>
        /// <param name="department"></param>
        /// <param name="howManyStudentsIsSaved"></param>
        public void SaveStudentData(
            int studentID,
            string ad,
            string soyad,
            string department,
            int howManyStudentsIsSaved
            )
        {
            XDocument document = new XDocument
        (
            new XDeclaration("1.0", "utf-8", "yes"),
            new XComment("XML ogrenci verileri"),

            new XElement("ogrenciler",
                new XElement("ogrenci",
                    new XElement("Ad", ad),
                    new XElement("Soyad", soyad),
                    new XElement("Bolum", department)
                    )));
                document.Save(xmlDocPath);
            Console.WriteLine("Öğrenci Bilgileri Kaydedildi");
            Console.WriteLine(Environment.NewLine);
        }

        /// <summary>
        /// Kayıtlı XML dosyasını görüntülemel için
        /// </summary>
        public void LoadDocument()
        {
            XDocument loadedDocument = XDocument.Load(xmlDocPath);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("**********XML Dosyasindaki veri **********");
            Console.WriteLine(loadedDocument); //XML dosyasini yukle
        }
    }
}
