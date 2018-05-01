namespace _08._Metric_Unit_Converter
{
    using System;

    public class Program
    {
        public static void Main()
        {
            // Input
            var numberToConvert = double.Parse(Console.ReadLine());
            string initialMetric = Console.ReadLine();
            string desiredMetric = Console.ReadLine();
            // Find Meters
            double meters;
            if (initialMetric.ToLower().Equals("m"))
                meters = numberToConvert;
            else
                meters = FindMeters(numberToConvert, initialMetric);
            // Find the Result
            double result;
            if (desiredMetric.ToLower().Equals("m"))
                result = meters;
            else
                result = getResult(meters, desiredMetric);
            Console.WriteLine("{0:f8} {1}", result, desiredMetric);
        }

        private static double getResult(double m, string desiredMetric)
        {
            desiredMetric = desiredMetric.ToLower();
            if (desiredMetric.Equals("mm"))
                return m * 1000;
            else if (desiredMetric.Equals("cm"))
                return m * 100;
            else if (desiredMetric.Equals("mi"))
                return m * 0.000621371192;
            else if (desiredMetric.Equals("in"))
                return m * 39.3700787;
            else if (desiredMetric.Equals("km"))
                return m * 0.001;
            else if (desiredMetric.Equals("ft"))
                return m * 3.2808399;
            else if (desiredMetric.Equals("yd"))
                return m * 1.0936133;
            else
            {
                Console.WriteLine("Invalid metric unit!");
                return 0;
            }
        }

        private static double FindMeters(double numberToConvert, string initialMetric)
        {
            initialMetric = initialMetric.ToLower();
            if (initialMetric.Equals("mm"))
                return numberToConvert / 1000;
            else if (initialMetric.Equals("cm"))
                return numberToConvert / 100;
            else if (initialMetric.Equals("mi"))
                return numberToConvert / 0.000621371192;
            else if (initialMetric.Equals("in"))
                return numberToConvert / 39.3700787;
            else if (initialMetric.Equals("km"))
                return numberToConvert / 0.001;
            else if (initialMetric.Equals("ft"))
                return numberToConvert / 3.2808399;
            else if (initialMetric.Equals("yd"))
                return numberToConvert / 1.0936133;
            else
            {
                Console.WriteLine("Invalid metric unit!");
                return 0;
            }
        }
    }
}
