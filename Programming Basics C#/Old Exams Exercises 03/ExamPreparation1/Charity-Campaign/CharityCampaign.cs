using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity_Campaign
{
    class CharityCampaign
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int cooks = int.Parse(Console.ReadLine());
            double cake = double.Parse(Console.ReadLine());
            double gof = double.Parse(Console.ReadLine());
            double pan = double.Parse(Console.ReadLine());

            cake = cake * 45;
            gof = gof * 5.80;
            pan = pan * 3.20;

            var sumperday = (cake + gof + pan) * cooks;
            var sumcamp = sumperday * days;
            var profit = sumcamp - (sumcamp / 8);
            Console.WriteLine("{0:f2}", profit);

        }
    }
}
