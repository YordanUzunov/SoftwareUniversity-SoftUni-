namespace _16._Stupid_Passwords_Generator
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int firstDigit = 1; firstDigit < n; firstDigit++)
            {
                for (int secondDigit = 1; secondDigit < n; secondDigit++)
                {
                    for (char thirdCharacter = 'a'; thirdCharacter < 'a' + l; thirdCharacter++)
                    {
                        for (char fourthCharacter = 'a'; fourthCharacter < 'a' + l; fourthCharacter++)
                        {
                            for (int fifthFigit = Math.Max(firstDigit, secondDigit) + 1; fifthFigit <= n; fifthFigit++)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ", firstDigit, secondDigit, thirdCharacter, fourthCharacter, fifthFigit);
                            }
                        }
                    }
                }
            }
        }
    }
}
