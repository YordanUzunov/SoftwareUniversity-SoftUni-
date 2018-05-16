using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousDownsite
{
    class AnonymousDownsite
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());

            StringBuilder affectedSites = new StringBuilder();
            decimal totalLoss = 0M;

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string siteName = tokens[0];
                long siteVisits = long.Parse(tokens[1]);
                decimal pricePerVisit = decimal.Parse(tokens[2]);

                affectedSites.AppendLine(siteName);

                totalLoss += siteVisits * pricePerVisit;
            }

            Console.Write(affectedSites);

            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            Console.WriteLine($"Security Token: {BigInteger.Pow(securityKey, n)}");
        }
    }
}
