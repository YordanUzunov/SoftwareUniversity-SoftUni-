using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Styrofoam190317
{
    class Styrofoam
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double totalArea = double.Parse(Console.ReadLine());
            double windows = double.Parse(Console.ReadLine());
            double styro = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());

            double area = (totalArea - windows * 2.4) * 1.1;
            double paketi = Math.Ceiling(area / styro);
            double paketiCena = paketi * price;

            if (paketiCena < budget)
            {
                Console.WriteLine("Spent: {0:f2}", paketiCena);
                Console.WriteLine("Left: {0:f2}", budget - paketiCena);
            }
            else if (paketiCena > budget) Console.WriteLine("Need more: {0:f2}", paketiCena - budget);
        }
    }
}
