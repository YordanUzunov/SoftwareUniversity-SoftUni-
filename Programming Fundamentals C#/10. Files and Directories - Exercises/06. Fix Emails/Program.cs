namespace _06._Fix_Emails
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] data = File.ReadAllLines("../../../IO/input.txt");
            Dictionary<string, string> allowedEmails = new Dictionary<string, string>();

            for (int i = 1; i < data.Length; i += 2)
            {
                if (data[i].EndsWith("uk") || data[i].EndsWith("us"))
                {
                    continue;
                }

                allowedEmails[data[i - 1]] = data[i];
            }

            string[] result = allowedEmails
                .Select(x => $"{x.Key} -> {x.Value}")
                .ToArray();

            File.WriteAllLines("../../../IO/output.txt", result);
        }
    }
}
