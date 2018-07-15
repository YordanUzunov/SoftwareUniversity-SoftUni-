namespace P02_StudentSystemSeeding.Generators
{
    using P01_StudentSystem.Data;
    using P01_StudentSystem.Data.Models;
    using System;


    public class StudentCourseGenerator
    {
        private static readonly Random rnd = new Random();

        public StudentCourse NewStudentCourse()
        {
            
            var studentCourse = new StudentCourse()
            {
                StudentId = rnd.Next(1, 200),
                CourseId = rnd.Next(1, 100)
            };

            return studentCourse;
        }
    }
}
