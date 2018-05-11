namespace _01._Match_Full_Name
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            Regex regex = new Regex(@"\b[A-Z][a-z]+\s[A-Z][a-z]+\b");

            foreach (Match match in regex.Matches(text))
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
