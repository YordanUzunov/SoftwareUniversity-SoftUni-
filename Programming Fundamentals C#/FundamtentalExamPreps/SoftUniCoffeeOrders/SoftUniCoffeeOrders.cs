using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace SoftUniCoffeeOrders
{
    class SoftUniCoffeeOrders
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal totalPrice = 0;

            for (int i = 0; i < n; i++)
            {
                decimal price = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy",CultureInfo.InvariantCulture);
                decimal capsulesNumber = decimal.Parse(Console.ReadLine());

                var daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);

                decimal sumOrder = daysInMonth * capsulesNumber * price;
                Console.WriteLine($"The price for the coffee is: ${sumOrder:f2}");
                totalPrice += sumOrder;
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
