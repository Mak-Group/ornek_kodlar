using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucak_bileti_hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            hesaplama h1 = new hesaplama();

            while (true)
            {
                double mil = 0, yas = 0, yolculukTipi = 0;

                Console.Write(" Mil Değerini Giriniz :");
                if (!double.TryParse(Console.ReadLine(), out mil)||mil<=0)
                {
                    Console.WriteLine("Hatalı Giriş Yaptınız. Lütfen Yeni Mil Değerini Giriniz.");
                    continue;
                }

                Console.Write(" Yas Değerini Giriniz :");
                if (!double.TryParse(Console.ReadLine(), out yas)||yas<=0)
                {
                    Console.WriteLine("Hatalı Giriş Yaptınız. Lütfen Yeni Yaş Değerini Giriniz.");
                    continue;
                }

                Console.Write(" Yolculuk Tipini Giriniz (1 = Tek Yön , 2 = Gidiş Dönüş) :");
                if (!double.TryParse(Console.ReadLine(), out yolculukTipi) || (yolculukTipi != 1 && yolculukTipi != 2))
                {
                    Console.WriteLine("Hatalı Giriş Yaptınız. Lütfen Yeni Yolculuk Tipi Değerini Giriniz.");
                    continue;
                }

                double toplamTutar = h1.biletHesapla(mil, yas, yolculukTipi);
                Console.WriteLine("Toplam Tutar : " + toplamTutar + " TL");

            }
            
                
                


        }
    }
}