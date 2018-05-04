namespace _04._Numbers_in_Reversed_Order
{
    using System;

    public class Program
    {
        public static void Main()
        {
            decimal number = decimal.Parse(Console.ReadLine());
            PrintReversedNumber(number);
        }

        private static void PrintReversedNumber(decimal number)
        {
            string numberToString = number.ToString();
            for (int i = numberToString.Length - 1; i >= 0; i--)
            {
                Console.Write(numberToString[i]);
            }
            Console.WriteLine();
        }
    }
}
