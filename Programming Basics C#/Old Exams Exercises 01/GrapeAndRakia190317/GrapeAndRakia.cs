using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrapeAndRakia190317
{
    class GrapeAndRakia
    {
        static void Main(string[] args)
        {
            var loze = double.Parse(Console.ReadLine());
            var dobiv = double.Parse(Console.ReadLine());
            var brak = double.Parse(Console.ReadLine());

            double totalGrozde = (loze * dobiv) - brak;
            double rakiaProfit = ((0.45 * totalGrozde) / 7.5) * 9.80;
            double grozdeProfit = 0.55 * totalGrozde * 1.5;
            Console.WriteLine("{0:f2}", rakiaProfit);
            Console.WriteLine("{0:f2}", grozdeProfit);
        }
    }
}
