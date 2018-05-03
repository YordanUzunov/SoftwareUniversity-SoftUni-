namespace _17._Print_Part_Of_ASCII_Table
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int firstChar = int.Parse(Console.ReadLine());
            int lastChar = int.Parse(Console.ReadLine());
            for (int i = firstChar; i <= lastChar; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
