namespace _06._Bonus_Score
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var score = int.Parse(Console.ReadLine());

            double bonus = 0;
            if (score > 1000)
            {
                bonus = score * 0.1;
            }
            else if (score > 100)
            {
                bonus = score * 0.2;
            }
            else
            {
                bonus = 5;
            }

            if (score % 2 == 0)
            {
                bonus += 1;
            }
            else if (score % 10 != 0 && score % 5 == 0)
            {
                bonus += 2;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(bonus + score);
        }
    }
}
