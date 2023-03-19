using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Basket
    {
        public int PhoneCount { get; set; } = 0;
        public int PcCount { get; set; } = 0;

        private List<Product> products = new List<Product>();   
        public void Add(Product product) {
            if(product !=null) 
                this.products.Add(product);

            if (product is Phone)
            {
                PhoneCount++;
            }
            else if (product is PC)
            {
                PcCount++;
            }
        }

        /// <summary>
        /// Toplam fiyat
        /// </summary>
        /// <returns></returns>
        public double TotalPrice()
        {
            double totalPrice = 0;
            foreach(Product product in products)
            {
                totalPrice += product.Price;
            }
            return totalPrice;
        }

        /// <summary>
        /// Kdv ile fiyat
        /// </summary>
        /// <returns></returns>
        public double TotalPriceWithKDV()
        {
            double totalPrice = 0;
            foreach (Product product in products)
            {
                totalPrice += product.SetTaxes();
            }
            return totalPrice;
        }

        /// <summary>
        /// Toplam indirimli fiyarı hesapla
        /// </summary>
        /// <returns></returns>
        public double TotalPriceWithDiscount()
        {
            double totalPrice = 0;
            foreach (Product product in products)
            {
                totalPrice += product.SetTaxes();
            }
            return totalPrice - totalPrice*0.1;
        }

        /// <summary>
        /// Ürünleri getir
        /// </summary>
        /// <returns></returns>
        public List<Product> GetProducts()
        {
            return products;
        }

    }
}
