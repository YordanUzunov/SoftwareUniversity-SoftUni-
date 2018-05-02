namespace _07._Left_and_Right_Sum
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int halfOfAllNums = int.Parse(Console.ReadLine());
            int sum1 = 0, sum2 = 0;
            for (int i = 0; i < halfOfAllNums; i++)
                sum1 += int.Parse(Console.ReadLine());
            for (int i = 0; i < halfOfAllNums; i++)
                sum2 += int.Parse(Console.ReadLine());

            if (sum1 == sum2)
                Console.WriteLine("Yes, sum = {0}", sum1);
            else
                Console.WriteLine("No, diff = {0}", Math.Abs(sum1 - sum2));
        }
    }
}
