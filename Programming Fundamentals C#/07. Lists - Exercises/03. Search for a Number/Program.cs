namespace _03._Search_for_a_Number
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = numbers.Count - 1; i >= arr[0]; i--)
            {
                numbers.Remove(numbers[i]);

            }

            for (int i = 0; i < arr[1]; i++)
            {
                numbers.Remove(numbers[0]);
            }

            if (numbers.Contains(arr[2])) Console.WriteLine("YES!");
            else Console.WriteLine("NO!");
        }
    }
}
