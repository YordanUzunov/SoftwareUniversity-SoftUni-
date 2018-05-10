namespace _06._Fold_and_Sum
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] nums = Console.ReadLine()
                        .Split(' ').
                        Select(int.Parse).
                        ToArray();

            int k = nums.Length / 4;

            int[] row1left = nums.Take(k).Reverse().ToArray();
            int[] row1right = nums.Reverse().Take(k).ToArray();
            int[] row1 = row1left.Concat(row1right).ToArray();
            int[] row2 = nums.Skip(k).Take(2 * k).ToArray();

            var sumArr =
              row1.Select((x, index) => x + row2[index]);
            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
