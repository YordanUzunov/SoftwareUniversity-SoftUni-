namespace _12._Volleyball
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string year = Console.ReadLine().ToLower();
            var holidays = int.Parse(Console.ReadLine());
            var goHome = int.Parse(Console.ReadLine());

            // 2 / 3 from holidays
            double playTime = 2 / 3.0 * holidays;
            // goHome = how many times he goes home per year, 
            // where he plays volleybal with his old friends
            playTime += goHome;
            // the year has 48 weekends
            // Vladi is not working 3/4 of the weekends, from which he is in Sofia
            playTime += (48 - goHome) * (3.0 / 4);
            // In leap years he plays 15% more than usual
            if (year.Equals("leap"))
                playTime *= 1.15;

            Console.WriteLine((int)playTime);
        }
    }
}
