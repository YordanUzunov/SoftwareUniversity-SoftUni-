using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanceHall
{
    class DanceHall
    {
        static void Main(string[] args)
        {
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var sqside = double.Parse(Console.ReadLine());
            double hallArea = 0;
            double wardrobe = 0;
            double bench = 0;
            double freeArea = 0;
            double dancer = 40;
            double dancerSpace = 7000;
            double numberDancers = 0;

            hallArea = (length * 100) * (width * 100);
            wardrobe = (sqside * 100) * (sqside * 100);
            bench = hallArea / 10;
            freeArea = hallArea - wardrobe - bench;

            numberDancers = freeArea / (dancer + dancerSpace);
            Console.WriteLine(Math.Floor(numberDancers));

        }
    }
}
