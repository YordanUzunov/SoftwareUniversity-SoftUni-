namespace _07._Primes_in_Given_Range
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            int bottomBorder = int.Parse(Console.ReadLine());
            int topBorder = int.Parse(Console.ReadLine());
            List<int> primesInRange = CreatePrimesInRange(bottomBorder, topBorder);
            PrintListOfIntegers(primesInRange);
        }

        private static void PrintListOfIntegers(List<int> numbers)
        {
            Console.WriteLine(string.Join(", ", numbers));
        }

        private static List<int> CreatePrimesInRange(int bottomBorder, int topBorder)
        {
            List<int> primesList = new List<int>();
            for (int i = bottomBorder; i <= topBorder; i++)
            {
                if (IsPrime(i))
                {
                    primesList.Add(i);
                }
            }

            return primesList;
        }

        private static bool IsPrime(long number)
        {
            if (number == 0 || number == 1)
            {
                return false;
            }

            int loopBorder = (int)Math.Sqrt(number);
            for (int i = 2; i <= loopBorder; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
