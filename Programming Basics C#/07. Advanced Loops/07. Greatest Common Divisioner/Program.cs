namespace _07._Greatest_Common_Divisioner
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int GCD = 0;
            int separator = Math.Min(num1, num2), separated = Math.Max(num1, num2);

            while (true)
            {
                if (separated % separator == 0)
                {
                    GCD = separator;
                    break;
                }
                else
                {
                    int reminder = separated % separator;
                    separated = separator;
                    separator = reminder;
                }
            }

            Console.WriteLine(GCD);
        }
    }
}
