namespace _05._Number_Sequence_2k_1
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i = i * 2 + 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
