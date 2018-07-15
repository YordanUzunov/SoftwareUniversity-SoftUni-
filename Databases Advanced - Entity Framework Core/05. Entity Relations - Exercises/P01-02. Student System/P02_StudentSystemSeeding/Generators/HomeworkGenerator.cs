namespace P02_StudentSystemSeeding.Generators
{
    using P01_StudentSystem.Data;
    using P01_StudentSystem.Data.Models;
    using P01_StudentSystem.Data.Models.Enums;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class HomeworkGenerator
    {
        private static readonly Random rnd = new Random();
        private static readonly string[] content = { "Beginner", "Intermediate", "Advanced", "Master" };
        private static int[] enums = { 0, 1, 2};
        private readonly int[] years = { 2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009 };

        internal Homework NewHomework()
        {
            var homework = new Homework()
            {
                Content = content[rnd.Next(0, content.Length)],
                ContentType = (ContentType)enums[rnd.Next(0, enums.Length)],
                SubmissionTime = RandomDay(years[rnd.Next(0, years.Length)]),
                StudentId = rnd.Next(1, 200),
                CourseId = rnd.Next(1, 100)
            };

            return homework;
        }

        private static DateTime RandomDay(int startYear)
        {
            DateTime start = new DateTime(startYear, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(rnd.Next(range));
        }
    }
}
