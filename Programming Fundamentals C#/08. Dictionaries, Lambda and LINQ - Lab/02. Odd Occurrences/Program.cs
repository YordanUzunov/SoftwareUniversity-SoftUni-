namespace _02._Odd_Occurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var words = input.ToLower().Split(' ');

            var count = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (count.ContainsKey(word))
                    count[word]++;
                else
                    count[word] = 1;
            }

            string[] wordsWithOddCount = count.Where(w => w.Value % 2 != 0).Select(w => w.Key).ToArray();

            Console.WriteLine(string.Join(", ", wordsWithOddCount));

        }
    }
}
