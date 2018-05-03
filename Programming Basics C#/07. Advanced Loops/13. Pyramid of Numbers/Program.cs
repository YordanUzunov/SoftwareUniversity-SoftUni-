namespace _13._Pyramid_of_Numbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1, row = 1; i <= n; row++)
            {
                for (int j = 0; j < row && i <= n; j++, i++)
                {
                    Console.Write("{0} ", i);
                }
                Console.WriteLine();
            }
        }
    }
}
