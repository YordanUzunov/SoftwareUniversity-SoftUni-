namespace _06._Replace_a_Tag
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            List<string> html = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower().Equals("end"))
                {
                    break;
                }

                html.Add(input);
            }

            Regex regex = new Regex(@"<a.*(href=.*>?)>(.*)<\/a>");

            foreach (string line in html)
            {
                string result = regex.Replace(line, "[URL $1]$2[/URL]");

                Console.WriteLine(result);
            }
        }
    }
}
