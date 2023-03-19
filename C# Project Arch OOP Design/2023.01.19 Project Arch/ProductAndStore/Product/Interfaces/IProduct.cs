using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._01._19_Project_Arch.ProductAndStore.Product.Interfaces
{
    interface IProduct
    {
        public string Color { get; set; }
        public string Size { get; set; }
        public double Weight { get; set; }
    }
}
