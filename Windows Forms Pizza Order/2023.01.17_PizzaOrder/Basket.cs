using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2023._01._17_PizzaOrder
{
    class Basket
    {
        private List<Product> products = new List<Product>();
        
        /// <summary>
        /// It adds products to the basket.
        /// </summary>
        /// <param name="product"></param>
        public void Add(Product product)
        {
            if (product != null) ///TODO Before adding the product correct data validation can be added.
                this.products.Add(product);
        }

        /// <summary>
        /// It removes checkBox product from the list.
        /// </summary>
        /// <param name="product"></param>
        public void RemoveCheckBoxProduct(Product product,string productName)
        {
            if (product != null)
            {
                int removeIndex = -1;
                for (int i = 0; i < products.Count; i++)
                {
                    if (products[i].ProductName == productName) // TODO Change it with ID
                    {
                        removeIndex = i;
                    }
                }
                this.products.RemoveAt(removeIndex);
            }
        }

        /// <summary>
        /// It removes comboBox product from the list.
        /// </summary>
        /// <param name="product"></param>
        public void RemoveComboBoxPizzaProduct()
        {
                for (int i = 0; i < products.Count; i++)
                {
                    if (products[i] is PizzaTypes)
                    {
                        this.products.RemoveAt(i);
                    }
                }
        }

        /// <summary>
        /// It removes comboBox product from the list.
        /// </summary>
        /// <param name="product"></param>
        public void RemoveComboBoxDrinkProduct()
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i] is DrinkTypes)
                {
                    this.products.RemoveAt(i);
                }
            }
        }

        /// <summary>
        /// Calculates the total price.
        /// </summary>
        /// <returns></returns>
        public double GetTotalPrice()
        {
            double totalPrice = 0;
            foreach (Product product in this.products)
            {
                totalPrice += product.Price;
            }
            return totalPrice;
        }
    }
}
