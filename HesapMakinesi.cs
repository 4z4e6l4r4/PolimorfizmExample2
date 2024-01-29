
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorphizmExample2
{
    internal class HesapMakinesi
    {
        public int Topla(int sayi1, int sayi2) //Derleme Zamanlı Polimorfizm
        {
            return sayi1 + sayi2;
        }
        public double Topla(double sayi1, double sayi2)
        {
            return sayi1 + sayi2;
        }
    }
}