namespace _07._Christmas_Tree
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new string(' ', n + 1));
            Console.WriteLine('|');

            for (int i = 1, s = n - 1; i <= n; i++, s--)
            {
                string space = new string(' ', s);
                string stars = new string('*', i);
                Console.WriteLine("{0}{1} | {1}", space, stars);
            }
        }
    }
}
