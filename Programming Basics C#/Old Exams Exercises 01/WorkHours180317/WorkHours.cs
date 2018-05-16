using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkHours180317
{
    class WorkHours
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            double work = 0.0;
            double left = 0.0;
            double penalties = 0.0;

            work = workers * days * 8;

            if (work > hours)
            {
                left = Math.Abs(work - hours);
                Console.WriteLine("{0} hours left", left);
            }
            else if (work < hours)
            {
                left = Math.Abs(hours - work);
                penalties = left * days;
                Console.WriteLine("{0} overtime", left);
                Console.WriteLine("Penalties: {0}", penalties);
            }
        }
    }
}
