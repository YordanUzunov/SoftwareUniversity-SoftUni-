namespace _01._ExcellentResult
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var grade = float.Parse(Console.ReadLine());
            if (grade >= 5.50)
                Console.WriteLine("Excellent!");
        }
    }
}
