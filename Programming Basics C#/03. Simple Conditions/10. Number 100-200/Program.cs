namespace _10._Number_100_200
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 100)
                Console.WriteLine("Less than 100");
            else if (n < 201)
                Console.WriteLine("Between 100 and 200");
            else
                Console.WriteLine("Greater than 200");
        }
    }
}
