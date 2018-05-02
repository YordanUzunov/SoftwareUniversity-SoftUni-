namespace _10._Half_Sum_Element
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int numbersCount = int.Parse(Console.ReadLine());

            int[] nums = new int[numbersCount];
            for (int i = 0; i < numbersCount; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            bool isFound = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == sum - nums[i])
                {
                    isFound = true;
                    sum = nums[i];
                    break;
                }
            }

            if (isFound) Console.WriteLine("Yes Sum = {0}", sum);
            else
            {
                int max = nums[0];
                for (int i = 1; i < nums.Length; i++)
                    if (nums[i] > max)
                        max = nums[i];
                Console.WriteLine("No Diff = {0}", Math.Abs((sum - max) - max));
            }
        }
    }
}
