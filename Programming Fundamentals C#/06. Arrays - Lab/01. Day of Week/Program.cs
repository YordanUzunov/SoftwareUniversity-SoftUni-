namespace _01._Day_of_Week
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int day = int.Parse(Console.ReadLine()) - 1;
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            Console.WriteLine((day >= 0 && day <= 6) ? days[day] : "Invalid Day!");   // to avoid the index outside of array
        }
    }
}
