namespace _08._Factorial
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int fact = n;

            for (int i = n - 1; i > 0; i--)
            {
                fact *= i;
            }

            Console.WriteLine(fact);
        }
    }
}
