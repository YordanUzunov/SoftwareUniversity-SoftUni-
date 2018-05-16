using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishland201116
{
    class Fishland
    {
        static void Main(string[] args)
        {
            var skumria = double.Parse(Console.ReadLine());
            var caca = double.Parse(Console.ReadLine());
            var palamud = double.Parse(Console.ReadLine());
            var safrid = double.Parse(Console.ReadLine());
            var midi = double.Parse(Console.ReadLine());

            double palamudCena = skumria * 1.60;
            double safridCena = caca * 1.8;
            double totalCena = (palamud * palamudCena + safrid * safridCena + midi * 7.50);
            Console.WriteLine("{0:f2}", totalCena);
        }
    }
}
