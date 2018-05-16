using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckDriver190317
{
    class TruckDriver
    {
        static void Main(string[] args)
        {
            var season = Console.ReadLine();
            double km = double.Parse(Console.ReadLine());
            double salary = 0;
            double rate = 0;
            if (km <= 5000)
            {
                if (season == "Spring" || season == "Autumn") rate = 0.75;
                else if (season == "Summer") rate = 0.90;
                else if (season == "Winter") rate = 1.05;
            }
            else if (km > 5000 && km <= 10000)
            {
                if (season == "Spring" || season == "Autumn") rate = 0.95;
                else if (season == "Summer") rate = 1.10;
                else if (season == "Winter") rate = 1.25;
            }
            else if (km > 10000 && km <= 20000) rate = 1.45;

            salary = (km * rate * 4) - 0.1* (km * rate * 4);
            Console.WriteLine("{0:f2}", salary);
        }
    }
}
