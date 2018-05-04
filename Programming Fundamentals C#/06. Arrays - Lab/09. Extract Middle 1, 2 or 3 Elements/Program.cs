namespace _09._Extract_Middle_1__2_or_3_Elements
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int[] numbers = new int[input.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }

            PrintMiddleElements(numbers);
        }

        private static void PrintMiddleElements(int[] nums)
        {
            if (nums.Length == 1)
            {
                Console.WriteLine($"{{ {nums[0]} }}");
            }
            else if (nums.Length % 2 == 0)
            {
                // n/2-1 and n/2
                Console.WriteLine($"{{ {nums[nums.Length / 2 - 1]}, {nums[nums.Length / 2]} }}");
            }
            else
            {
                // n/2-1, n/2, n/2+1
                Console.WriteLine($"{{ {nums[nums.Length / 2 - 1]}, {nums[nums.Length / 2]}, {nums[nums.Length / 2 + 1]}}}");
            }
        }
}
