using PartialClassessExercise;

/// <summary>
/// Created by Muhammed EROGLU.
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        /// Book is a partial class
        /// BookDBHandler.cs BookMethods.cs and Book.cs are all partial classes.
        Book book = new Book();
        book.GetBookFromDB();
        book.ShowAvailableBooksAndAuthorsOnLibrary();
    }
}