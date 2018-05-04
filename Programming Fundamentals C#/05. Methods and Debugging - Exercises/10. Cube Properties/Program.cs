namespace _10._Cube_Properties
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double sideLength = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine().ToLower();  // (face, space, volume or area)

            switch (parameter)
            {
                case "face":
                    CubeFaceDiagonals(sideLength);
                    break;
                case "space":
                    CubeSpaceDiagonals(sideLength);
                    break;
                case "volume":
                    CubeVolume(sideLength);
                    break;
                case "area":
                    CubeSurfaceArea(sideLength);
                    break;
                default:
                    break;
            }
        }

        private static void CubeFaceDiagonals(double side)
        {
            Console.WriteLine("{0:f2}", Math.Sqrt(2 * (side * side)));
        }

        private static void CubeSpaceDiagonals(double side)
        {
            Console.WriteLine("{0:f2}", Math.Sqrt(3 * (side * side)));
        }

        private static void CubeVolume(double side)
        {
            Console.WriteLine("{0:f2}", side * side * side);
        }

        private static void CubeSurfaceArea(double side)
        {
            Console.WriteLine("{0:f2}", 6 * (side * side));
        }
    }
}
