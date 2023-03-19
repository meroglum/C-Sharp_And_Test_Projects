using _2023._01._19_Project_Arch.ProductAndStore.Product.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._01._19_Project_Arch.ProductAndStore.Product
{
    class Product : Category, IProductAndStoreBase, IProduct
    {
        public string Color { get; set; }
        public string Size { get; set; }
        public double Weight { get; set; }

        public Product() 
        {
            SelectProduct();
        }


        /// <summary>
        /// It retrives products from dummy data.
        /// </summary>
        public void SelectProduct()
        {
            ///TODO Virtual override kullanılabilir.
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Lutfen urunu seciniz.");

            foreach (KeyValuePair<int, string> product in StoreDummyData.Products)
            {
                Console.WriteLine(product.Key + ": " + product.Value);
            }
            Console.WriteLine("Urun seciminiz: ");
            try
            {
                Console.ReadLine();
                this.Code = int.Parse(Console.Read().ToString());
                foreach (KeyValuePair<int, string> product in StoreDummyData.Products)
                {
                    if (product.Key == this.Code)
                        this.Name = product.Value;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Lütfen Geçerli bir değer giriniz.");
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Urun Sepete eklendi.");
        }
    }
}
