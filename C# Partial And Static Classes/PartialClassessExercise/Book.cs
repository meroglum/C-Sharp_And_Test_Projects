using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassessExercise
{
    partial class Book
    {
        private int bookId;
        
        public enum KitapKategorileri
        {
            Roman = 0,
            KişiselGelisim = 1,
            Tarih = 2,
            DunyaKlasikleri = 3,
            Cocuk = 4,
            CizgiRoman = 5,
        }
        public Dictionary<string, string> BookList  = new Dictionary<string, string>(); //Yazar ve kitap ismini tutar

        public int Price { get; set; } = new int(); //fiyatı initialize et

    }
}
