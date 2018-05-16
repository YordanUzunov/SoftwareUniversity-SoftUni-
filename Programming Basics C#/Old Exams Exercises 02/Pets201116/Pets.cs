using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets201116
{
    class Pets
    {
        static void Main(string[] args)
        {
            var days = double.Parse(Console.ReadLine());
            var food = double.Parse(Console.ReadLine());
            var dog = double.Parse(Console.ReadLine());
            var cat = double.Parse(Console.ReadLine());
            var turtle = double.Parse(Console.ReadLine());

            double totalFoodNeed = (dog * days + cat * days + (turtle / 1000 * days));
            if (totalFoodNeed <= food) Console.WriteLine("{0} kilos of food left.", Math.Floor(food - totalFoodNeed));
            if (totalFoodNeed > food) Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(totalFoodNeed - food));
        }
    }
}
