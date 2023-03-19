using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._01._17_PizzaOrder
{
    public enum EnumPizzaTypes // enum for defining pizza types.
    {
        Seciniz = 0,
        KüçükBoy = 1,
        OrtaBoy = 2,
        BüyükBoy = 3,
    }
    class PizzaTypes : Product // Inheritance from Product class.
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Fill the pizza types on the comboBox
        /// </summary>
        public List<PizzaTypes> GetPizzaTypes()
        {
            List<PizzaTypes> pizzaTypes = new List<PizzaTypes>
            {
                new PizzaTypes() { ID = 0, Name = EnumPizzaTypes.Seciniz.ToString() },
                new PizzaTypes() { ID = 1, Name = EnumPizzaTypes.KüçükBoy.ToString() },
                new PizzaTypes() { ID = 2, Name = EnumPizzaTypes.OrtaBoy.ToString() },
                new PizzaTypes() { ID = 3, Name = EnumPizzaTypes.BüyükBoy.ToString() },
            };
            return pizzaTypes;
        }

        /// <summary>
        /// Overloaded constructer to get pizza types.
        /// </summary>
        /// <param name="pizzaType"></param>
        public PizzaTypes(int pizzaType)
        {
            SetPizzaProperties(pizzaType);
        }
        
        /// <summary>
        /// Created empty contructer
        /// </summary>
        public PizzaTypes()
        {

        }

        /// <summary>
        /// To calculate the price.
        /// </summary>
        /// <param name="drinkTypes"></param>
        public void SetPizzaProperties(int pizzaTypes)
        {
            switch (pizzaTypes)
            {
                case (int)EnumPizzaTypes.KüçükBoy:
                    this.Price = 52.99; // Price is from Product class.
                    this.ProductName = EnumPizzaTypes.KüçükBoy.ToString();
                    break;
                case (int)EnumPizzaTypes.OrtaBoy:
                    this.Price = 86.75;
                    this.ProductName = EnumPizzaTypes.OrtaBoy.ToString();
                    break;
                case (int)EnumPizzaTypes.BüyükBoy:
                    this.Price = 119.99;
                    this.ProductName = EnumPizzaTypes.BüyükBoy.ToString();
                    break;
                default:
                    this.Price = 0;
                    this.ProductName = EnumPizzaTypes.Seciniz.ToString();
                    return;
            }
        }
    }
}
