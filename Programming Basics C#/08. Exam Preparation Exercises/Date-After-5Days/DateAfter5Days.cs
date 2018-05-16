using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_After_5Days
{
    class DateAfter5Days
    {
        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int daysInMonth = 31;
            if (m == 2) daysInMonth = 28;
            else if (m == 4 || m == 6 || m == 9 || m == 11) daysInMonth = 30;
            //{
            //    daysInMonth = 28;
            //}
            //if (m == 4 || m == 6 || m == 9 || m == 11)
            //{
            //    daysInMonth = 30;
            //}

            d += 5;
            if (d <= daysInMonth)
            {
                Console.WriteLine("{0}.{1:00}", d,m);
            }
            else
            {
                if(m + 1 <= 12)
                Console.WriteLine("{0}.{1:00}", d - daysInMonth, m+1);
                else
                    Console.WriteLine("{0}.{1:00}", d - daysInMonth, 1);
            }
        }
    }
}
