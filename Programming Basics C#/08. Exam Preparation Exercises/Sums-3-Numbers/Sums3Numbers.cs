using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sums_3_Numbers
{
    class Sums3Numbers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            //if (a + b == c)
            //{
            //    if (a > b)
            //    {
            //        Console.WriteLine("{0} + {1} = {2}", b, a, c);
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0} + {1} = {2}", a, b, c);
            //    }
            //}

            //if (a + c == b)
            //{
            //    if (a < c)
            //    {
            //        Console.WriteLine("{0} + {1} = {2}", a, c, b);
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0} + {1} = {2}", c, a, b);
            //    }
            //}

            //if (b + c == a)
            //{
            //    if (b < c)
            //    {
            //        Console.WriteLine("{0} + {1} = {2}", b, c, a);
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0} + {1} = {2}", c, b, a);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("No");  
            //}
            int min = Math.Min(a, b);
            min = Math.Min(min, c);
            int max = Math.Max(a, b);
            max = Math.Max(c, max);
            int mid = 0;
            if (a > min && a < max) mid = a;
            else if (b > min && b < max) mid = b;
            else if (c > min && c < max) mid = c;
            else mid = min;
            if (!(min + mid == max)) Console.WriteLine("No");
            else Console.WriteLine("{0} + {1} = {2}", min, mid, max);
        }
    }
}
