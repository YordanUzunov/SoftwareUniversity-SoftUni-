namespace _11._Same_Words
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            Console.WriteLine((s1.ToLower().Equals(s2.ToLower())) ? "yes" : "no");
        }
    }
}
