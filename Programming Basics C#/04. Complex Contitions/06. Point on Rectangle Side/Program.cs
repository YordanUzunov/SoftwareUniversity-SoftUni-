﻿namespace _06._Point_on_Rectangle_Side
{
    using System;

    public class Program
    {
        public static void Main()
        {
            // Inherent condition: x1 < x2 && y1 < y2
            // Input: (Rectangle: x1, y1, x2, y2) (Point: x , y)
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            if (x == x1 && y >= y1 && y <= y2 || x == x2 && y >= y1 && y <= y2 || 
                y == y1 && x >= x1 && x <= x2 || y == y2 && x >= x1 && x <= x2)
                Console.WriteLine("Border");
            else Console.WriteLine("Inside / Outside");
        }
    }
}
