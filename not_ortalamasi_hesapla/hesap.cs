using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace not_ortalamasi_hesapla
{
    internal class hesap
    {
        public hesap()
        {

        }

        public double vize(double vize)
        {
            double vizeDeğer = 0;
            vizeDeğer= vize * 0.4;
            Console.WriteLine("Vize Notu Değeri: {0}", vizeDeğer);
           Console.WriteLine();
            return vizeDeğer;
        }
        public double final(double final)
        {
            double finalDeğer = 0;
            finalDeğer = final * 0.6;
            Console.WriteLine("Final Notu Değeri : {0}", finalDeğer);
            Console.WriteLine();
            return finalDeğer;
        }
        public double butunle(double butunleme)
        {
            double butunlemeDeğer = 0;
            butunlemeDeğer = butunleme * 0.5;
            Console.WriteLine("Bütünleme Notu Değeri : {0}", butunlemeDeğer);
            Console.WriteLine();
            return butunlemeDeğer;
        }
        public void orthsp(double vizeDeğer,double finalDeğer,double butunlemeDeğer)
        {
            double ortalama = 0;
            ortalama=((vizeDeğer + finalDeğer + butunlemeDeğer)/3);
            Console.WriteLine("Not Ortalaması: " + ortalama);
        }
    }
}
