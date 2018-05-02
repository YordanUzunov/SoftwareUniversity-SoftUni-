namespace _15._On_time_for_Exam
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var examHour = int.Parse(Console.ReadLine());
            var examMinute = int.Parse(Console.ReadLine());
            var arrivalHour = int.Parse(Console.ReadLine());
            var arrivalMinute = int.Parse(Console.ReadLine());

            int examSumMinutes = examHour * 60 + examMinute;
            int arrivalSumMinutes = arrivalHour * 60 + arrivalMinute;

            if (arrivalSumMinutes > examSumMinutes)
            {
                Console.WriteLine("Late");
                if (arrivalSumMinutes - examSumMinutes < 60)
                {
                    Console.WriteLine("{0} minutes after the start", arrivalSumMinutes - examSumMinutes);
                }
                else
                {
                    Console.WriteLine("{0}:{1} hours after the start",
                      (arrivalSumMinutes - examSumMinutes) / 60, (arrivalSumMinutes - examSumMinutes) % 60);
                }
            }
            else
            {
                if (arrivalSumMinutes <= examSumMinutes && arrivalSumMinutes >= examSumMinutes - 30)
                {
                    Console.WriteLine("On time");
                }
                else
                {
                    Console.WriteLine("Early");
                }
                if (examSumMinutes - arrivalSumMinutes != 0)
                {
                    if (examSumMinutes - arrivalSumMinutes < 60)
                    {
                        Console.WriteLine("{0} minutes before the start", examSumMinutes - arrivalSumMinutes);
                    }
                    
                    else
                    {
                        Console.WriteLine("{0}:{1} hours before the start",
                        (examSumMinutes - arrivalSumMinutes) / 60, (examSumMinutes - arrivalSumMinutes) % 60);
                    }
                }
            }
        }
    }
}
