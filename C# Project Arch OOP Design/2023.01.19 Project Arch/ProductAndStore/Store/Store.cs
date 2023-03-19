using _2023._01._19_Project_Arch.ProductAndStore.Product;
using _2023._01._19_Project_Arch.ProductAndStore.Store.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._01._19_Project_Arch.ProductAndStore.Store
{
    class Store : City, IProductAndStoreBase, Istore
    {
        public Store() {
            SelectAStore();
                }
        public string Address { get; set; }
        public string Telephone { get; set; }

        /// <summary>
        /// It retrives cities from dummy data.
        /// </summary>
        public void SelectAStore()
        {
            ///TODO Virtual override kullanılabilir.
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Lutfen Magazayi seciniz.");

            foreach (KeyValuePair<int, string> city in StoreDummyData.CityStores)
            {
                Console.WriteLine(city.Key + ": " + city.Value);
            }
            Console.WriteLine("Magaza seciminiz: ");
            try
            {
                Console.ReadLine();
                this.Code = int.Parse(Console.Read().ToString());
                foreach (KeyValuePair<int, string> city in StoreDummyData.CityStores)
                {
                    if (city.Key == this.Code)
                        this.Name = city.Value;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Lütfen Geçerli bir değer giriniz.");
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Urunlere yonlendirme yapiliyor...");
        }

    }
}
