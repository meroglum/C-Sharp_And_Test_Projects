using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public enum PhoneManufacturers
    {
        Samsung = 0,
        Apple = 1,
        Huawei = 2,
        Nokia = 3,
        Sony = 4,
        LG = 5,
        HTC = 6,
        Motorola = 7,
    }

    public enum PhoneModels
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

    class Phone : Product
    {
        public PhoneManufacturers PhoneManufacturer { get; set; }
        public PhoneModels PhoneModel { get; set; }
        
        public override double SetTaxes()
        {
            return this.Price * 1.5;
        }

        
        public Phone() { }

        public Phone(
           PhoneManufacturers phoneManufacturer)
        {
            switch (phoneManufacturer)
            {
                case PhoneManufacturers.Samsung:
                    this.Price = 20000.0;
                    this.PhoneModel = PhoneModels.Model1;
                    break;
                case PhoneManufacturers.Apple:
                    this.Price = 55999.0;
                    this.PhoneModel = PhoneModels.Model2;
                    break;
                case PhoneManufacturers.HTC:
                    this.Price = 12869.0;
                    this.PhoneModel = PhoneModels.Model3;
                    break;
                case PhoneManufacturers.Huawei:
                    this.Price = 23859.0;
                    this.PhoneModel = PhoneModels.Model4;
                    break;
                case PhoneManufacturers.LG:
                    this.Price = 16869.0;
                    this.PhoneModel = PhoneModels.Model5;
                    break;
                case PhoneManufacturers.Motorola:
                    this.Price = 14523.0;
                    this.PhoneModel = PhoneModels.Model6;
                    break;
                case PhoneManufacturers.Nokia:
                    this.Price = 5239.0;
                    this.PhoneModel = PhoneModels.Model7;
                    break;
                default:
                    throw new Exception("Lütfen geçerli telefon üreticisi seçiniz");
                    //throw varken break kullanımına gerek yok
            }
        }

        public Phone(
            double price)
        {
            double _price = 0;
            if (price > 0)
            {
                _price = price;
            }
            if (_price <= 0)
            {
                throw new Exception("Telefon ücreti sıfır ya da sıfırdan küçük olamaz.");
            }
            else if (price > 0 && price < 20000)
            {
                Console.WriteLine("Meccvut bütçeyle LG, Sony, Nokia ve Xiaoni telefonlar alınabilir");
            }
            else
            {
                Console.WriteLine("Mevcut bütçeyle Huawei, Apple ve Samsung cihazlaar alabilirsiniz.");
            }
        }
    }
  
    
}
