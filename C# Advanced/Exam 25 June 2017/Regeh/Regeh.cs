﻿namespace Regeh
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Regeh
    {
        public static void Main()
        {
            string pattern = @"\[[a-zA-Z]+<(\d+)REGEH(\d+)>[a-zA-Z]+\]";

            var input = Console.ReadLine();

            var regex = new Regex(pattern);

            var indexes = new List<int>();
            foreach (Match match in regex.Matches(input))
            {
                indexes.Add(int.Parse(match.Groups[1].Value));
                indexes.Add(int.Parse(match.Groups[2].Value));
            }

            int currentIndex = 0;
            foreach (var index in indexes)
            {
                currentIndex += index;
                var charIndex = currentIndex % (input.Length - 1);
                Console.Write(input[charIndex]);
            }
            Console.WriteLine();
        }
    }
}
