using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
    class EnergyLoss
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var a = int.Parse(Console.ReadLine());
            double energySpend = 0;
            double totalEnergyLeft = 0.0;
            double freeEnergyDancer = 0.0;
            double dayEnergy = 100.00;

            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (i % 2 == 0 && num % 2 == 0)
                {
                    energySpend = 68;
                    totalEnergyLeft += (a * (dayEnergy - energySpend));
                }
                else if (i % 2 == 0 && num % 2 == 1)
                {
                    energySpend = 65;
                    totalEnergyLeft += (a * (dayEnergy - energySpend));
                }
                else if (i % 2 == 1 && num % 2 == 0)
                {
                    energySpend = 49;
                    totalEnergyLeft += (a * (dayEnergy - energySpend));
                }
                else if (i % 2 == 1 && num % 2 == 1)
                {
                    energySpend = 30;
                    totalEnergyLeft += (a * (dayEnergy - energySpend));
                }
            }
            freeEnergyDancer = (totalEnergyLeft / a) / n;

            if (freeEnergyDancer >= 50.00) Console.WriteLine("They feel good! Energy left: {0:f2}", freeEnergyDancer);
            else Console.WriteLine("They are wasted! Energy left: {0:f2}", freeEnergyDancer);
        }
    }
}
