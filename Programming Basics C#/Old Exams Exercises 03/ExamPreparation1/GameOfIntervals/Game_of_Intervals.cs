using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfIntervals
{
    class Game_of_Intervals
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (num >= 0 && num <=9) sum = sum + num * 0.2;
                if (num >= 10 && num <= 19) sum = sum + num * 0.3;
                if (num >= 20 && num <= 29) sum = sum + num * 0.4;
                if (num >= 30 && num <= 39) sum += 50;
                if (num >= 40 && num <= 50) sum += 100;
                if (num < 0 || num > 50) sum = sum / 2;
            }
            Console.WriteLine("{0:f2}", sum);

        }
    }
}
