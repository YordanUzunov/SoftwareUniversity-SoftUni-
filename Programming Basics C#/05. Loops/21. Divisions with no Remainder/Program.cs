namespace _21._Divisions_with_no_Remainder
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int numbersCount = int.Parse(Console.ReadLine());

            double per2 = 0, per3 = 0, per4 = 0;

            for (int i = 0; i < numbersCount; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n % 2 == 0) per2++;
                if (n % 3 == 0) per3++;
                if (n % 4 == 0) per4++;
            }

            Console.WriteLine("{0:0.00}%", Math.Round(per2 / numbersCount * 100, 2));
            Console.WriteLine("{0:0.00}%", Math.Round(per3 / numbersCount * 100, 2));
            Console.WriteLine("{0:0.00}%", Math.Round(per4 / numbersCount * 100, 2));
        }
    }
}
