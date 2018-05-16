using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnduranceRally
{
    class EnduranceRally
    {
        static void Main()
        {
            var drivers = Console.ReadLine().Split(' ').ToArray();
            var zones = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var checkpoints = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            foreach (var driver in drivers)
            {

                char firstLetter = driver[0];
                double fuel = firstLetter;
                int reachedZone = 0;
                bool fuelLeft = true;
                for (int i = 0; i < zones.Length; i++)
                {
                    if (checkpoints.Contains(i))
                    {
                        fuel = fuel + zones[i];
                        reachedZone++;
                    }
                    else
                    {
                        fuel = fuel - zones[i];
                        if (fuel <= 0)
                        {
                            fuelLeft = false;
                            Console.WriteLine($"{driver} - reached {reachedZone}");
                            break;
                        }
                        reachedZone++;
                    }
                }
                if (fuelLeft)
                {
                    Console.WriteLine($"{driver} - fuel left {fuel:f2}");
                }
            }
        }
    }
}
