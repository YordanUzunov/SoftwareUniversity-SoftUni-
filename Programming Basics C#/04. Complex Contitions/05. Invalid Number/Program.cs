namespace _05._Invalid_Number
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            if (n != 0 && n < 100 || n > 200) Console.WriteLine("invalid");
        }
    }
}
