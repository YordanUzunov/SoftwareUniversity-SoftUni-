using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choreography
{
    class Choreography
    {
        static void Main(string[] args)
        {
            var steps = int.Parse(Console.ReadLine());
            var dancers = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            double stepsPerDay = 0.0;

            stepsPerDay = steps / days;
            int percentStepsDay = (int)Math.Ceiling((double)(100 * stepsPerDay) / steps);
            double percentStepsDancer = (double)percentStepsDay / dancers;

            if (percentStepsDay <= 13.00)
            {
                Console.WriteLine("Yes, they will succeed in that goal! {0:f2}%.", percentStepsDancer);
            }
            else
            {
                Console.WriteLine("No, They will not succeed in that goal! Required {0:f2}% steps to be learned per day.", percentStepsDancer);
            }
        }
    }
}
