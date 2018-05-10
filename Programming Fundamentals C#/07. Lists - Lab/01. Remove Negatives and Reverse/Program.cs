namespace _01._Remove_Negatives_and_Reverse
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int count = 0;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (int.Parse(input[i]) >= 0)
                {
                    count++;
                    Console.Write("{0} ", input[i]);
                }
            }

            if (count == 0)
            {
                Console.WriteLine("empty");
            }
        }
    }
}
