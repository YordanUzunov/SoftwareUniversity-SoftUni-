namespace _03._Printing_Triangle
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int triangleTopNumber = int.Parse(Console.ReadLine());
            for (int i = 1; i <= triangleTopNumber; i++)
            {
                PrintLine(1, i);
            }

            for (int i = triangleTopNumber - 1; i > 0; i--)
            {
                PrintLine(1, i);
            }
        }

        public static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }
    }
}
