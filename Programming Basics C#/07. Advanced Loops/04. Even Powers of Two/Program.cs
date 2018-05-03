namespace _04._Even_Powers_of_Two
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0, num = 1; i <= n; i += 2, num *= 4)
            {
                Console.WriteLine(num);
            }
        }
    }
}
