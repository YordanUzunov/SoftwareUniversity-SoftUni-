namespace _02._Circle_Area__12_Digits_Precision_
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F12}", Math.PI * radius * radius);
        }
    }
}
