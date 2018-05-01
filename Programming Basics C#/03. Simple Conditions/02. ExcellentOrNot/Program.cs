namespace _02._ExcellentOrNot
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var grade = float.Parse(Console.ReadLine());
            if (grade >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
            else
            {
                Console.WriteLine("Not excellent.");
            }
        }
    }
}
