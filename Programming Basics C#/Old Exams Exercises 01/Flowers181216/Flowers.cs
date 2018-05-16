using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers181216
{
    class Flowers
    {
        static void Main(string[] args)
        {
            double hrizantemi = double.Parse(Console.ReadLine());
            double rozi = double.Parse(Console.ReadLine());
            double laleta = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string praznik = Console.ReadLine();
            double cenaHrizantemi = 0;
            double cenaRozi = 0;
            double cenaLaleta = 0;
            double totalCvetq = hrizantemi + rozi + laleta;
            

            if (season == "Spring" && praznik == "N") { cenaHrizantemi = hrizantemi * 2; cenaRozi = rozi * 4.10; cenaLaleta = laleta * 2.50; }
            if (season == "Spring" && praznik == "Y") { cenaHrizantemi = hrizantemi * 2* 1.15; cenaRozi = rozi * 4.10* 1.15; cenaLaleta = laleta * 2.50 *1.15; }
            if (season == "Summer" && praznik == "N") { cenaHrizantemi = hrizantemi * 2; cenaRozi = rozi * 4.10; cenaLaleta = laleta * 2.50; }
            if (season == "Summer" && praznik == "Y") { cenaHrizantemi = hrizantemi * 2* 1.15; cenaRozi = rozi * 4.10* 1.15; cenaLaleta = laleta * 2.50 * 1.15; }
            if (season == "Autumn" && praznik == "N") { cenaHrizantemi = hrizantemi * 3.75; cenaRozi = rozi * 4.50; cenaLaleta = laleta * 4.15; }
            if (season == "Autumn" && praznik == "Y") { cenaHrizantemi = hrizantemi * 3.75 * 1.15; cenaRozi = rozi * 4.50 * 1.15; cenaLaleta = laleta * 4.15 * 1.15; }
            if (season == "Winter" && praznik == "N") { cenaHrizantemi = hrizantemi * 3.75; cenaRozi = rozi * 4.50; cenaLaleta = laleta * 4.15; }
            if (season == "Winter" && praznik == "Y") { cenaHrizantemi = hrizantemi * 3.75 * 1.15; cenaRozi = rozi * 4.50 * 1.15; cenaLaleta = laleta * 4.15 * 1.15; }
            double totalCena = cenaHrizantemi + cenaRozi + cenaLaleta;

            if (season == "Spring" && laleta > 7) totalCena = totalCena * 0.95; else totalCena = totalCena * 1;

            if (season == "Winter" && rozi >= 10) totalCena = totalCena * 0.90; else totalCena = totalCena * 1;

            if (totalCvetq > 20) totalCena = totalCena * 0.80; else totalCena = totalCena * 1;
            Console.WriteLine("{0:f2}",(totalCena +2));
        }
    }
}
