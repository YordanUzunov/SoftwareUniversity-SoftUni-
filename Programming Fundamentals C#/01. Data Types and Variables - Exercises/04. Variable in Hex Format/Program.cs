namespace _04._Variable_in_Hex_Format
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string hex = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(hex, 16));
        }
    }
}
