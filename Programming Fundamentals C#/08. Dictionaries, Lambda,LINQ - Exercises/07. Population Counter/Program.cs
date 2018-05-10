namespace _07._Population_Counter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> countryReport = new Dictionary<string, Dictionary<string, int>>();

            while (input != "report")
            {
                var tokens = input.Split('|');
                var country = tokens[1];
                var city = tokens[0];
                var population = int.Parse(tokens[2]);

                if (!countryReport.ContainsKey(country))
                {
                    countryReport[country] = new Dictionary<string, int>();
                }

                if (!countryReport[country].ContainsKey(city))
                {
                    countryReport[country][city] = population;
                }
                input = Console.ReadLine();
            }

            foreach (var state in countryReport.OrderByDescending(x => x.Value.Sum(y => y.Value)))
            {
                long sumOfTowns = state.Value.Values.Sum();
                Console.WriteLine($"{state.Key} (total population: {sumOfTowns})");
                Console.Write($"=>{string.Join("=>", state.Value.OrderByDescending(x => x.Value).Select(x => $"{x.Key}: {x.Value}\r\n"))}");
            }
        }
    }
}
