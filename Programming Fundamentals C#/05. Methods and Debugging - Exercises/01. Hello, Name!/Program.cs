namespace _01._Hello__Name_
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            PrintHelloToName(name);
        }

        private static void PrintHelloToName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
