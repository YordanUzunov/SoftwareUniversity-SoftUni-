namespace _05._Rounding_Numbers_Away_from_Zero
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string[] stringNums = input.Split();
            double[] numbers = new double[stringNums.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(stringNums[i]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("{0} => {1}", numbers[i], Math.Round(numbers[i], MidpointRounding.AwayFromZero));
            }
        }
    }
}
