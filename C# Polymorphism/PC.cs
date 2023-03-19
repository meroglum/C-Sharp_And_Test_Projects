using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public enum PCManufacturers
    {
        HP = 22,
        Apple = 1,
        Huawei = 2,
        Lenovo = 3,
        Asus = 4,
        Monster = 5,
        Dell = 6,
        Casper = 7,
    }

    public enum PCModels
    {
        Model1 = 1,
        Model2 = 2,
        Model3 = 3,
        Model4 = 4,
        Model5 = 5,
        Model6 = 6,
        Model7 = 7,
        Model8 = 8,
    }
   
    class PC : Product
    {
        public PCManufacturers PCManufacturer { get; set; }
        public PCModels PhoneModel { get; set; }
        
        /// <summary>
        /// Override the taxes defined in product class.
        /// </summary>
        /// <returns></returns>
        public override double SetTaxes()
        {
            return this.Price * 1.5; ;
        }

        
        public PC() { }

        public PC(
           PCManufacturers pcManufacturer)
        {
            
            switch (pcManufacturer)
            {
                case PCManufacturers.Asus:
                    this.Price = 20000.0;
                    this.PhoneModel = PCModels.Model1;
                    break;
                case PCManufacturers.Apple:
                    this.Price = 55999.0;
                    this.PhoneModel = PCModels.Model2;
                    break;
                case PCManufacturers.Monster:
                    this.Price = 12869.0;
                    this.PhoneModel = PCModels.Model3;
                    break;
                case PCManufacturers.Huawei:
                    this.Price = 23859.0;
                    this.PhoneModel = PCModels.Model4;
                    break;
                case PCManufacturers.Dell:
                    this.Price = 16869.0;
                    this.PhoneModel = PCModels.Model5;
                    break;
                case PCManufacturers.HP:
                    this.Price = 14523.0;
                    this.PhoneModel = PCModels.Model6;
                    break;
                case PCManufacturers.Lenovo:
                    this.Price = 5239.0;
                    this.PhoneModel = PCModels.Model7;
                    break;
                default:
                    throw new Exception("Lütfen geçerli bir bilgisayar üreticisi seçiniz");
                    //throw varken break kullanımına gerek yok
            }
        }

        public PC(
            double price)
        {
            double _price = 0;
            if (price > 0)
            {
                _price = price;
            }
            if (_price <= 0)
            {
                throw new Exception("PC ücreti sıfır ya da sıfırdan küçük olamaz.");
            }
            else if (price > 0 && price < 20000)
            {
                Console.WriteLine("Meccvut bütçeyle LG, Sony, Nokia ve Xiaoni PC alınabilir");
            }
            else
            {
                Console.WriteLine("Mevcut bütçeyle Huawei, Apple ve Samsung cihazlaar alabilirsiniz.");
            }
          
        }
    }
  
    
}
