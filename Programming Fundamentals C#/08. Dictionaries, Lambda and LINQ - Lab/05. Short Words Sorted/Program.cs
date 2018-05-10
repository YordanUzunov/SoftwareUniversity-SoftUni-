namespace _05._Short_Words_Sorted
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string sentence = Console.ReadLine();
            var result = sentence
                .ToLower()
                .Split((char)44, (char)59, (char)58, (char)46, (char)33, (char)40, (char)41, 
                (char)34, (char)39, (char)92, (char)47, (char)91, (char)93, (char)32)
                .Distinct(StringComparer.CurrentCultureIgnoreCase)
                .OrderBy(x => x)
                .ToList();

            result.RemoveAll(str => string.IsNullOrEmpty(str));

            Console.WriteLine(String.Join(", ", result.Where(x => x.Length < 5)));
        }
    }
}
