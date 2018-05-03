namespace _03._Powers_of_Two
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0, num = 1; i <= n; i++, num *= 2)
            {
                Console.WriteLine(num);
            }

        }
    }
}
