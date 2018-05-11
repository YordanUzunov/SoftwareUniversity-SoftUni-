namespace _05._Match_Numbers
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            var regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            var numbersString = Console.ReadLine();

            var numbers = Regex.Matches(numbersString, regex);

            foreach (Match number in numbers)
            {
                Console.Write(number.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
