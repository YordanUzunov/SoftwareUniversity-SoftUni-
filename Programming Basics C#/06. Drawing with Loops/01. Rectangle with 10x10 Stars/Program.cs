namespace _01._Rectangle_with_10x10_Stars
{
    using System;

    public class Program
    {
        public static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
