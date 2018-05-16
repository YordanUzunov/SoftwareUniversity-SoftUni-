using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bills190317
{
    class Bills
    {
        static void Main(string[] args)
        {
            
            var voda = 20;
            var internet = 15;
            double meseci = double.Parse(Console.ReadLine());
            double tokSum = 0;
            double drugi = 0;
            double drugiSum = 0;

            for (int i = 1; i <= meseci; i++)
            {
                double tok = double.Parse(Console.ReadLine());
                tokSum = tokSum + tok;
                drugi = (tok + voda + internet) * 1.2;
                drugiSum = drugiSum + drugi;
            }

            double vodaSum = meseci * voda;
            double internetSum = meseci * internet;
            double average = (tokSum + vodaSum + internetSum + drugiSum) / meseci;

            Console.WriteLine("Electricity: {0:f2} lv", tokSum);
            Console.WriteLine("Water: {0:f2} lv", vodaSum);
            Console.WriteLine("Internet: {0:f2} lv", internetSum);
            Console.WriteLine("Other: {0:f2} lv", drugiSum);
            Console.WriteLine("Average: {0:f2} lv", average);
        }
    }
}
