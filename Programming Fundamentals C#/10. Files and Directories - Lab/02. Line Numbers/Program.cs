namespace _02._Line_Numbers
{
    using System;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            string[] input = File.ReadAllLines("../Input/input.txt");
            for (int i = 0; i < input.Length; i++)
            {
                File.AppendAllText("../Output/output.txt", $"{i + 1}. {input[i]}{Environment.NewLine}");
            }
        }
    }
}
