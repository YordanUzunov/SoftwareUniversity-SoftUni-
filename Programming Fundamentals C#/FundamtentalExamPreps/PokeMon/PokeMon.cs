using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeMon
{
    class PokeMon
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionF = int.Parse(Console.ReadLine());
            double startPower = power;
            int pokesCount = 0;

            while (power >= distance)
            {
                power = power - distance;
                pokesCount++;
                if (power == (0.5 * startPower) && exhaustionF != 0)
                {
                    power = power / exhaustionF;
                }

            }

            Console.WriteLine(power);
            Console.WriteLine(pokesCount);

        }
    }
}
