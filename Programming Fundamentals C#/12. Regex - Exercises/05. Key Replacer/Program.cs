namespace _05._Key_Replacer
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string findkeys = Console.ReadLine();

            var keys = new Regex(@"([a-zA-Z]+)(\||\<|\\)(\w+)(\||\<|\\)([a-zA-Z]+)");

            string startKey = string.Empty;
            string endKey = string.Empty;

            foreach (Match match in keys.Matches(findkeys))
            {
                startKey = match.Groups[1].Value;
                endKey = match.Groups[5].Value;
            }

            var finalregex = new Regex($@"{startKey}(?!{endKey})(.*?){endKey}");

            string text = Console.ReadLine();

            var wordsExtracted = new List<string>();

            foreach (Match match in finalregex.Matches(text))
            {
                string searchWord = match.Groups[1].Value;
                wordsExtracted.Add(searchWord);
            }

            if (wordsExtracted.Count > 0)
            {
                Console.WriteLine(string.Join("", wordsExtracted));
            }
            else
            {
                Console.WriteLine("Empty result");
            }
        }
    }
}
