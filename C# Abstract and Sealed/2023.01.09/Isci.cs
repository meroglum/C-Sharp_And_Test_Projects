using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._01._09
{
    internal class Isci : Calisan
    {
        public Isci() {
            Unvan = "İşçi";
        }

        /// <summary>
        /// Taken from abstract class Calisan.cs.
        /// </summary>
        /// <returns></returns>
        public override double GetSalary()
        {
            return 8506.35;
        }
    }
}
