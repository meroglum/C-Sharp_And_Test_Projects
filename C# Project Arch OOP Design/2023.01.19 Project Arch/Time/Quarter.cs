using _2023._01._19_Project_Arch.Time.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._01._19_Project_Arch.Time
{
    class Quarter:Year,IBaseTime
    {
        public Quarter() 
        {
            GetQuarter();
        }

        public void GetQuarter()
        {
            if(DateTimeNow.Month <=3)
                Console.WriteLine("Quarter: 1");
            if (DateTimeNow.Month >= 4 && DateTimeNow.Month <= 6)
                Console.WriteLine("Quarter: 2");
            if (DateTimeNow.Month >= 7 && DateTimeNow.Month <= 9)
                Console.WriteLine("Quarter: 3");
            if (DateTimeNow.Month >= 10 && DateTimeNow.Month <= 12)
                Console.WriteLine("Quarter: 4");
        }
    }
}
