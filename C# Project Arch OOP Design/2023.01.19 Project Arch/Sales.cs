using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._01._19_Project_Arch
{
    class Sales
    {
        public Sales() {
            DummySalesData();
                }
        public string TicketNumber { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Inventory { get; set; } = string.Empty;

        public void DummySalesData()
        {
            Console.WriteLine("Urun adadi: 1");
            Console.WriteLine("Urun fiyatı: 1000");
            Console.WriteLine("Ticket no 185623135");
        }
    }
}
