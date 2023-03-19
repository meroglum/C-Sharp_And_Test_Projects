using ConsoleApp6;

/// <summary>
/// Created by Muhammed EROGLU
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        Basket basket = new Basket();

        Phone phone1 = new Phone(PhoneManufacturers.Apple);
        Phone phone2 = new Phone(PhoneManufacturers.Samsung);
        PC pc1 = new PC(PCManufacturers.Monster);

        basket.Add(phone1);
        basket.Add(phone2);
        basket.Add(pc1);

        Console.WriteLine("Kategorisel ürün sayısı PC:{0} Phone:{1}" ,basket.PcCount,basket.PhoneCount);
        Console.WriteLine("Toplam ürün sayısı:"+ (basket.PcCount + basket.PhoneCount));
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine("Toplam fiyat(KDV hariç): "+ basket.TotalPrice());
        Console.WriteLine("Toplam fiyat(KDV dahil): "+ basket.TotalPriceWithKDV());
        Console.WriteLine("Sipariş KDV toplamı: " + (basket.TotalPriceWithKDV() - basket.TotalPrice()));
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine("İndirimli fiyat : " + basket.TotalPriceWithDiscount());
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine("***********TEBRİKLER**************");
        Console.WriteLine("Kazanılan indirim miktarı: {0} lira" , (basket.TotalPriceWithKDV() - basket.TotalPriceWithDiscount()));
        Console.WriteLine("********İNDİRİM KAZANDINIZ**********");
    }


}
