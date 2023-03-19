using ConsoleApp1;

// Lecture notes
internal class Program
{
    private static void Main(string[] args)
    {
        PinCodeGenerator.ShowFourDigitGenerator(); //4 Haneli kodu göster
        PinCodeGenerator.ShowSixDigitGenerator();  //6 Haneli kodu göster

        Console.WriteLine("{0} ve {1} PIN kodlarını giriş yaparken kullanabilirsiniz.",
            PinCodeGenerator.FourDigitCode(), PinCodeGenerator.SixDigitCode()); //Bilgi ver

        PinCodeGenerator.GenerateNewCodes();
        PinCodeGenerator.ShowFourDigitGenerator(); //4 Haneli kodu göster
        PinCodeGenerator.ShowSixDigitGenerator();  //6 Haneli kodu göster

        Console.WriteLine("{0} ve {1} PIN kodlarını giriş yaparken kullanabilirsiniz.",
            PinCodeGenerator.FourDigitCode(), PinCodeGenerator.SixDigitCode()); //Bilgi ver
    }
}