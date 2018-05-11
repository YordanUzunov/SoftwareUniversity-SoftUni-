namespace _01._Odd_Lines
{
    using System;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            string[] input = File.ReadAllLines("input.txt");
            PrintOddLines(input);
        }

        private static void PrintOddLines(string[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(input[i]);
                }
            }
        }
    }
}
