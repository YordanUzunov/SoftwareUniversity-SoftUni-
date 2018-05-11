namespace _04._Weather
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            var citiesWeather = new Dictionary<string, CityWeather>();

            var pattern = new Regex(@"([A-Z][A-Z])(\d{2}\.\d{1,})([a-zA-Z]+)\|");

            var input = Console.ReadLine();
            while (input != "end")
            {
                foreach (Match match in pattern.Matches(input))
                {
                    string name = match.Groups[1].Value;
                    var city = new CityWeather()
                    {
                        Temperature = (double.Parse(match.Groups[2].Value)),
                        Weather = match.Groups[3].Value
                    };
                    citiesWeather[name] = city;
                }

                input = Console.ReadLine();
            }

            foreach (var city in citiesWeather.OrderBy(x => x.Value.Temperature))
            {
                Console.WriteLine($"{city.Key} => {city.Value.Temperature:f2} => {city.Value.Weather}");
            }
        }
    }
}
