namespace ConsoleApp1
{
    internal class Muhendis : Calisan
    {
        public string Tur { get; set; }
        public string Departman { get; set; }

        public override double MaasHesapla()
        {
            return 2.500;
        }
    }
}
