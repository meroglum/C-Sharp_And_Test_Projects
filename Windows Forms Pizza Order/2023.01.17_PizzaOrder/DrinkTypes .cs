using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._01._17_PizzaOrder
{
    /// <summary>
    ///  This enum is used for defining the drink types.
    /// </summary>
    public enum EnumDrinkTypes
    {
        Seciniz = 0,
        Kola = 1,
        KolaLight = 2,
        SogukCay = 3,
        Ayran = 4,
        Sprite = 5,
        Fanta = 6,
    }
    class DrinkTypes : Product
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Fill the drink types on the comboBox
        /// </summary>
        public List<DrinkTypes> GetDrinkTypes()
        {
            List<DrinkTypes> drinkTypes = new List<DrinkTypes>
            {
                new DrinkTypes() { ID = 0, Name = EnumDrinkTypes.Seciniz.ToString()},
                new DrinkTypes() { ID = 1, Name = EnumDrinkTypes.Kola.ToString()},
                new DrinkTypes() { ID = 2, Name = EnumDrinkTypes.KolaLight.ToString() },
                new DrinkTypes() { ID = 3, Name = EnumDrinkTypes.SogukCay.ToString() },
                new DrinkTypes() { ID = 4, Name = EnumDrinkTypes.Ayran.ToString() },
                new DrinkTypes() { ID = 5, Name = EnumDrinkTypes.Sprite.ToString() },
                new DrinkTypes() { ID = 6, Name = EnumDrinkTypes.Fanta.ToString() }
            };
            return drinkTypes;
        }

        /// <summary>
        /// Overloaded constructer to set drink type according to the user selection.
        /// </summary>
        /// <param name="drinkType"></param>
        public DrinkTypes(int drinkType) 
        {
            SetDrinkProperties(drinkType);
        } 

        /// <summary>
        /// Empty constructer.
        /// </summary>
        public DrinkTypes()
        {

        }

     

        /// <summary>
        /// To calcula"te the price of the drink.
        /// </summary>
        /// <param name="drinkTypes"></param>
        public void SetDrinkProperties(int drinkTypes)
        {
            switch (drinkTypes)
            {
                case (int)EnumDrinkTypes.Kola:
                    this.Price = 12.0; // Price is from Product class.
                    this.ProductName = EnumDrinkTypes.Kola.ToString();
                    break;
                case (int)EnumDrinkTypes.KolaLight:
                    this.Price = 12.5;
                    this.ProductName = EnumDrinkTypes.KolaLight.ToString();
                    break;
                case (int)EnumDrinkTypes.Ayran:
                    this.Price = 6.85;
                    this.ProductName = EnumDrinkTypes.Ayran.ToString();
                    break;
                case (int)EnumDrinkTypes.SogukCay:
                    this.Price = 11.5;
                    this.ProductName = EnumDrinkTypes.SogukCay.ToString();
                    break;
                case (int)EnumDrinkTypes.Sprite:
                    this.Price = 12.25;
                    this.ProductName = EnumDrinkTypes.Sprite.ToString();
                    break;
                case (int)EnumDrinkTypes.Fanta:
                    this.Price = 12.25;
                    this.ProductName = EnumDrinkTypes.Fanta.ToString();
                    break;
                    default:
                    this.Price = 0;
                    this.ProductName = EnumDrinkTypes.Seciniz.ToString();
                    return;
            }
        }
    }
}
