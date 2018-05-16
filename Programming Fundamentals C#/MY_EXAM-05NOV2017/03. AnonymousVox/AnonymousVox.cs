using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AnonymousVox
{
    class AnonymousVox
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string[] values = Console.ReadLine()
                            .Trim()
                            .Split(new string[] { "{", "}" }, StringSplitOptions
                            .RemoveEmptyEntries)
                            .ToArray();

            string pattern = @"([a-zA-Z]+)(.+)(\1)";

            Regex reg = new Regex(pattern);
            int index = 0;

            foreach (Match item in reg.Matches(input))
            {
                if (index < values.Length)
                {
                    string currentValue = values[index];
                    Regex regex = new Regex(Regex.Escape(item.Groups[2].Value));
                    input = regex.Replace(input, values[index], 1);
                }

                index++;
            }

            Console.WriteLine(input);
        }
    }
}
