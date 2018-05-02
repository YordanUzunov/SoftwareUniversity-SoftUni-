namespace _13._Area_Of_Figures
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string figureType = Console.ReadLine();
            if (figureType.Equals("square"))
            {
                Console.WriteLine(squareArea());
            }
            else if (figureType.Equals("rectangle"))
            {
                Console.WriteLine(rectangleArea());
            }
            else if (figureType.Equals("circle"))
            {
                Console.WriteLine(circleArea());
            }
            else if (figureType.Equals("triangle"))
            {
                Console.WriteLine(triangleArea());
            }
  
        }

        private static double triangleArea()
        {
            double baseSide = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            return Math.Round((h * baseSide) / 2, 3);
        }
        private static double circleArea()
        {
            double radius = double.Parse(Console.ReadLine());
            return Math.Round(Math.PI * radius * radius, 3);
        }
        private static double rectangleArea()
        {
            double side1 = double.Parse(Console.ReadLine());
            double side2 = double.Parse(Console.ReadLine());
            return Math.Round(side1 * side2, 3);
        }
        private static double squareArea()
        {
            double side = double.Parse(Console.ReadLine());
            return Math.Round(side * side, 3);
        }
    }
}
