using System;

namespace _06._Min_Number
{
    public class Program
    {
        public static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());
            double min = double.Parse(Console.ReadLine());
            for (int i = 1; i < numbers; i++)
            {
                double n = double.Parse(Console.ReadLine());
                if (n < min) min = n;
            }
            Console.WriteLine(min);
        }
    }
}
