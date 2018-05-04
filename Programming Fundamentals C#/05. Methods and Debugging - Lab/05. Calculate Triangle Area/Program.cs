namespace _05._Calculate_Triangle_Area
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double baseLength = double.Parse(Console.ReadLine());
            double haightLength = double.Parse(Console.ReadLine());
            Console.WriteLine(TriangleArea(baseLength, haightLength));
        }

        private static double TriangleArea(double baseLength, double haightLength)
        {
            return baseLength * haightLength / 2;
        }
    }
}
