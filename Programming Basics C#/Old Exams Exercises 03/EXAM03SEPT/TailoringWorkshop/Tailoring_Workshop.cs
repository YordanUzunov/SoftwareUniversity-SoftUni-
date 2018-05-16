using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailoringWorkshop
{
    class Tailoring_Workshop
    {
        static void Main(string[] args)
        {
            var tables = int.Parse(Console.ReadLine());
            var L = double.Parse(Console.ReadLine());
            var W = double.Parse(Console.ReadLine());

            double Apokrivki = tables * (L + 2 * 0.30) * (W + 2 * 0.30);
            double Akareta = tables * (L / 2) * (L / 2);

            double DollarPrice = Apokrivki * 7 + Akareta * 9;
            double LevPrice = DollarPrice * 1.85;

            Console.WriteLine("{0:f2} USD", DollarPrice);
            Console.WriteLine("{0:f2} BGN", LevPrice);
        }
    }
    
}
