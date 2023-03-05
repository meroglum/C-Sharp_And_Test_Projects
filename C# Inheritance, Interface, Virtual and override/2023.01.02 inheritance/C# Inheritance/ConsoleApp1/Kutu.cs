using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Kutu
    {
        // Field (Alan)
        private double uzunluk;
        private double genislik;
        private double yukseklik;
        private Guid guid;

        // Constructor (Yapıcı Method)
        public Kutu()   // Boş constructor
        {
            //Console.WriteLine("Sınıf kuruldu.");
            guid = Guid.NewGuid();
        }

        // Constructor Overload
        public Kutu(double uzunluk, double genislik, double yukseklik)
        {
            this.uzunluk = uzunluk;
            this.genislik = genislik;
            this.yukseklik = yukseklik;
        }

        // Destructor (Yıkıcı Method)
        ~Kutu()
        {
            // Araştır
                // GC - Garbage Collector
                // Memory Management
        }

        // Encapsulation (Kapsülleme)

        // Yöntem 1 : Getter & Setter
        // Yöntem 2 : Properties

        #region Getter & Setter Methods

        public double GetUzunluk()  // Getter
        {
            return uzunluk;
        }

        public void SetUzunluk(double uzunluk)
        {
            if (uzunluk >= 2)
            {
                // Name Hiding
                this.uzunluk = uzunluk;
            }
            else
            {
                this.uzunluk = 0;
            }
        }

        #endregion

        #region Property

        public double Genislik
        {
            get { return genislik; }
            set { genislik = value; }
        }

        //public double Genislik
        //{
        //    get
        //    {
        //        return genislik;
        //    }
        //    set
        //    {
        //        genislik = value;
        //    }
        //}

        //public double Genislik
        //{
        //    get
        //    {
        //        return genislik;
        //    }
        //    set
        //    {
        //        if (value >= 2)
        //        {
        //            genislik = value;
        //        }
        //        else
        //        {
        //            genislik = 0;
        //        }
        //    }
        //}

        #endregion

        // Get My Guid

        public void GetMyGuid()
        {
            guid = Guid.NewGuid();
            Console.WriteLine(guid.ToString());
        }
    }
}
