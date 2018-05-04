namespace _08._Center_Point
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double p1x = double.Parse(Console.ReadLine());
            double p1y = double.Parse(Console.ReadLine());
            double p2x = double.Parse(Console.ReadLine());
            double p2y = double.Parse(Console.ReadLine());
            CloserToCenterPoint(p1x, p1y, p2x, p2y);
        }

        private static void CloserToCenterPoint(double p1x, double p1y, double p2x, double p2y)
        {
            double firstPointDistance = Math.Sqrt((p1x * p1x) + (p1y * p1y));
            double secondPointDistance = Math.Sqrt((p2x * p2x) + (p2y * p2y));
            Console.WriteLine((firstPointDistance > secondPointDistance) ? $"({p2x}, {p2y})" : $"({p1x}, {p1y})");
        }
    }
}
