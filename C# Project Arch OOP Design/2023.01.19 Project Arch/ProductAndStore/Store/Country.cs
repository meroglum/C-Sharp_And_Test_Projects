using _2023._01._19_Project_Arch.ProductAndStore.Product;
using _2023._01._19_Project_Arch.ProductAndStore.Store.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2023._01._19_Project_Arch.ProductAndStore.Store
{
    class Country:IProductAndStoreBase, ICityAndCountry
    {
        public int Code { get; set; }
        public string Name { get; set;}
        public int Population { get; set; }

        public Country(bool selectCountry)
        {
            if(selectCountry)
            SelectACountry();
        }

        public Country() { }

        /// <summary>
        /// It retrives countries from dummy data.
        /// </summary>
        public void SelectACountry()
        {
            ///TODO Virtual override kullanılabilir.
            Console.WriteLine("Lutfen Magazanın bulundugu ulekyi seçiniz.");
            foreach (KeyValuePair<int,string> country in StoreDummyData.CountryCategories)
            {
                Console.WriteLine(country.Key + ": " + country.Value);
            }
            Console.Write("Ulke seçiminiz: ");
            try
            {
                this.Code = int.Parse(Console.Read().ToString());
                foreach (KeyValuePair<int, string> country in StoreDummyData.CountryCategories)
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
