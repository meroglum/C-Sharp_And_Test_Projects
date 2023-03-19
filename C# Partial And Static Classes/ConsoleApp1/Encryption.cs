namespace ConsoleApp1
{
    internal static class Encryption
    {
        /// <summary>
        /// Get a random id when static class is called.
        /// </summary>
        static Encryption() 
        {
            _id = new Random().Next(100, 1000);
        }

        private static int _id;

        /// <summary>
        /// Simple encript sample.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string Encrypt(string data)
        {
            return data + _id;
        }

        /// <summary>
        /// Simple decrypt sample.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string Decrypt(string data)
        {
            return data + _id;
        }
    }
}
