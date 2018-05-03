namespace _09._Reversed_chars
{
    using System;

    public class Program
    {
        public static void Main()
        {
            char[] input = new char[3];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = Console.ReadLine()[0];
            }
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
        }
    }
}
