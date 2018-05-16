using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousCache
{
    class AnonymousCache
    {
        static void Main()
        {
            var datasets = new Dictionary<string, Dictionary<string, long>>();
            var cache = new Dictionary<string, Dictionary<string, long>>();

            var inputLine = Console.ReadLine();
            while (inputLine != "thetinggoesskrra")
            {
                var tokens = inputLine.Split(new string[] { " -> ", " | " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (tokens.Length == 1)
                {
                    var datasetName = tokens[0];
                    if (!datasets.ContainsKey(datasetName) && !cache.ContainsKey(datasetName))
                    {
                        datasets.Add(datasetName, new Dictionary<string, long>());
                    }
                    if (!datasets.ContainsKey(datasetName) && cache.ContainsKey(datasetName))
                    {
                        datasets.Add(datasetName, new Dictionary<string, long>());
                        foreach (var item in cache.Where(x => x.Key == datasetName))
                        {
                            foreach (var dict in item.Value)
                            {
                                datasets[datasetName].Add(dict.Key, dict.Value);
                            }
                        }
                    }
                }
                if (tokens.Length == 3)
                {
                    var datasetName = tokens[2];
                    var dataKey = tokens[0];
                    long dataSize = long.Parse(tokens[1]);
                    if (datasets.ContainsKey(datasetName))
                    {
                        datasets[datasetName].Add(dataKey, dataSize);
                    }
                    else
                    {
                        if (!cache.ContainsKey(datasetName))
                        {
                            cache.Add(datasetName, new Dictionary<string, long>());
                        }
                        cache[datasetName].Add(dataKey, dataSize);
                    }
                }

                inputLine = Console.ReadLine();
            }

            if (datasets.Any())
            {
                var orderedDatasets = datasets.OrderByDescending(x => x.Value.Values.Sum());
                foreach (var item in orderedDatasets)
                {
                    Console.WriteLine($"Data Set: {item.Key}, Total Size: {item.Value.Values.Sum()}");
                    foreach (var datakey in item.Value)
                    {
                        Console.WriteLine($"$.{datakey.Key}");
                    }
                    break;
                }
            }
        }
    }
}
