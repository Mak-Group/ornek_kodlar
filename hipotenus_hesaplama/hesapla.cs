using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hipotenus_hesaplama
{
    internal class hesapla
    {
        public hesapla()
        {
        }

        public double hipotenus(double kenar1, double kenar2)
        {
            double hipotenusHesaplama = 0;
            hipotenusHesaplama = Math.Sqrt((kenar1 * kenar1) + (kenar2 * kenar2));
            Console.WriteLine("Üçgenin Hipotenüsü: {0}", hipotenusHesaplama);
            Console.WriteLine();
            return hipotenusHesaplama;


        }
    }
}
