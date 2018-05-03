namespace _04._Elevator
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Ceiling((double)n / capacity));
        }
    }
}
