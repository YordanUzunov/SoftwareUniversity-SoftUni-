namespace _12._Equal_Pairs
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int numberOfPairs = int.Parse(Console.ReadLine());

            int sum1 = 0, sum2 = 0, difference = 0;

            for (int i = 1; i <= numberOfPairs; i++)
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                if (i % 2 == 0) sum2 = n1 + n2;
                else sum1 = n1 + n2;
                if (i > 1 && Math.Abs(sum1 - sum2) > difference)
                    difference = Math.Abs(sum2 - sum1);
            }
            if (difference == 0) Console.WriteLine("Yes, value={0}", sum1);
            else Console.WriteLine("No, maxdiff={0}", difference);
        }
    }
}
