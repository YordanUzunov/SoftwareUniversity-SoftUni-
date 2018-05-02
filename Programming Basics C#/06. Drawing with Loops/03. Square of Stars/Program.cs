namespace _03._Square_of_Stars
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 1) Console.WriteLine("*");
            else
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("* ");
                    for (int j = 0; j < n - 2; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine("*");
                }
            }
        }
    }
}
