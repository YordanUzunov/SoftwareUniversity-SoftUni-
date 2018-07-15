namespace P02_StudentSystemSeeding.Generators
{
    using P01_StudentSystem.Data;
    using P01_StudentSystem.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class StudentGenerator
    {
        private readonly Random rnd = new Random();
        private readonly string[] digits = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        private readonly int[] years = { 2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009 };
        private readonly int[] birthdayYears = { 1990, 1991, 1992, 1993, 1994, 1995, 1996, 1997, 1998, 1999 };

        public Student NewStudent()
        {
            string firstName = StudentNameGenerator.FirstName();
            string lastName = StudentNameGenerator.LastName();
            string fullName = firstName + " " + lastName;

            string phoneNumber = GeneratePhoneNumber();

            var student = new Student()
            {
                Name = fullName,
                PhoneNumber = phoneNumber,
                RegisteredOn = RandomDay(years[rnd.Next(0, years.Length)]),
                Birthday = RandomDay(birthdayYears[rnd.Next(0, birthdayYears.Length)])
            };

            return student;
        }

        private string GeneratePhoneNumber()
        {
            string phoneNumber = "08";
            for (int i = 0; i < 8; i++)
            {
                int index = rnd.Next(0, digits.Length);

                string digit = digits[index];

                phoneNumber += digit;
            }

            return phoneNumber;
        }

        private DateTime RandomDay(int startYear)
        {
            DateTime start = new DateTime(startYear, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(rnd.Next(range));
        }

    }
}
