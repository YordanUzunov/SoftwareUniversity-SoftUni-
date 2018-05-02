namespace _11._Cinema
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string ticketType = Console.ReadLine().ToLower();
            var rows = int.Parse(Console.ReadLine());
            var columns = int.Parse(Console.ReadLine());

            if (ticketType.Equals("premiere")) Console.WriteLine("{0:f2} leva", rows * columns * 12);
            else if (ticketType.Equals("normal")) Console.WriteLine("{0:f2} leva", rows * columns * 7.50);
            else if (ticketType.Equals("discount")) Console.WriteLine("{0:f2} leva", rows * columns * 5);
        }
    }
}
