using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hipotenus_hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            hesapla h1 = new hesapla();

            while (true)
            {
                double kenar1 = 0, kenar2 = 0;
                double hipotenusHesaplama = 0;

                Console.Write("1.kenarı giriniz: ");
                if (!double.TryParse(Console.ReadLine(), out kenar1) || kenar1 <= 0)
                {
                    Console.WriteLine(" Hatalı Değer Girdiniz.");
                    Console.WriteLine(" Lütfen Tekrardan Değer Giriniz.");
                    Console.WriteLine();
                    continue;

                }

                Console.Write("2.kenarı giriniz: ");
                if (!double.TryParse(Console.ReadLine(), out kenar2) || kenar2 <= 0)
                {
                    Console.WriteLine(" Hatalı Değer Girdiniz.");
                    Console.WriteLine(" Lütfen Tekrardan Değer Giriniz.");
                    Console.WriteLine();
                    continue;

                }
                hipotenusHesaplama = h1.hipotenus(kenar1,kenar2);



            }


        }
    }
}
