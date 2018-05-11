namespace _02._Randomize_Words
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split(' ');
            Random rnd = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                int randomIndex = rnd.Next(words.Length);
                string temp = words[i];
                words[i] = words[randomIndex];
                words[randomIndex] = temp;
            }

            Console.WriteLine(string.Join("\n", words));
        }
    }
}
