namespace _18._Transport_Cost
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var km = int.Parse(Console.ReadLine());
            var dayTime = Console.ReadLine();

            // Cost of Travel for that distance
            if (km >= 100)
                Console.WriteLine(km * 0.06);
            else if (km >= 20)
                Console.WriteLine(km * 0.09);
            else
            {
                if (dayTime.Equals("day"))
                    Console.WriteLine(0.70 + km * 0.79);
                else if (dayTime.Equals("night"))
                    Console.WriteLine(0.70 + km * 0.90);
            }
        }
    }
}
