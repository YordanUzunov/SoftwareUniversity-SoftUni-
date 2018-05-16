using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regexmon
{
    class Regexmon
    {
        static void Main(string[] args)
        {
            Regex DidimonRegex = new Regex(@"[^a-zA-Z\-]+");
            Regex BojomonRegex = new Regex(@"[a-zA-Z]+-[a-zA-Z]+");

            var input = Console.ReadLine();

            while (true)
            {
                Match didiMatch = DidimonRegex.Match(input);
                if (didiMatch.Success)
                {
                    Console.WriteLine(didiMatch.Value.ToString());
                }
                else
                {
                    return;
                }

                int firstSymbolDidi = didiMatch.Index;
                input = input.Substring(firstSymbolDidi + didiMatch.Length);

                Match bojoMatch = BojomonRegex.Match(input);
                if (bojoMatch.Success)
                {
                    Console.WriteLine(bojoMatch.Value.ToString());
                }
                else
                {
                    return;
                }

                int firstSymbolBojo = bojoMatch.Index;
                input = input.Substring(firstSymbolBojo + bojoMatch.Length);

            }

        }
    }
}
