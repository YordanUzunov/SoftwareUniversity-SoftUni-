namespace _14._Integer_to_Hex_and_Binary
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string hex = Convert.ToString(n, 16);
            hex = hex.ToUpper();
            Console.WriteLine(hex);
            string bin = Convert.ToString(n, 2);
            Console.WriteLine(bin);
        }
    }
}
