using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daire_alani_cevresi
{
    internal class Program
    {


        static void Main(string[] args)
        {
            hesapla h1 = new hesapla();

            while (true)
            {
                double yaricap = 0;
                double alanHesaplama = 0, cevreHesaplama = 0;

                Console.Write("Dairenin Yarıçapını Giriniz :");

                if (!double.TryParse(Console.ReadLine(), out yaricap) || yaricap <= 0)
                {
                    Console.WriteLine("Geçersiz Değer Girdiniz. Lütfen Tekrar Deneyiniz.");
                    Console.WriteLine();
                    continue;
                }


                alanHesaplama = h1.alan(yaricap);
                cevreHesaplama = h1.cevre(yaricap);

            }


        }
    }
}
