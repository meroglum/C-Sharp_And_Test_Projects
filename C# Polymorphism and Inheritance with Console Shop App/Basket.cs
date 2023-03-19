using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _2023._01._04_exercise
{
    class Basket
    {
        private List<Product> products = new List<Product>();

        /// <summary>
        /// Sepete ürün ekler
        /// </summary>
        /// <param name="product"></param>
        public void Add(Product product)
        {
            if(product != null)
            {
                products.Add(product);
            }
        }

        /// <summary>
        /// Toplam fiyatı Hesaplar
        /// </summary>
        /// <returns></returns>
        public double TotalPrice()
        {
            double totalPrice = 0;
            foreach (var product in products)
            {
                totalPrice += product.Price; 
            }
            Console.WriteLine("Toplam Tutar: {0} lira", totalPrice);
            return totalPrice;
        }

        /// <summary>
        /// Toplam fiyatı Vergi ile hesaplar
        /// </summary>
        /// <returns></returns>
        public double TotalPriceWithKdv()
        {
            double totalPriceWithTaxes = 0;
            foreach (var product in products)
            {
                totalPriceWithTaxes += product.SetTaxes();
                Console.WriteLine("Toplam vergi dahil Tutar: {0} lira", totalPriceWithTaxes);
            }
            return totalPriceWithTaxes;
        }
        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
