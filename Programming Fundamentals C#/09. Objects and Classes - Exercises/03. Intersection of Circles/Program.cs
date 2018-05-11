namespace _03._Intersection_of_Circles
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Circle c1 = GetInputAndSetCircle();
            Circle c2 = GetInputAndSetCircle();
            Console.WriteLine(c1.Intersect(c2) ? "Yes" : "No");
        }

        private static Circle GetInputAndSetCircle()
        {
            Circle result = new Circle();
            double[] input = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            result.Center = new Point() { X = input[0], Y = input[1] };
            result.Radius = input[2];
            return result;
        }
    }
}
