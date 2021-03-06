﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class RageQuit
{
    static void Main()
    {

        string input = Console.ReadLine();

        StringBuilder word = new StringBuilder();
        StringBuilder count = new StringBuilder();
        StringBuilder result = new StringBuilder();
        var inDigits = false;
        for (int i = 0; i < input.Length; i++)
        {
            char ch = Char.ToUpper(input[i]);
            if (inDigits)
            {
                //Scan for digits
                if (Char.IsDigit(ch))
                {
                    count.Append(ch);
                }
                else
                {
                    //word + count found
                    for (int c = 0; c < int.Parse(count.ToString()); c++)
                    {
                        result.Append(word);
                    }
                    inDigits = false;
                    word.Clear();
                    word.Append(ch);
                }
            }
            else
            {
                //Scan for letters
                if (Char.IsDigit(ch))
                {
                    word.Append(ch);
                }
                else
                {
                    //digitfound
                    inDigits = true;
                    count.Clear();
                    count.Append(ch);
                }
                if (Char.IsDigit(ch))
                {
                    inDigits = true;
                }
            }

            for (int c = 0; c < int.Parse(count.ToString()); c++)
            {
                result.Append(word);
            }

            Dictionary<char, bool> charOccurs = new Dictionary<char, bool>();
            foreach (var c in result.ToString())
            {
                charOccurs[c] = true;

            }
            var uniqueChars = charOccurs.Keys.Count();



            Console.WriteLine($"Unique symbols used: {uniqueChars}");
            Console.WriteLine(result.ToString());

        }
    }
}

