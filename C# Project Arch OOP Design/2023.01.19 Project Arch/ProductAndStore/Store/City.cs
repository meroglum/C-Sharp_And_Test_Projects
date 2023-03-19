using _2023._01._19_Project_Arch.ProductAndStore.Product;
using _2023._01._19_Project_Arch.ProductAndStore.Store.Interfaces;
using _2023._01._19_Project_Arch.Time.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._01._19_Project_Arch.ProductAndStore.Store
{
    class City : Country, IProductAndStoreBase, ICityAndCountry
    {
        public City() { }

        public City(int SelectedCountry) 
        {
            SelectACity(SelectedCountry);
        }

        /// <summary>
        /// It retrives cities from dummy data.
        /// </summary>
        public void SelectACity(int SelectedCountry)
        {
            ///TODO Virtual override kullanılabilir.
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Lutfen Magazanın bulundugu sehri seciniz.");
            Dictionary<int, string> _citiesList = SelectedCountry == 49 ?
                StoreDummyData.TurkishCityCategories :
                StoreDummyData.GermanCityCategories;

            foreach (KeyValuePair<int, string> city in _citiesList)
            {
                Console.WriteLine(city.Key + ": " + city.Value);
            }
            Console.Write("Sehir seciminiz: ");
            try
            {
                Console.ReadLine();
                this.Code = int.Parse(Console.Read().ToString());
                foreach (KeyValuePair<int, string> city in _citiesList)
                {
                    if (city.Key == this.Code)
                        this.Name = city.Value;
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
