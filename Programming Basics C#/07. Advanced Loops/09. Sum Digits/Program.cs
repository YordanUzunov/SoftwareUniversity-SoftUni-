namespace _09._Sum_Digits
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            while (true)
            {
                sum += n % 10;
                if (n < 10)
                    break;
                n /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}
