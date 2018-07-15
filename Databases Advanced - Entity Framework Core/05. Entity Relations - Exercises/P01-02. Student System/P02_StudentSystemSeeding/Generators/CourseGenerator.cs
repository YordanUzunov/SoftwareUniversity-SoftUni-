namespace P02_StudentSystemSeeding.Generators
{
    using P01_StudentSystem.Data;
    using P01_StudentSystem.Data.Models;
    using System;

    public class CourseGenerator
    {
        private static readonly Random rnd = new Random();
        private static readonly string[] courses = { "Health & Life Sciences", "Business", "Engineering Technologies",
            "Construction", "Environment & Natural Resources", "Trades & Apprenticeship", "Computers & IT",
            "Hospitality & Culinary", "Design & Communications", "Upgrading & ESL" };
        private readonly int[] years = { 2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009 };
        private readonly decimal[] prices = { 200.00m, 250.00m, 300.00m, 400.00m, 500.00m };
        private readonly int[] courseDaysLength = { 60, 90, 120, 180 };


        internal Course NewCourse()
        {
            DateTime startDate = RandomDay(years[rnd.Next(0, years.Length)]);

            var course = new Course()
            {
                Name = courses[rnd.Next(0, courses.Length)],
                StartDate = startDate,
                EndDate = startDate.AddDays(courseDaysLength[rnd.Next(0, courseDaysLength.Length)]),
                Price = prices[rnd.Next(0, prices.Length)]
            };

            return course;
        }

        private static DateTime RandomDay(int startYear)
        {
            DateTime start = new DateTime(startYear, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(rnd.Next(range));
        }
    }
}
