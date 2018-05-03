namespace _10._Prime_Number_Check
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool isPrime = true;

            if (n < 2)
                isPrime = false;
            else
            {
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            Console.WriteLine(isPrime ? "Prime" : "Not Prime");
        }
    }
}
