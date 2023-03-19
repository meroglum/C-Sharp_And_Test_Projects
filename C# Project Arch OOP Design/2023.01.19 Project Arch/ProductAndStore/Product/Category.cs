using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._01._19_Project_Arch.ProductAndStore.Product
{
    class Category:Department,IProductAndStoreBase
    {
        public Category() { }

        public Category(int selectedDepartment) {
            SelectAProductCategory(selectedDepartment);
        }

        /// <summary>
        /// It retrives category from dummy data.
        /// </summary>
        public void SelectAProductCategory(int selectedDepartment)
        {
            ///TODO Virtual override kullanılabilir.
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Lutfen Kategori seciniz.");
            Dictionary<int, string> _categoryList = selectedDepartment == 49 ?
                ProductDummyData.HomeElectronicsCategories :
                ProductDummyData.ClothingCategories;

            foreach (KeyValuePair<int, string> category in _categoryList)
            {
                Console.WriteLine(category.Key + ": " + category.Value);
            }
            Console.Write("Urun kategorisi seciminiz: ");
            try
            {
                Console.ReadLine();
                this.Code = int.Parse(Console.Read().ToString());
                foreach (KeyValuePair<int, string> category in _categoryList)
                {
                    if (category.Key == this.Code)
                        this.Name = category.Value;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Lutfen Gecerli bir deger giriniz.");
                Console.WriteLine(e.Message);
            }

        }

    }
}
