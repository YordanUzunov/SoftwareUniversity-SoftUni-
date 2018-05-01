namespace _04._GreaterNumber
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            Console.WriteLine((n1 > n2) ? n1 : n2);
        }
    }
}
