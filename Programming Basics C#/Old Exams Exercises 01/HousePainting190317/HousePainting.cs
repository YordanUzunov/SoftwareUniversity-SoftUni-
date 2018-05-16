using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePainting190317
{
    class HousePainting
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            double areaGreen = 0;
            double areaRed = 0;
            double paintRed = 0;
            double paintGreen = 0;

            areaGreen = 2 * (x * x) - (1.2 * 2) + 2 * ((x * y) - (1.5 * 1.5));
            areaRed = 2 * (x * y) + 2 * ((x * h) / 2);
            paintGreen = areaGreen / 3.4;
            paintRed = areaRed / 4.3;
            Console.WriteLine("{0:f2}",paintGreen);
            Console.WriteLine("{0:f2}", paintRed);
        }
    }
}
