using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetWings
{
    class HornetWings
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            double distance = (wingFlaps / 1000) * meters;
            double time = (wingFlaps / 100);
            double rest = (wingFlaps / endurance) * 5;
            double totalTime = time + rest;

            Console.WriteLine($"{distance:f2} m.");
            Console.WriteLine($"{totalTime} s.");
        }
    }
}
