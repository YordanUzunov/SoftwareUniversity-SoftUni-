namespace _14._Time_Plus_15min
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine()) + 15;
            int allMinutes = hours * 60 + minutes;
            //First find the total hours and if they are more than 24 => %, to become a normal hour
            Console.Write("{0}:", allMinutes / 60 % 24);
            //Catch the case, when leading 0 needs to be added in front of minutes
            if (allMinutes % 60 < 10)
                Console.Write("0");
            Console.WriteLine(allMinutes % 60);
        }
    }
}
