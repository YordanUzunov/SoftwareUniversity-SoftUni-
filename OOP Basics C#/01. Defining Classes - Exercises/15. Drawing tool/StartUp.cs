﻿namespace _15._Drawing_tool
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var shape = Console.ReadLine();
            var width = double.Parse(Console.ReadLine());
            double height;

            if (shape == "Square")
            {
                height = width;
            }
            else
            {
                height = double.Parse(Console.ReadLine());
            }

            var figure = new DrawTool(width, height);
            Console.WriteLine(figure.Draw());
        }
    }
}
