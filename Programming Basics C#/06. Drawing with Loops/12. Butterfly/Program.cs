namespace _12._Butterfly
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char ch = '?';

            // Upper Body
            for (int i = 1; i <= 2 * (n - 2) / 2; i++)
            {
                if (i % 2 != 0) ch = '*';
                else ch = '-';
                Console.WriteLine("{0}\\ /{0}", new string(ch, n - 2));
            }
            Console.WriteLine("{0}@", new string(' ', n - 1));
            // Lower Body
            for (int i = 1; i <= 2 * (n - 2) / 2; i++)
            {
                if (i % 2 != 0) ch = '*';
                else ch = '-';
                Console.WriteLine("{0}/ \\{0}", new string(ch, n - 2));
            }
        }
    }
}
