using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._01._19_Project_Arch.ProductAndStore.Product
{
    /// <summary>
    /// This class keeps the dummy data for the products.
    /// </summary>
    static class ProductDummyData
    {
        public static Dictionary<int, string> DepartmentCategories { get; set; } = new Dictionary<int, string>()
        {
            {1, "Ev Elektronigi" },
            {2, "Giyim" },
        };

        public static Dictionary<int, string> HomeElectronicsCategories { get; set; } = new Dictionary<int, string>()
        {
            {21, "Televizyon" },
            {2, "Ev muzik Sistemleri" },
       //   {3, "Guvenlik Sistemleri" },
        };
        public static Dictionary<int, string> TVCategories { get; set; } = new Dictionary<int, string>()
        {
            {1, "32 Inc" },
            {2, "42 Inc" },
            {3, "54 Inch" },
        };

        public static Dictionary<int, string> AudioSystemCategories { get; set; } = new Dictionary<int, string>()
        {
            {1, "2+1" },
            {2, "5+1" },
            {3, "7+1" },
        };
        public static Dictionary<int, string> SecuritySystemCategories { get; set; } = new Dictionary<int, string>()
        {
            {1, "Kemera ve CCTV"},
            {2, "Hırsız Alarmı"},
        };


        public static Dictionary<int, string> ClothingCategories { get; set; } = new Dictionary<int, string>()
        {
            {71, "Kadin Giyim" },
            {72, "Erkek Giyim" },
            {73, "Cocuk Giyim" },
        };

        public static Dictionary<int, string> ClothingWomenProducts { get; set; } = new Dictionary<int, string>()
        {
            {61, "Elbise" },
            {62, "Etek" },
            {63, "Ayakkabi" },
        };

        public static Dictionary<int, string> ClothingMenProducts { get; set; } = new Dictionary<int, string>()
        {
            {51, "Takim Elbise" },
            {52, "T-Shirt" },
            {53, "Ayakkabi" },
        };

        public static Dictionary<int, string> ClothingChildProducts { get; set; } = new Dictionary<int, string>()
        {
            {41, "Kazak" },
            {42, "T-Shirt" },
            {43, "Ayakkabı" },
        };
    }
}
