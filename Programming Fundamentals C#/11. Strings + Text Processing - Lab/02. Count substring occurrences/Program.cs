namespace _02._Count_substring_occurrences
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            string key = Console.ReadLine();

            Console.WriteLine(KeyOccurances(text.ToLower(), key.ToLower()));
        }

        private static int KeyOccurances(string text, string key)
        {
            int count = 0;
            int index = text.IndexOf(key);
            while (index >= 0)
            {
                count++;
                index = text.IndexOf(key, index + 1);
            }

            return count;
        }
    }
}
