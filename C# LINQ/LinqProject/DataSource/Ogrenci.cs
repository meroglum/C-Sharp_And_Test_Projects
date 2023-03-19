using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._01._25LINQ
{
    public class Ogrenci:IEnumerable<Ogrenci>
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarih { get; set; }
        //public List<double> Notlar { get; set; } = new List<double>();
        public double NotOrtalaması { get; set; } = new double();
        public bool Cinsiyet { get; set; }
        List<Ogrenci> ogrenci { get; set; } = new List<Ogrenci>();


        /// <summary>
        /// To make it iterable.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<Ogrenci> GetEnumerator()
        {
            return ((IEnumerable<Ogrenci>)ogrenci).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)ogrenci).GetEnumerator();
        }
    }
}
