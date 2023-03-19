using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Kullanici
    {
        public static int ID { get; set; }
        public string Ad { get; set; }

        public Kullanici() 
        { 
        
        }

        public int GetID()
        {
            return Kullanici.ID;
        }
    }
}
