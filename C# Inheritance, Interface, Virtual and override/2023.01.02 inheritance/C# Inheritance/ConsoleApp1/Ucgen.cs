using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Ucgen : IkiBoyut // Inheritance from IkiBoyut
    {
        public string Stil { get; set; }

        public void Goster()
        {
            Console.WriteLine("Stil : " + Stil);
        }

        public static void SihirYap()
        {
            Console.WriteLine("Backspace siler.");
        }

        public double AlanHesapla()
        {
            return Genislik * Yukseklik / 2;
        }
    }
}
