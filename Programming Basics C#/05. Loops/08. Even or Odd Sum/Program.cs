namespace _08._Evens_and_Odds_Sum
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int sum1 = 0, sum2 = 0;

            for (int i = 1; i <= numbersCount; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (i % 2 == 0) sum2 += n;
                else sum1 += n;
            }

            if (sum1 == sum2)
                Console.WriteLine("Yes Sum = {0}", sum2);
            else Console.WriteLine("No Diff = {0}", Math.Abs(sum1 - sum2));
        }
    }
}
