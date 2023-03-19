using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._01._19_Project_Arch.Time
{
    class Time:Month
    {
        public int TimeCode { get; set; }
        public string Day { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public string Working { get; set; } = string.Empty;
        public int DayNumber { get; set; }
    }
}
