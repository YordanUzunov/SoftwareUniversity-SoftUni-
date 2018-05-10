namespace _03._Sum_Adjacent_Equal_Numbers
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            List<double> result = new List<double>();
            foreach (string num in input)
            {
                result.Add(double.Parse(num));
            }

            for (int i = 0; i < result.Count - 1; i++)
            {
                if (result[i] == result[i + 1])
                {
                    result[i + 1] = result[i] * 2;
                    result.RemoveAt(i);
                    i = -1;
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
