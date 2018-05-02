namespace _04._Triangle_Of_Dollars
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0, col = 0; i < n; i++)
            {
                Console.Write("$");
                for (int j = 0; j < col; j++)
                {
                    Console.Write(" $");
                }
                col++;
                Console.WriteLine();
            }
        }
    }
}
