namespace _02._Extract_Sentences_by_Keyword
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string word = Console.ReadLine();
            Regex pattern = new Regex($@"\b[^?.!]*\b{word}\b[^?.!]*");

            string text = Console.ReadLine();

            MatchCollection matches = pattern.Matches(text);

            foreach (Match match in matches)
            {
                string sentence = match.Value.Trim();
                Console.WriteLine(sentence);
            }
        }

    }
}
