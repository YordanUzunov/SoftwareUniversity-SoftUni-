namespace _01._Phonebook
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var phonebook = new Dictionary<string, string>();

            bool isWorking = true;
            while (isWorking)
            {
                string[] cmdArgs = Console.ReadLine().Split(' ');
                switch (cmdArgs[0])
                {
                    case "A":
                        phonebook[cmdArgs[1]] = cmdArgs[2];
                        break;
                    case "S":
                        Console.WriteLine(phonebook.ContainsKey(cmdArgs[1]) ? $"{cmdArgs[1]} -> {phonebook[cmdArgs[1]]}" : 
                            $"Contact {cmdArgs[1]} does not exist.");
                        break;
                    default:
                        isWorking = false;
                        break;
                }
            }
        }
    }
}
