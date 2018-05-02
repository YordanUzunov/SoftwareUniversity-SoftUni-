namespace _16.Trip
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            string destination = "", type = "";
            double cost = 0.0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season.Equals("summer"))
                {
                    cost = budget * 0.3;
                    type = "Camp";
                }
                else
                {
                    cost = budget * 0.7;
                    type = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season.Equals("summer"))
                {
                    cost = budget * 0.4;
                    type = "Camp";
                }
                else
                {
                    cost = budget * 0.8;
                    type = "Hotel";
                }
            }
            else
            {
                destination = "Europe";
                cost = budget * 0.9;
                type = "Hotel";
            }

            Console.WriteLine("Somewhere in {0}", destination);
            Console.WriteLine("{0} - {1:f2}", type, cost);
        }
    }
}
