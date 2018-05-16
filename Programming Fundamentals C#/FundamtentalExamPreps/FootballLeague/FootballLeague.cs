using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FootballLeague
{
    class FootballLeague
    {
        static void Main(string[] args)
        {
            var key = Console.ReadLine();
            key = Regex.Escape(key);
            var pattern = $@"{key}([a-zA-Z]*){key}[\s\S]*{key}([a-zA-Z]*){key}[\s\S]*([\d]+):([\d]+)";
            Regex regex = new Regex(pattern);

            var teamStandings = new Dictionary<string, int>();
            var teamGoals = new Dictionary<string, int>();

            var input = Console.ReadLine();
            while (input != "final")
            {
                Match match = regex.Match(input);

                var homeTeam = new string(match.Groups[1].Value.Reverse().ToArray()).ToUpper();
                var awayTeam = new string(match.Groups[2].Value.Reverse().ToArray()).ToUpper();
                var homeGoals = int.Parse(match.Groups[3].Value);
                var awayGoals = int.Parse(match.Groups[4].Value);

                if (!teamGoals.ContainsKey(homeTeam))
                {
                    teamGoals.Add(homeTeam, homeGoals);
                }
                else
                {
                    teamGoals[homeTeam] += homeGoals;
                }
                if (!teamGoals.ContainsKey(awayTeam))
                {
                    teamGoals.Add(awayTeam, awayGoals);
                }
                else
                {
                    teamGoals[awayTeam] += awayGoals;
                }

                int homePoints = 0;
                int awayPoints = 0;
                if (homeGoals > awayGoals)
                {
                    homePoints = 3;
                    awayPoints = 0;
                }
                else if (homeGoals < awayGoals)
                {
                    homePoints = 0;
                    awayPoints = 3;
                }
                else
                {
                    homePoints = 1;
                    awayPoints = 1;
                }

                if (!teamStandings.ContainsKey(homeTeam))
                {
                    teamStandings.Add(homeTeam, homePoints);
                }
                else
                {
                    teamStandings[homeTeam] += homePoints;
                }
                if (!teamStandings.ContainsKey(awayTeam))
                {
                    teamStandings.Add(awayTeam, awayPoints);
                }
                else
                {
                    teamStandings[awayTeam] += awayPoints;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("League standings:");
            var place = 1;
            foreach (var team in teamStandings.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{place}. {team.Key} {team.Value}");
                place++;
            }
            Console.WriteLine("Top 3 scored goals:");
            if (teamGoals.Keys.Count >= 3)
            {
                foreach (var team in teamGoals.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Take(3))
                {
                    Console.WriteLine($"- {team.Key} -> {team.Value}");
                }
            }
            else
            {
                foreach (var team in teamGoals.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {team.Key} -> {team.Value}");
                }
            }
        }
    }
}
