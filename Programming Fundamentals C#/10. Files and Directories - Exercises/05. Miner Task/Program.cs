﻿namespace _05._Miner_Task
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            Dictionary<string, long> resources = AvalableResources();
            ResourcesToFile(resources);
        }

        private static void ResourcesToFile(Dictionary<string, long> resources)
        {
            string result = null;
            foreach (KeyValuePair<string, long> resource in resources)
            {
                result += $"{resource.Key} -> {resource.Value}{Environment.NewLine}";
            }

            File.WriteAllText("../../../IO/output.txt", result);
        }

        private static Dictionary<string, long> AvalableResources()
        {
            string[] data = File.ReadAllLines("../../../IO/input.txt");

            Dictionary<string, long> resources = new Dictionary<string, long>();

            string resourceName = data[0];
            resources[resourceName] = 0;
            for (int i = 1; i < data.Length; i++)
            {
                if (i % 2 == 0)
                {
                    resourceName = data[i];
                    if (!resources.ContainsKey(resourceName))
                    {
                        resources[resourceName] = 0;
                    }
                }
                else
                {
                    resources[resourceName] += long.Parse(data[i]);
                }
            }

            return resources;
        }
    }
}
