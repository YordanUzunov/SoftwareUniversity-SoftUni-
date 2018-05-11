namespace _01._Reverse_string
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(string.Join(string.Empty, input.ToCharArray().Reverse()));
        }
    }
}
