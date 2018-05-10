namespace _04._Largest_3_Numbers
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            if (nums.Count < 3)
            {
                Console.WriteLine(String.Join(" ", nums.OrderByDescending(x => x)));
            }
            else
            {
                Console.WriteLine(String.Join(" ", nums.OrderByDescending(x => x).Take(3)));
            }
        }
    }
}
