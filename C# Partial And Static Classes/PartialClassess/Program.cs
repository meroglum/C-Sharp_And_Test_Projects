using PartialClassess;

// Lecture notes
internal class Program
{
    private static void Main(string[] args)
    {
        People people = new People();
        people.FirstName= "Test";
        people.LastName= "Test Last";
        people.Email = "test email";
        people.BirthDay= DateTime.Now;

        Console.WriteLine(people.GetFullName());
        Console.WriteLine(people.GetEmail(2));
    }
}