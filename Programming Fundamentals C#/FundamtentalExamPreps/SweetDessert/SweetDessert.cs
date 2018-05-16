using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDessert
{
    class SweetDessert
    {
        static void Main(string[] args)
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());
            double priceBanan = double.Parse(Console.ReadLine());
            double priceEgg = double.Parse(Console.ReadLine());
            double priceBerries = double.Parse(Console.ReadLine());

            int portions = 0;
            if (guests > 0 && guests <= 6)
            {
                portions = 1;
            }
            else if (guests > 6)
            {
                if (guests % 6 == 0)
                {
                    portions = guests / 6;
                }
                else
                {
                    portions = guests / 6 + 1;
                }
            }

            decimal moneyNeeded = (decimal)(portions * (2 * priceBanan) + portions * (4 * priceEgg) + portions * (0.2 * priceBerries));

            if (moneyNeeded <= cash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {moneyNeeded:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {moneyNeeded - cash:f2}lv more.");
            }

        }
    }
}
