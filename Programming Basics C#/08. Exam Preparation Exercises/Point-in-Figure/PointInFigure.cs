using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_in_Figure
{
    class PointInFigure
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            //bool fig1 = false;
            //bool fig2 = false;

            //if (x >= 4 && x <= 10 && y <= 3 && y >= -5)
            //{
            //    fig1 = true;
            //}
            //if (x >= 2 && x <= 12 && y <= 1 && y >= -3)
            //{
            //    fig2 = true;
            //}

            //if (fig1 || fig2)
            //{
            //    Console.WriteLine("in");
            //}
            //else
            //{
            //    Console.WriteLine("out");
            //}

            bool pointInRec1 = x >= 2 && x <= 12 && y <= 1 && y >= -3;
            bool pointInRec2 = x >= 4 && x <= 10 && y <= 3 && y >= -5;

            if (pointInRec1 || pointInRec2) Console.WriteLine("in");
            else Console.WriteLine("out");
        }
    }
}
