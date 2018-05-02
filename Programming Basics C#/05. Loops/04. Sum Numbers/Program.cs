namespace _04._Sum_Numbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int numbersCount = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 0; i < numbersCount; i++)
            {
                double number = double.Parse(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
