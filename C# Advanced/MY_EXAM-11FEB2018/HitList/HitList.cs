namespace HitList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HitList
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, string>> people = new Dictionary<string, Dictionary<string, string>>();

            int targetIndex = int.Parse(Console.ReadLine());

            string command;

            while ((command = Console.ReadLine()) != "end transmissions")
            {
                string[] commandArgs = command.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);

                string name = commandArgs[0];

                if (!people.ContainsKey(name))
                {
                    people[name] = new Dictionary<string, string>();
                }

                commandArgs = commandArgs[1].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var pair in commandArgs)
                {
                    var tokens = pair.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

                    people[name][tokens[0]] = tokens[1];
                }
            }

            string targetMan = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Last();

            Console.WriteLine($"Info on {targetMan}:");
            var man = people[targetMan];

            foreach (var key in man.Keys.OrderBy(k => k))
            {
                Console.WriteLine($"---{key}: {man[key]}");
            }

            int infoIndex = people[targetMan]
                .Select(kvp => kvp.Key.Length + kvp.Value.Length)
                .Sum();

            Console.WriteLine($"Info index: {infoIndex}");

            if (infoIndex >= targetIndex)
            {
                Console.WriteLine("Proceed");
            }
            else
            {
                Console.WriteLine($"Need {targetIndex - infoIndex} more info.");
            }
        }
    }
}
