using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._01._09
{
    internal class Muhendis:Calisan
    {
        public Muhendis()
        {
            Unvan = "Mühendis";
        }

        /// <summary>
        /// Overriding from abstract class Calisan.cs.
        /// </summary>
        /// <returns></returns>
        public override double GetSalary()
        {
            return 20000.0;
        }
    }
}
