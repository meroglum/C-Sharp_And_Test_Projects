using _2023._01._19_Project_Arch;
using _2023._01._19_Project_Arch.ProductAndStore.Product;
using _2023._01._19_Project_Arch.ProductAndStore.Store;
using _2023._01._19_Project_Arch.Time;

/// <summary>
/// Created By Muhammed EROGLU.
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        Country country = new Country(selectCountry:true);
        City city = new City(country.Code);
        Store store = new Store();
        Department department = new Department(selectDepartmentIsTrue: true);
        Category category = new Category(department.Code);
        Product product = new Product();
        Year year = new Year();
        Quarter quarter = new Quarter();
        Month month = new Month();
        Sales sales = new Sales();
    }
}