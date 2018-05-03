namespace _13._Vowel_or_Digit
{
    using System;

    public class Program
    {
        public static void Main()
        {
            char c = Console.ReadLine()[0];
            if (Char.IsDigit(c))
                Console.WriteLine("digit");
            else if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'y' || 
                c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U' || c == 'Y')
                Console.WriteLine("vowel");
            else
                Console.WriteLine("other");
        }
    }
}
