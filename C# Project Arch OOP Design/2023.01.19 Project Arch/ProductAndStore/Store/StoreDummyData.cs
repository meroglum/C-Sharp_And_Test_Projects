using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._01._19_Project_Arch.ProductAndStore.Product
{
    static class StoreDummyData
    {
        public static Dictionary<int, string> CountryCategories { get; set; } = new Dictionary<int, string>()
        {
            {1, "Turkiye" },
            {2, "Almanya" },
        };

        public static Dictionary<int, string> TurkishCityCategories { get; set; } = new Dictionary<int, string>()
        {
            {1, "Istanbul" },
            {2, "Ankara" },
            {3, "Izmir" },
        };
        public static Dictionary<int, string> GermanCityCategories { get; set; } = new Dictionary<int, string>()
        {
            {1, "Berlin" },
            {2, "Munih" },
            {3, "Frankfurt" },
        };

        public static Dictionary<int, string> CityStores { get; set; } = new Dictionary<int, string>()
        {
            {1, "Magaza 1" },
            {2, "Magaza 2" },
            {3, "Magaza 3" },
        };

        public static Dictionary<int, string> Products { get; set; } = new Dictionary<int, string>()
        {
            {1, "Urun 1" },
            {2, "Urun 2" },
            {3, "Urun 3" },
        };
    }
}
