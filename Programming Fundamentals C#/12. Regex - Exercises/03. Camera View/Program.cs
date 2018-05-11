namespace _03._Camera_View
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int m = input[0];
            int n = input[1];

            var regex = "\\|<(\\w{" + m + "})(\\w{0," + n + "})";

            var picsInfo = Console.ReadLine();

            MatchCollection matchedResult = Regex.Matches(picsInfo, regex);
            List<string> res = new List<string>();

            foreach (Match match in matchedResult)
            {
                res.Add(match.Groups[2].Value);
            }

            Console.WriteLine(String.Join(", ", res));
        }
    }
}
