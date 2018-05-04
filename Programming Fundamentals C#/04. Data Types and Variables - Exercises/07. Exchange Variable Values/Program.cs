namespace _07._Exchange_Variable_Values
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine()); ;
            int b = int.Parse(Console.ReadLine()); ;
            Console.WriteLine("Before:\na = {0}\nb = {1}", a, b);
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After:\na = {0}\nb = {1}", a, b);
        }
    }
}
