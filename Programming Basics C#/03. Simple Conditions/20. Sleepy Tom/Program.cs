namespace _20._Sleepy_Tom
{
    using System;

    public class Program
    {
        public static void Main()
        {

            var restDaysPerYear = int.Parse(Console.ReadLine());
            int playTime = (365 - restDaysPerYear) * 63 + restDaysPerYear * 127;
            if (playTime > 30000)
            {
                Console.WriteLine("Tom will run away");
                int exess = playTime - 30000;
                Console.WriteLine("{0} hours and {1} minutes more for play", exess / 60, exess % 60);
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                int less = 30000 - playTime;
                Console.WriteLine("{0} hours and {1} minutes less for play", less / 60, less % 60);
            }
        }
    }
}
