using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitCocktails
{
    class FruitCocktails
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine();
            var size = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());
            double price = 0;
            double discount = 0;
            double totalPrice = 0;

            if (fruit == "Watermelon" && size == "small")
            {
                price = quantity * 2 * 56;
            }
            else if (fruit == "Watermelon" && size == "big")
            {
                price = quantity * 5 * 28.70;
            }

            if (fruit == "Mango" && size == "small")
            {
                price = quantity * 2 * 36.66;
            }
            else if (fruit == "Mango" && size == "big")
            {
                price = quantity * 5 * 19.60;
            }

            if (fruit == "Pineapple" && size == "small")
            {
                price = quantity * 2 * 42.10;
            }
            else if (fruit == "Pineapple" && size == "big")
            {
                price = quantity * 5 * 24.80;
            }

            if (fruit == "Raspberry" && size == "small")
            {
                price = quantity * 2 * 20;
            }
            else if (fruit == "Raspberry" && size == "big")
            {
                price = quantity * 5 * 15.20;
            }

            if (price >= 400 && price <= 1000)
            {
                discount = price * 0.15;
            }
            else if (price > 1000)
            {
                discount = price * 0.5;

            }

            totalPrice = price - discount;
            Console.WriteLine("{0:f2} lv.", totalPrice);
        }
    }
}
