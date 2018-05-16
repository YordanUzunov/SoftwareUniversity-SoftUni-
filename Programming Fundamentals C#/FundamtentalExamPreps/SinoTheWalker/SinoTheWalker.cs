using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Diagnostics;

namespace SinoTheWalker
{
    class SinoTheWalker
    {

        static void Main(string[] args)
        {
            var time = Console.ReadLine();
            DateTime leavingTime = DateTime.ParseExact(time, "HH:mm:ss", null);
            int numberOfSteps = int.Parse(Console.ReadLine()) % 86400;
            int timeForStep = int.Parse(Console.ReadLine()) % 86400;

            DateTime result = leavingTime.AddSeconds(numberOfSteps * timeForStep);


            TimeSpan endResult = result.TimeOfDay;
            Console.WriteLine($"Time Arrival: {endResult}");

        }
    }
}
