using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._01._19_Project_Arch.ProductAndStore.Product
{
    class Department : IProductAndStoreBase
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public Department() { }
        public Department(bool selectDepartmentIsTrue)
        {
            if (selectDepartmentIsTrue)
                SelectDepartment();
        }

        /// <summary>
        /// It retrives countries from dummy data.
        /// </summary>
        public void SelectDepartment()
        {
            ///TODO Virtual override kullanılabilir.
            ///Ayrıca bir method yazılıp her yerden erişim de sağlananilir.
            ///Alternatifleri uygula.
            Console.WriteLine("Lutfen Kategori seçiniz.");
            foreach (KeyValuePair<int, string> country in ProductDummyData.DepartmentCategories)
            {
                Console.WriteLine(country.Key + ": " + country.Value);
            }
            Console.Write("Kategori seçiminiz: ");
            try
            {
                Console.ReadLine();
                this.Code = int.Parse(Console.Read().ToString());
                foreach (KeyValuePair<int, string> country in ProductDummyData.DepartmentCategories)
                {
                    if (country.Key == this.Code)
                    {
                        this.Code = country.Key;
                        this.Name = country.Value;
                    }
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
