namespace _02._Min_Method___GetMax
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(GetMax(firstNumber, secondNumber), thirdNumber));
        }

        private static int GetMax(int a, int b)
        {
            return (a > b) ? a : b;
        }
    }
}
