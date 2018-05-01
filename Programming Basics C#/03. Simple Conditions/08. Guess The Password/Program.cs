namespace _09._Guess_The_Password
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string guess = Console.ReadLine();
            Console.WriteLine((guess.Equals("s3cr3t!P@ssw0rd")) ? "Welcome" : "Wrong password!");
        }
    }
}
