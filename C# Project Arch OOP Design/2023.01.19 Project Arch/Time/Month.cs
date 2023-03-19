using _2023._01._19_Project_Arch.Time.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._01._19_Project_Arch.Time
{
    class Month:Quarter,IBaseTime
    {
        public Month() 
        {
            GetMonth();
        }
        public int MountCode { get; set; }
        public int Name { get; set; }

        public void GetMonth()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Ay: " + DateTimeNow.Month);
        }
    }
}
