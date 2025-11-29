using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace not_ortalamasi_hesapla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            hesap h1 = new hesap();
            double vize, final, butunleme;
            double vizeDeğer = 0,finalDeğer=0,butunlemeDeğer=0;

            Console.Write("Vize Notunu Giriniz: ");
            double.TryParse(Console.ReadLine(), out vize);
            vizeDeğer=h1.vize(vize);

            Console.Write("Final Notunu Giriniz: ");
            double.TryParse(Console.ReadLine(), out final);
            finalDeğer=h1.final(final);

            Console.Write("Bütünleme Notunu Giriniz: ");
            double.TryParse(Console.ReadLine(), out butunleme);
            butunlemeDeğer=h1.butunle(butunleme);

            Console.WriteLine("Not Ortalaması Hesaplanıyor...");
            h1.orthsp(vizeDeğer, finalDeğer, butunlemeDeğer);





        }
    }
}
