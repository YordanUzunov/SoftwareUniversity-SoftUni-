using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance181216
{
    class Distance
    {
        static void Main(string[] args)
        {
            double speed1 = double.Parse(Console.ReadLine());
            double time1 = double.Parse(Console.ReadLine());
            double time2 = double.Parse(Console.ReadLine());
            double time3 = double.Parse(Console.ReadLine());

            double dist1 = speed1 * (time1 / 60);
            double dist2 = speed1 * 1.1 * (time2 / 60);
            double dist3 = (speed1 * 1.1) * 0.95 * (time3 / 60);

            Console.WriteLine("{0:f2}", (dist1+dist2+dist3));
        }
    }
}
