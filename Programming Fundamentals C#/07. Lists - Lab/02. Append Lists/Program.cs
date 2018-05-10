namespace _02._Append_Lists
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split('|');

            List<int> output = new List<int>();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                string[] temp = input[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                foreach (string num in temp)
                {
                    output.Add(int.Parse(num));
                }
            }

            Console.WriteLine(string.Join(" ", output));
        }
    }
}
