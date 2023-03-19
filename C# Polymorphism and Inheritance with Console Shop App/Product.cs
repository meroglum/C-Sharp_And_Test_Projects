using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._01._04_exercise
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public Product() { }

        private int selectedProductType = -1; // Ürün tipi PC, telefon gibi
        private int selectedProductBrand = -1; // Marka
        private int selectedProductModel = -1; // Model

        public Product(int productID, string productCode, string productName, double price)
        {
            this.ProductID = productID;
            this.ProductCode = productCode;
            this.ProductName = productName;
            this.Price = price;
        }

        Basket basket = new Basket();

        /// <summary>
        /// Vergiyi ayarlar
        /// </summary>
        /// <returns></returns>
        public virtual double SetTaxes()
        {
            return this.Price * 1.18;
        }

        /// <summary>
        /// Seçilen ürün tipini ayarlar
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void SelectProductType()
        {
            Console.Write("Lütfen bir ürün Kategorisi seçiniz : ");
            try
            {
                selectedProductType = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            switch (selectedProductType)
            {
                case 1:
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("Telefon Üreticileri:");
                    for (int i = 0; i < Phone.PhoneBrandList.Count; i++)
                    {
                        Console.WriteLine("{0}: {1}", i + 1, Phone.PhoneBrandList[i]);
                    }
                    try
                    {
                        Console.WriteLine("Lütfen bir marka seçiniz: ");
                        selectedProductBrand = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("Seçtiğiniz telefon markası: " + Phone.PhoneBrandList[selectedProductBrand - 1]);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        selectedProductBrand = 0;
                    }
                    break;
                case 2:
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("Bilgisayar Üreticileri:");
                    for (int i = 0; i < PC.PCBrandList.Count; i++)
                    {
                        Console.WriteLine("{0}: {1}", i + 1, PC.PCBrandList[i]);
                    }
                    try
                    {
                        Console.WriteLine("Lütfen bir marka seçiniz: ");
                        selectedProductBrand = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("Seçtiğiniz bilgisayar markası: " + PC.PCBrandList[selectedProductBrand - 1]);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        selectedProductBrand = 0;
                    }
                    break;
                default:
                    throw new Exception("Lütfen geçerli bir değer giriniz");
            }

        }

        /// <summary>
        /// Ürün modelini seçmek için kullanılır.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void SelectProductModel()
        {

            switch (selectedProductType)
            {
                case 1:
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("Model 1: " + (int)PhoneModelPrices.Model1 + " lira");
                    Console.WriteLine("Model 2: " + (int)PhoneModelPrices.Model2 + " lira");
                    Console.WriteLine("Model 3: " + (int)PhoneModelPrices.Model3 + " lira");
                    Console.WriteLine("Lütfen Model Seçiniz: ");
                    try
                    {
                        Console.WriteLine("Lütfen bir model seçiniz: ");
                        selectedProductModel = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("Seçtiğiniz telefon modeli: Model " + selectedProductModel);
                        Phone phone = new Phone(selectedProductModel);
                        basket.Add(phone);
                        basket.TotalPrice();
                        basket.TotalPriceWithKdv();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        selectedProductModel = 0;
                    }
                    break;
                case 2:
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("Model 1: " + (int)PCModelPrices.Model1 + " lira");
                    Console.WriteLine("Model 2: " + (int)PCModelPrices.Model2 + " lira");
                    Console.WriteLine("Model 3: " + (int)PCModelPrices.Model3 + " lira");
                    Console.WriteLine("Lütfen Model Seçiniz: ");
                    try
                    {
                        Console.WriteLine("Lütfen bir model seçiniz: ");
                        selectedProductModel = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("Seçtiğiniz bilgisayar modeli: Model " + selectedProductModel);
                        PC pc = new PC(selectedProductModel);
                        basket.Add(pc);
                        basket.TotalPrice();
                        basket.TotalPriceWithKdv();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        selectedProductModel = 0;
                    }

                    break;
                default:
                    throw new Exception("Lütfen geçerli bir değer giriniz");
            }
        }

        /// <summary>
        /// Ürün satın alındıktan sonra kaydedilen ürünlerin geçici kaydını tutar.
        /// </summary>
        /// <returns></returns>
        public string GetLOGData()
        {
            string stringToSave = "";
        switch(selectedProductType)
            {
                case 1:
                    stringToSave += "Alınan ürün : Telefon ";
                    stringToSave += "Ürün Markası: "+Phone.PhoneBrandList[selectedProductBrand];
                    stringToSave += "Ürün Modeli: Model " + selectedProductModel;
                    break;
                    case 2:
                    stringToSave += "Alınan ürün : Biilgisayar";
                    stringToSave += "Ürün Markası: " + PC.PCBrandList[selectedProductBrand];
                    stringToSave += "Ürün Modeli: Model " + selectedProductModel;
                    break;
            }
            return stringToSave;
    }
    }
}
