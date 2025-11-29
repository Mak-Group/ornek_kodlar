using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace daire_alani_cevresi
{
    internal class hesapla
    {
        public hesapla()
        {
        }

        public double alan(double yaricap)
        {
            double alanHesaplama = 0;
            alanHesaplama = Math.PI * yaricap * yaricap;
            Console.WriteLine("Dairenin Alanı: {0}", alanHesaplama);
            Console.WriteLine();
            return alanHesaplama;

        }

        public double cevre(double yaricap)
        {
            double cevreHesaplama = 0;
            cevreHesaplama = 2 * Math.PI * yaricap;
            Console.WriteLine("Dairenin cevresi:{0}", cevreHesaplama);
            Console.WriteLine();
            return cevreHesaplama;
        }


    }
}
