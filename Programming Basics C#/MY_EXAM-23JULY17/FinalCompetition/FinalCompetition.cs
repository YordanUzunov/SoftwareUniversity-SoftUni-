using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCompetition
{
    class FinalCompetition
    {
        static void Main(string[] args)
        {
            var dancers = int.Parse(Console.ReadLine());
            var points = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var place = Console.ReadLine();
            double totalMoney = 0.0;
            double expenses = 0.0;

            if (place == "Bulgaria" && season == "summer")
            {
                totalMoney = dancers * points;
                expenses = totalMoney * 0.05;
            }
            else if (place == "Bulgaria" && season == "winter")
            {
                totalMoney = dancers * points;
                expenses = totalMoney * 0.08;
            }
            else if (place == "Abroad" && season == "summer")
            {
                totalMoney = (dancers * points) + 0.5 * (dancers * points);
                expenses = totalMoney * 0.10;
            }
            else if (place == "Abroad" && season == "winter")
            {
                totalMoney = (dancers * points) + 0.5 * (dancers * points);
                expenses = totalMoney * 0.15;
            }

            double profit = totalMoney - expenses;
            double charity = 0.75 * profit;
            double leftMoney = profit - charity;
            double moneyPerDancer = leftMoney / dancers;

            Console.WriteLine("Charity - {0:f2}", charity);
            Console.WriteLine("Money per dancer - {0:f2}", moneyPerDancer);
        }
    }
}
