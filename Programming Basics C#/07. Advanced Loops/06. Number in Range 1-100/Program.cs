namespace _06._Number_in_Range_1_100
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Console.Write("Еnter a number in the range [1...100]: ");
            int n = int.Parse(Console.ReadLine());
            while (n < 1 || n > 100)
            {
                Console.WriteLine("Invalid number!");
                Console.Write("Еnter a number in the range [1...100]: ");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The number is: {0}", n);
        }
    }
}
