namespace _08._Employee_Data
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = Console.ReadLine()[0];
            long personalID = long.Parse(Console.ReadLine());
            int employeeNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("First name: {0}\n" +
                "Last name: {1}\n" +
                "Age: {2}\n" +
                "Gender: {3}\n" +
                "Personal ID: {4}\n" +
                "Unique Employee number: {5}", firstName, lastName, age, gender, personalID, employeeNumber);
        }
    }
}
