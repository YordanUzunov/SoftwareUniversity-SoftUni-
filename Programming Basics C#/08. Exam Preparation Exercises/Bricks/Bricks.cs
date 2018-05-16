using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bricks
{
    class Bricks
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int bricksInOneCourse = w * m;
            double totalCourses = Math.Ceiling((double)x / bricksInOneCourse);
            Console.WriteLine(totalCourses);
        }
    }
}
