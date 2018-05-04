namespace _16._Comparing_Floats
{
    using System;

    public class Program
    {
        public static void Main()
        {
            float eps = 0.000001F;
            eps -= 0.0000001F;
            float n1 = float.Parse(Console.ReadLine());
            float n2 = float.Parse(Console.ReadLine());
            Console.WriteLine((n1 < n2 + eps && n1 >= n2 || n1 > n2 - eps && n1 <= n2) ? "True" : "False");
        }
    }
}
