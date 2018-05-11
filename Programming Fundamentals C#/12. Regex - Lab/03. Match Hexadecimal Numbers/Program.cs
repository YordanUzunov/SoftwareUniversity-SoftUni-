namespace _03._Match_Hexadecimal_Numbers
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            var regex = @"\b(?:0x)?[0-9A-F]+\b";

            var numbersString = Console.ReadLine();
            var numbers = Regex.Matches(numbersString, regex)
                .Cast<Match>()
                .Select(a => a.Value)
                .ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
