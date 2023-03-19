using System.Security.Cryptography;

namespace ConsoleApp1
{
    internal static class PinCodeGenerator
    {
        static PinCodeGenerator() 
        {
            _fourDigitPin = new Random().Next(1000, 9999); //4 haneli random sayı
            _sixDigitPin = new Random().Next(100000, 999999); //6 haneli random sayı
        }

        private static int _fourDigitPin; //4 haneli pini tutan değişken

        private static int _sixDigitPin;  //6 haneli pini tutan değişken

        /// <summary>
        ///4 haneli Pini göstermek için 
        /// </summary>
        public static void ShowFourDigitGenerator()
        {
            Console.WriteLine("4 haneli PIN: " + _fourDigitPin);
        }

        /// <summary>
        ///6 haneli Pini göstermek için 
        /// </summary>
        public static void ShowSixDigitGenerator()
        {
            Console.WriteLine("6 haneli PIN: " + _sixDigitPin);
        }

        /// <summary>
        ///4 haneli Pini okumak için 
        /// </summary>
        public static int FourDigitCode()
        {
            return _fourDigitPin;
        }

        /// <summary>
        ///6 haneli Pini Okumak için 
        /// </summary>
        public static int SixDigitCode()
        {
            return _sixDigitPin;
        }

        /// <summary>
        /// Yeni kodlar oluştur
        /// </summary>
        public static void GenerateNewCodes ()
        {
            _fourDigitPin = new Random().Next(1000, 9999); //4 haneli random sayı
            _sixDigitPin = new Random().Next(100000, 999999); //6 haneli random sayı
        }
    }
}
