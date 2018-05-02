namespace _01._Salutation_by_Age_and_Gender
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var age = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());

            if (gender == 'm')
            {
                if (age >= 16)
                    Console.WriteLine("Mr.");
                else
                    Console.WriteLine("Master");
            }
            if (gender == 'f')
            {
                if (age >= 16)
                    Console.WriteLine("Ms.");
                else
                    Console.WriteLine("Miss");
            }
        }
    }
}
