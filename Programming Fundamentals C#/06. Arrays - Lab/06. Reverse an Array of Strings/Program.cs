namespace _06._Reverse_an_Array_of_Strings
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            //for (int i = 0, j = input.Length - 1; i < j; i++, j--)       // Long version
            //{
            //    string temp = input[i];
            //    input[i] = input[j];
            //    input[j] = temp;
            //}
            //Console.WriteLine(string.Join(" ", input));
            Console.WriteLine(string.Join(" ", input.Reverse().ToArray()));
        }
    }
}
