using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kdv_hesabi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculus b1 = new calculus();
            double kdvRate, price;
            Console.Write("Lütfen fiyatı giriniz: ");
            double.TryParse(Console.ReadLine(), out price);

            Console.Write("Lütfen KDV oranını giriniz: ");
            double.TryParse(Console.ReadLine(), out kdvRate);
            b1.kdvCalculator(price, kdvRate);
            
        }
    }
}
