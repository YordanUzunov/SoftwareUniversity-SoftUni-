namespace _02._Numbers_from_Nto1
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
