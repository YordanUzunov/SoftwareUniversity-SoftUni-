using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetAssault
{
    class HornetAssault
    {
        static void Main(string[] args)
        {
            var beehives = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();
            var hornets = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            List<long> aliveBeeHive = new List<long>();

            foreach (var beehive in beehives)
            {
                if (hornets.Count == 0)
                {
                    aliveBeeHive.Add(beehive);
                    continue;
                }

                long power = hornets.Sum();

                if (power >= beehive)
                {
                    if (power == beehive)
                    {
                        hornets.RemoveAt(0);
                    }

                }
                else
                {
                    aliveBeeHive.Add(beehive - power);
                    hornets.RemoveAt(0);
                }
            }

            if (aliveBeeHive.Count != 0)
            {
                Console.WriteLine(string.Join(" ", aliveBeeHive));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
