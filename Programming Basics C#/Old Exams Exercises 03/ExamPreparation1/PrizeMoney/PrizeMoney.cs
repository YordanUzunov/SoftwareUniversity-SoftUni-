using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizeMoney
{
    class PrizeMoney
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var reward = double.Parse(Console.ReadLine());
            double totalPoints = 0;
            double prize = 0;

            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (i % 2 == 0) totalPoints += num * 2;
                else totalPoints += num;
            }

            prize = totalPoints * reward;
            Console.WriteLine("The project prize was {0:f2} lv.", prize);
        }
    }
}
