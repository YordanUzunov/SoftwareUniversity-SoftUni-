namespace _06._Rhombus_Of_Stars
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            // Upper Part
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', n - (i + 1)));
                Console.Write("*");
                for (int j = 0; j <= i - 1; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

            // Lower Part
            for (int i = 1; i < n; i++)
            {
                Console.Write(new string(' ', i - 1));
                //Console.Write("*");
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
