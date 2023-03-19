using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._01._17_PizzaOrder
{
    /// <summary>
    /// Enum to keep extras types.
    /// </summary>
    public enum EnumExtrasTypes
    {
        Sucuk,
        Sosis,
        Mantar,
        Kaşar,
        Peynir,
        Sebze,
    }
    class Extras : Product
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Fill the extras types on the comboBox if required.
        /// </summary>
        public List<Extras> GetPizzaTypes()
        {
            List<Extras> extrasTypes = new List<Extras>
            {
                new Extras() { ID = 1, Name = EnumExtrasTypes.Sucuk.ToString()},
                new Extras() { ID = 2, Name = EnumExtrasTypes.Sosis.ToString()},
                new Extras() { ID = 3, Name = EnumExtrasTypes.Mantar.ToString()},
                new Extras() { ID = 4, Name = EnumExtrasTypes.Kaşar.ToString()},
                new Extras() { ID = 5, Name = EnumExtrasTypes.Peynir.ToString()},
                new Extras() { ID = 6, Name = EnumExtrasTypes.Sebze.ToString()}
            };
            return extrasTypes;
        }

        /// <summary>
        /// To set extras while calling the overloaded constructer.
        /// </summary>
        /// <param name="extrasType"></param>
        public Extras(EnumExtrasTypes extrasType)
        {
            SetExtrasProperties(extrasType);
        }

        /// <summary>
        /// Empty constructer.
        /// </summary>
        public Extras()
        {

        }

        /// <summary>
        /// To calculate the price.
        /// </summary>
        /// <param name="drinkTypes"></param>
        public void SetExtrasProperties(EnumExtrasTypes extrasTypes)
        {
            switch (extrasTypes)
            {
                case EnumExtrasTypes.Sucuk:
                    this.Price = 5.99; // Price is from Product class.
                    this.ProductName = EnumExtrasTypes.Sucuk.ToString();
                    break;
                case EnumExtrasTypes.Sosis:
                    this.Price = 4.75;
                    this.ProductName = EnumExtrasTypes.Sosis.ToString();
                    break;
                case EnumExtrasTypes.Mantar:
                    this.Price = 3.99;
                    this.ProductName = EnumExtrasTypes.Mantar.ToString();
                    break;
                case EnumExtrasTypes.Kaşar:
                    this.Price = 3.59; // Price is from Product class.
                    this.ProductName = EnumExtrasTypes.Kaşar.ToString();
                    break;
                case EnumExtrasTypes.Peynir:
                    this.Price = 2.75;
                    this.ProductName = EnumExtrasTypes.Peynir.ToString();
                    break;
                case EnumExtrasTypes.Sebze:
                    this.Price = 1.99;
                    this.ProductName = EnumExtrasTypes.Sebze.ToString();
                    break;
                default:
                    return;
            }
        }
    }
}
