﻿namespace _03._Count_Uppercase_Words
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var text = Console.ReadLine()
                .Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(string.Join(Environment.NewLine, text
                .Where(w => char.IsUpper(w[0]))));
        }
    }
}
