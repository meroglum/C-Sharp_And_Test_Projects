using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public Product() { }
        
        public Product(
            int product,
            string productCode,
            string productName,
            double price) 
        {
            this.ProductID = product;
            this.ProductCode = productCode;
            this.ProductName= productName;
            this.Price = price;
        }

        /// <summary>
        /// Vergiyi hesapla
        /// </summary>
        /// <returns></returns>
        public virtual double SetTaxes()
        {
            return this.Price * 1.5;
        }

        /// <summary>
        /// İndirim hesapla
        /// </summary>
        /// <param name="discountPercentage"></param>
        /// <returns></returns>
        public virtual double SetDiscount(int discountPercentage = 10) 
        {
           double discountedPrice = this.Price - (this.Price * (discountPercentage / 100));
            if (this.Price <= 0)
            {
                Console.WriteLine("Ürünü bedava almaya hak kazandınız :D ");
            }
            return discountedPrice;
        }
    }
}
