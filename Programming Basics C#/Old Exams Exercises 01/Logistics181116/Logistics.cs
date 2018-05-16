using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics181116
{
    class Logistics
    {
        static void Main(string[] args)
        {
            var broiT = double.Parse(Console.ReadLine());
            double sum = 0;
            double cena = 0;
            double totalCena = 0;
            double mikrobus = 0;
            double kamion = 0;
            double vlak = 0;

            for (int i = 0; i < broiT; i++)
            {
                var tovar = int.Parse(Console.ReadLine());
                if (tovar <= 3) { cena = 200 * tovar; mikrobus += tovar; }
                else if (tovar >= 4 && tovar <= 11) { cena = 175 * tovar; kamion += tovar; }
                else if (tovar >= 12) { cena = 120 * tovar; vlak += tovar; }
                sum = sum + tovar;
                totalCena = totalCena + cena;
            }
            double average = totalCena / sum;
            Console.WriteLine("{0:f2}", average);
            Console.WriteLine("{0:f2} %", ((mikrobus / sum)*100));
            Console.WriteLine("{0:f2} %", ((kamion / sum) * 100));
            Console.WriteLine("{0:f2} %", ((vlak / sum) * 100));

        }
    }
}
