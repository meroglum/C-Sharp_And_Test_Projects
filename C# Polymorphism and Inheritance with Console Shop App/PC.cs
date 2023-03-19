using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2023._01._04_exercise
{
    public enum PCManufacturers
    {
        Lenovo,
        Apple,
        Monster,
        Huawei,
        Acer,
        Asus,
        Microsoft,
        HP,
        Dell,
    }
    
    public enum PCModelPrices 
    {
        Model1 = 12220,
        Model2 = 22420,
        Model3 = 37550,
    }
    class PC : Product
    {
        public PCManufacturers PCManufacturer { get; set; }
        public PCModelPrices PCModelPrice { get; set; }
        public int Storage { get; set; }
        public int Ram { get; set; }
        public double CPUSpeed { get; set; }
        public string PCBrand { get; set; }

        public static List<string> PCBrandList { get; set; } = new List<string>
        {
           "Lenovo",
        "Apple",
        "Monster",
        "Huawei",
        "Acer",
        "Asus",
        "Microsoft",
        "HP",
        "Dell",
        };

        /// <summary>
        /// Overriding the method from Product class.
        /// </summary>
        /// <returns></returns>
        public override double SetTaxes()
        {
            return this.Price * 1.25;
        }
        
        public PC(int i) {
            SetBrandProperties(i);
        }

        public PC(PCManufacturers pcManufacturer) ///Get breadType and execute the methods accordingly
        {
            switch(pcManufacturer)
            {
                case PCManufacturers.Apple:
                    this.PCBrand = "Apple";
                    break;
                case PCManufacturers.Acer:
                    this.PCBrand = "Acer";
                    break;
                case PCManufacturers.Asus:
                    this.PCBrand = "Asus";
                    break;
                case PCManufacturers.Dell:
                    this.PCBrand = "Dell";
                    break;
                case PCManufacturers.HP:
                    this.PCBrand = "HP";
                    break;
                case PCManufacturers.Huawei:
                    this.PCBrand = "Huawei";
                    break;
                case PCManufacturers.Lenovo:
                    this.PCBrand = "Lenovo";
                    break;
                case PCManufacturers.Microsoft:
                    this.PCBrand = "Microsoft";
                    break;
                case PCManufacturers.Monster:
                    this.PCBrand = "Monster";
                    break;
                default:
                    throw new Exception("Lütfen geçerli bir değer giriniz");
            }
        }

        /// <summary>
        /// Marka için gerrekli değişkenleri değiştirir
        /// </summary>
        /// <param name="i"></param>
        /// <exception cref="Exception"></exception>
        public void SetBrandProperties(int i)
        {
            switch (i)
            {
                case 1:
                    this.Price = (double)PhoneModelPrices.Model1;
                    this.Storage = 256;
                    this.CPUSpeed = 2.22;
                    this.Ram = 8;
                    break;
                case 2:
                    this.Price = (double)PhoneModelPrices.Model2;
                    this.Storage = 512;
                    this.CPUSpeed = 2.89;
                    this.Ram = 16;
                    break;
                case 3:
                    this.Price = (double)PhoneModelPrices.Model3;
                    this.Storage = 1024;
                    this.CPUSpeed = 4.24;
                    this.Ram = 32;
                    break;
                default:
                    throw new Exception("Model bulunamadı");
            }
        }
    }
}
