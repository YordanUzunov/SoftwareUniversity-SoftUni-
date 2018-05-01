namespace _03._EvenOrOdd
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            Console.WriteLine((num % 2 == 0) ? "even" : "odd");
        }
    }
}
