namespace _13._Factorial
{
    using System;
    using System.Numerics;

    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(FactorialOfNumber(number));
        }

        private static BigInteger FactorialOfNumber(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            BigInteger factorial = number;
            for (int i = number - 1; i > 1; i--)
            {
                factorial = BigInteger.Multiply(factorial, i);
            }

            return factorial;
        }
    }
}
