namespace _04._Fix_Emails
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            Dictionary<string, string> mailList = new Dictionary<string, string>();
            string name = Console.ReadLine();

            while (name.ToLower() != "stop")
            {
                string email = Console.ReadLine();
                string emailDomain = email.Substring(email.Length - 2).ToLower();
                if (emailDomain != "us" && emailDomain != "uk")
                {
                    mailList.Add(name, email);
                }
                name = Console.ReadLine();
            }

            foreach (var row in mailList)
            {
                Console.WriteLine($"{row.Key} -> {row.Value}");
            }
        }
    }
}
