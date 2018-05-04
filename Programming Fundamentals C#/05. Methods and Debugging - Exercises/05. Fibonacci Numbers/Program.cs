namespace _05._Fibonacci_Numbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Fib(number));
        }

        private static int Fib(int number)
        {
            int fibunaciNumberr = 1;
            int lastFibonaci = 0;
            for (int i = 0; i < number; i++)
            {
                int temp = fibunaciNumberr;
                fibunaciNumberr += lastFibonaci;
                lastFibonaci = temp;
            }

            return fibunaciNumberr;
        }
    }
}
