namespace _06._User_Logs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            SortedDictionary<string, Dictionary<string, int>> usersLogs = new SortedDictionary<string, Dictionary<string, int>>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');
                if (input[0].ToLower().Equals("end"))
                {
                    break;
                }

                input = input
                    .Select(x => x.Substring(x.IndexOf('=') + 1))
                    .ToArray();

                if (usersLogs.ContainsKey(input[2]))
                {
                    if (usersLogs[input[2]].ContainsKey(input[0]))
                    {
                        usersLogs[input[2]][input[0]]++;
                    }
                    else
                    {
                        usersLogs[input[2]][input[0]] = 1;
                    }
                }
                else
                {
                    usersLogs[input[2]] = new Dictionary<string, int>();
                    usersLogs[input[2]][input[0]] = 1;
                }
            }

            PrintUserData(usersLogs);
        }

        private static void PrintUserData(SortedDictionary<string, Dictionary<string, int>> usersLogs)
        {
            foreach (var user in usersLogs)
            {
                Console.WriteLine(user.Key + ":");
                List<string> userData = new List<string>();
                foreach (var ip in usersLogs[user.Key])
                {
                    userData.Add($"{ip.Key} => {ip.Value}");
                }

                Console.WriteLine(string.Join(", \r\n", userData) + ".");
            }
        }
    }
}
