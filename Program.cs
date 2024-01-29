using PolimorphizmExample2;

namespace PolimorfizmExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HesapMakinesi hesapMakinesi = new HesapMakinesi();
            int sonuc1 = hesapMakinesi.Topla(2,7);
            Console.WriteLine("Sonuc: " + sonuc1);

            double sonuc2 = hesapMakinesi.Topla(3,20.4);
            Console.WriteLine("Sonuc: " + sonuc2);

        }
    }
}