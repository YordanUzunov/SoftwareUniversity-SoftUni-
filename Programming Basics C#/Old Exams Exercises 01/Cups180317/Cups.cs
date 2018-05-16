using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cups180317
{
    class Cups
    {
        static void Main(string[] args)
        {
            double brChashi = double.Parse(Console.ReadLine());
            double brRabotnici = double.Parse(Console.ReadLine());
            double brDni = double.Parse(Console.ReadLine());

            
            double izraboteniChashi = Math.Floor((brRabotnici * brDni * 8) / 5);
            double diff = Math.Abs(brChashi - izraboteniChashi);
            double profitLoss = diff * 4.2;
            if (izraboteniChashi < brChashi) Console.WriteLine("Losses: {0:f2}", profitLoss);
            else Console.WriteLine("{0:f2} extra money", profitLoss);
        }      
    }
}
