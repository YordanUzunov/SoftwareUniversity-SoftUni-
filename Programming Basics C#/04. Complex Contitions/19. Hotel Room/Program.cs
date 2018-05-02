namespace _19._Hotel_Room
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var month = Console.ReadLine();
            var numberOfNights = int.Parse(Console.ReadLine());

            double appartmentPrice = 0;
            double studioPrice = 0;
            if (month == "May" || month == "October")
            {
                studioPrice = 50 * numberOfNights;
                appartmentPrice = 65 * numberOfNights;
                if (numberOfNights > 7 && numberOfNights <= 14)
                {
                    studioPrice *= 0.95;
                }
                else if (numberOfNights > 14)
                {
                    studioPrice *= 0.70;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 75.20 * numberOfNights;
                appartmentPrice = 68.70 * numberOfNights;
                if (numberOfNights > 14)
                {
                    studioPrice *= 0.80;
                }
            }
            else if (month == "July" || month == "August")
            {
                studioPrice = 76 * numberOfNights;
                appartmentPrice = 77 * numberOfNights;
            }

            if (numberOfNights > 14)
            {
                appartmentPrice *= 0.90;
            }

            Console.WriteLine("Apartment: {0:f2} lv.", appartmentPrice);
            Console.WriteLine("Studio: {0:f2} lv.", studioPrice);
        }
    }
}
