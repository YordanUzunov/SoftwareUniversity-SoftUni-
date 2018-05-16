using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePrice181116
{
    class HousePrice
    {
        static void Main(string[] args)
        {
            var smallR = double.Parse(Console.ReadLine());
            var kitchen = double.Parse(Console.ReadLine());
            var cena = double.Parse(Console.ReadLine());

            double room2 = smallR * 1.1;
            double room3 = room2 * 1.1;
            double banq = smallR / 2;
            double space = (smallR + kitchen + room2 + room3 + banq) + 0.05 * (smallR + kitchen + room2 + room3 + banq);
            double total = space * cena;
            Console.WriteLine("{0:f2}", total);
        }
    }
}
