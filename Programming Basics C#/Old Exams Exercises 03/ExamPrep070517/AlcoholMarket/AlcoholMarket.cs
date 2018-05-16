using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholMarket
{
    class AlcoholMarket
    {
        static void Main(string[] args)
        {
            var whiskeyPrice = double.Parse(Console.ReadLine());
            var beer = double.Parse(Console.ReadLine());
            var wine = double.Parse(Console.ReadLine());
            var rakia = double.Parse(Console.ReadLine());
            var whiskey = double.Parse(Console.ReadLine());
            double beerPrice = 0;
            double winePrice = 0;
            double rakiaPrice = 0;
            double totalPrice = 0;

            rakiaPrice = whiskeyPrice * 0.5;
            winePrice = rakiaPrice - (rakiaPrice * 0.4);
            beerPrice = rakiaPrice - (rakiaPrice * 0.8);
            totalPrice = (whiskeyPrice * whiskey) + (beerPrice * beer) + (winePrice * wine) + (rakiaPrice * rakia);
            Console.WriteLine("{0:f2}", totalPrice);
        }
       
    }
}
