namespace ConsoleApp1
{
    internal class Calisan
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Unvan { get; set; }

        //public double MaasHesapla()
        //{
        //    return 1.200;
        //}
        
        /// <summary>
        /// Method which can be overridden.
        /// </summary>
        /// <returns></returns>
        public virtual double MaasHesapla()
        {
            return 1.200;
        }
    }
}
