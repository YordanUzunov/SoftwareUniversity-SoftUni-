namespace _05._Boolean_Variable
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(input.ToLower().Equals("true") ? "Yes" : input.ToLower().Equals("false") ? "No" : "");
        }
    }
}
