namespace _05._Max_Number
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());
            double max = double.Parse(Console.ReadLine());
            for (int i = 1; i < numbers; i++)
            {
                double n = double.Parse(Console.ReadLine());
                if (n > max) max = n;
            }
            Console.WriteLine(max);
        }
    }
}
