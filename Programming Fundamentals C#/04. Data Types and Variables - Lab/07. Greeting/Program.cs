namespace _07._Greeting
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Hello, {0} {1}. You are {2} years old.", firstName, lastName, age);
        }
    }
}
