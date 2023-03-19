using _2023._01._19_Project_Arch.Time.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._01._19_Project_Arch.Time
{
    class Year : IBaseTime
    {
        public int Code { get; set; }
        public string Description { get; set; } = string.Empty;

        public DateTime DateTimeNow { get; set; } = DateTime.Now;

        public Year() {
            GetYear();
        }

        public void GetYear()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Yıl: " + DateTimeNow.Year);
        }
    }
}
