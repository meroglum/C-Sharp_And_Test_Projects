using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._01._09
{
    abstract class Calisan
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Unvan { get; set; }
        public string GetFullName()
        {
            return this.Ad + " " + this.Soyad;
        }

        /// <summary>
        /// Abstarc method olduğu için override kullanmalıyız.
        /// </summary>
        /// <returns></returns>
        public abstract double GetSalary();
    }
}
