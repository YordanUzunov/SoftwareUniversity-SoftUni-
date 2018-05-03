namespace _14._Numbers_Table
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                bool reached = false;
                for (int col = 0, write = row + 1; col < n; col++)
                {
                    Console.Write("{0} ", write);
                    if (write == n) reached = true;
                    if (reached) write--;
                    else write++;
                }
                Console.WriteLine();
            }
        }
    }
}
