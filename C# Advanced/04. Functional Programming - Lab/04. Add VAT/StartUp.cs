namespace _04._Add_VAT
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var netPrices = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse);

            Console.WriteLine(string.Join(Environment.NewLine, netPrices
                .Select(p => $"{p * 1.20:F2}")));
        }
    }
}
