namespace _05._Special_Numbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0} -> {1}", i, isSpecial(i));
            }
        }

        private static bool isSpecial(int n)
        {
            int sum = 0;
            while (true)
            {
                if (n == 0) break;
                sum += n % 10;
                n = n / 10;
            }
            if (sum == 5) return true;
            else if (sum == 7) return true;
            else if (sum == 11) return true;
            else return false;
        }
    }
}
