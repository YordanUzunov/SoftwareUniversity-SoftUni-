namespace _03._Unicode_Characters
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            foreach (char ch in input)
            {
                Console.Write($"\\u{(int)ch:x4}");
            }
            Console.WriteLine();
        }
    }
}
