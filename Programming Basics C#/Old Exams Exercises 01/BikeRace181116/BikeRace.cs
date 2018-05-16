using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRace181116
{
    class BikeRace
    {
        static void Main(string[] args)
        {
            var juniorN = double.Parse(Console.ReadLine());
            var seniorN = double.Parse(Console.ReadLine());
            var trace = Console.ReadLine();
            double juniorFee = 0;
            double seniorFee = 0;

            if (trace == "cross-country" && (juniorN + seniorN) < 50) { juniorFee = 8; seniorFee = 9.50; }
            if (trace == "cross-country" && (juniorN + seniorN) >= 50) { juniorFee = 8 * 0.75; seniorFee = 9.50 * 0.75; }
            if (trace == "trail") { juniorFee = 5.5; seniorFee = 7; }
            if (trace == "downhill") { juniorFee = 12.25; seniorFee = 13.75; }
            if (trace == "road") { juniorFee = 20; seniorFee = 21.50; }

            double suma = (juniorN * juniorFee + seniorN * seniorFee) * 0.95;
            Console.WriteLine("{0:f2}", suma);
        }
    }
}
