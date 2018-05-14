namespace _03._Custom_Min_Function
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ', '\r', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Func<double[], double> minFunc = GetMin;

            var minNumber = minFunc(numbers);

            Console.WriteLine(minNumber);
        }

        private static double GetMin(double[] numbers)
        {
            var min = double.MaxValue;

            foreach (var num in numbers)
            {
                if (num < min)
                {
                    min = num;
                }
            }

            return min;
        }
    }
}
