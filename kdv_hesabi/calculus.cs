using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kdv_hesabi
{
    internal class calculus
    {
        public calculus()
        {
        }

        public void kdvCalculator(double price,double kdvRate)
        {

            double result = 0,kdvliPrice=0;

            result = price * (kdvRate / 100); // kdv tutarını hesapla
            Console.WriteLine("KDV Tutarı: " + result);
            kdvliPrice = price + result;
            Console.WriteLine("KDV'li Fiyat: "+kdvliPrice );
            result = price+result;


        }
    }
}
