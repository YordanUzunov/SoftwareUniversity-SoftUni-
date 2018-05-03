namespace _12._Fibonacci
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            if (n <= 1) Console.WriteLine("1");
            else
            {
                int f0 = 1, f1 = 1;
                for (int i = 1; i < n; i++)
                {
                    int temp = f1;
                    f1 += f0;
                    f0 = temp;
                }
                Console.WriteLine(f1);
            }
        }
    }
}
