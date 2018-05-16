using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarToGo180317
{
    class CarToGo
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var klas = "a";
            var car = "b";
            double price = 0; 

            if (budget <= 100)
            {
                klas = "Economy class";
                if (season == "Summer")
                {
                    price = 0.35 * budget;
                    car = "Cabrio";
                }
                else if (season == "Winter")
                {
                    price = 0.65 * budget;
                    car = "Jeep";
                }
            }
            else if (budget > 100 && budget <= 500)
            {
                klas = "Compact class";
                if (season == "Summer")
                {
                    price = 0.45 * budget;
                    car = "Cabrio";
                }
                else if (season == "Winter")
                {
                    price = 0.80 * budget;
                    car = "Jeep";
                }
            }
            else if (budget > 500)
            {
                klas = "Luxury class";
                price = 0.90 * budget;
                car = "Jeep";
            }
            Console.WriteLine(klas);
            Console.WriteLine("{0} - {1:f2}", car,price);
        }
    }
}
