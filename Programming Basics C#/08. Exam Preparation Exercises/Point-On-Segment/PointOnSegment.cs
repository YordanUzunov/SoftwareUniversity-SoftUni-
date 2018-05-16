using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_On_Segment
{
    class PointOnSegment
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int point = int.Parse(Console.ReadLine());

            var left = Math.Min(first, second);
            var right = Math.Max(first, second);

            var distanceLeft = Math.Abs(left - point);
            var distanceRight = Math.Abs(right - point);

            if (point >= left && point <= right) Console.WriteLine("in");
            else Console.WriteLine("out");
            Console.WriteLine(Math.Min(distanceLeft,distanceRight));
        }
    }
}
