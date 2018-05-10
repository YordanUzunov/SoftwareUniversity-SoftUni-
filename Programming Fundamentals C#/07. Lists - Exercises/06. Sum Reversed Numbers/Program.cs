namespace _06._Sum_Reversed_Numbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string[] nums = Console.ReadLine().Split(' ');
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += ReverseStringToInt(nums[i]);
            }

            Console.WriteLine(sum);
        }

        public static int ReverseStringToInt(string s)
        {
            char[] ch = new char[s.Length];
            for (int i = s.Length - 1, j = 0; i >= 0; i--, j++)
            {
                ch[j] = s[i];
            }

            return int.Parse(new string(ch));
        }
    }
}
