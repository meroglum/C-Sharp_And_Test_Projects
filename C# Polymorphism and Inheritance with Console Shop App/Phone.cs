using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2023._01._04_exercise
{
    public enum PhoneManufacturers
    {
        Samsung,
        Apple,
        Xiaomi,
        Huawei,
        Oppo,
        Vivo,
        Realme,
        Motorola,
        LG,
    }
    
    public enum PhoneModelPrices 
    {
        Model1 = 10250,
        Model2 = 22500,
        Model3 = 27550,
    }
    class Phone : Product
    {
        public PhoneManufacturers PhoneManufacturer { get; set; }
        public PhoneModelPrices PhoneModelPrice { get; set; }
        public int Storage { get; set; }
        public int Ram { get; set; }
        public double ScreenSize { get; set; }
        public double CPUSpeed { get; set; }
        public string PhoneBrand { get; set; }

        public static List<string> PhoneBrandList { get; set; } = new List<string>
        {
            "Samsung",
            "Apple",
            "Xiaomi",
            "Huawei",
            "Oppo",
            "Vivo",
            "Realme",
            "Motorola",
            "LG",
        };

        public override double SetTaxes()
        {
            return this.Price * 1.5;
        }
        
        public Phone(int i)
        {
            SetBrandProperties(i);
        }

        public Phone(PhoneManufacturers phoneManufacturer) ///Get breadType and execute the methods accordingly
        {
            switch(phoneManufacturer)
            {
                case PhoneManufacturers.Apple:
                    this.PhoneBrand = "Apple";
                    break;
                case PhoneManufacturers.Huawei:
                    this.PhoneBrand = "Huawei";
                    break;
                case PhoneManufacturers.LG:
                    this.PhoneBrand = "LG";
                    break;
                case PhoneManufacturers.Motorola:
                    this.PhoneBrand = "Motorola";
                    break;
                case PhoneManufacturers.Oppo:
                    this.PhoneBrand = "Oppo";
                    break;
                case PhoneManufacturers.Realme:
                    this.PhoneBrand = "Realme";
                    break;
                case PhoneManufacturers.Samsung:
                    this.PhoneBrand = "Samsung";
                    break;
                case PhoneManufacturers.Vivo:
                    this.PhoneBrand = "Vivo";
                    break;
                case PhoneManufacturers.Xiaomi:
                    this.PhoneBrand = "Xiaomi";
                    break;
                default:
                    throw new Exception("Lütfen geçerli bir değer giriniz");
            }
        }

        /// <summary>
        /// Marka özellikleri için gerekli değişkenleri düzenler
        /// </summary>
        /// <param name="i"></param>
        /// <exception cref="Exception"></exception>
        public void SetBrandProperties(int i)
        {
            switch (i)
            {
                case 1:
                    this.Price = (double)PhoneModelPrices.Model1;
                    this.Storage = 128;
                    this.CPUSpeed = 2.2;
                    this.ScreenSize = 6.1;
                    this.Ram = 4;
                    break;
                case 2:
                    this.Price = (double)PhoneModelPrices.Model2;
                    this.Storage = 256;
                    this.CPUSpeed = 2.78;
                    this.ScreenSize = 6.34;
                    this.Ram = 6;
                    break;
                case 3:
                    this.Price = (double)PhoneModelPrices.Model3;
                    this.Storage = 512;
                    this.CPUSpeed = 3.24;
                    this.ScreenSize = 6.89;
                    this.Ram = 12;
                    break;
                default:
                    throw new Exception("Model bulunamadı");
            }
        }
    }
}
