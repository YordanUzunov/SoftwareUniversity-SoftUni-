namespace _19._Histogram
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int numbersCount = int.Parse(Console.ReadLine());

            double upTo_199 = 0, _200_399 = 0, _400_599 = 0, _600_799 = 0, GreaterThan_800 = 0;

            for (int i = 0; i < numbersCount; i++)
            {
                double n = int.Parse(Console.ReadLine());
                if (n < 200) upTo_199++;
                else if (n < 400) _200_399++;
                else if (n < 600) _400_599++;
                else if (n < 800) _600_799++;
                else GreaterThan_800++;
            }
            Console.WriteLine((upTo_199 / numbersCount).ToString("0.00%"));
            Console.WriteLine((_200_399 / numbersCount).ToString("0.00%"));
            Console.WriteLine((_400_599 / numbersCount).ToString("0.00%"));
            Console.WriteLine((_600_799 / numbersCount).ToString("0.00%"));
            Console.WriteLine((GreaterThan_800 / numbersCount).ToString("0.00%"));
        }
    }
}
