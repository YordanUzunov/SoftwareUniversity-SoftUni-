using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data;
using P01_StudentSystem.Data.Models;
using P02_StudentSystemSeeding.Generators;
using System;

namespace P02_StudentSystemSeeding
{
    public class DatabaseInitializer
    {

        public void ResetDatabase()
        {
            using (var context = new StudentSystemContext())
            {
                context.Database.EnsureDeleted();

                context.Database.Migrate();

                InitialSeed(context);
            }
        }

        public void InitialSeed(StudentSystemContext context)
        {
            SeedCourses(context, 100);

            SeedStudents(context, 200);

            SeedResources(context, 120);

            SeedHomeworks(context, 300);

            SeedStudentCourses(context, 400);
        }

        private static void SeedResources(StudentSystemContext context, int count)
        {
            var resourceGenerator = new ResourceGenerator();

            for (int i = 0; i < count; i++)
            {
                context.Resources.Add(resourceGenerator.NewResource());
            }

            context.SaveChanges();
        }

        private static void SeedStudents(StudentSystemContext context, int count)
        {
            var studentGenerator = new StudentGenerator();

            for (int i = 0; i < count; i++)
            {
                context.Students.Add(studentGenerator.NewStudent());
            }

            context.SaveChanges();
        }

        private static void SeedCourses(StudentSystemContext context, int count)
        {
            var courseGenerator = new CourseGenerator();

            for (int i = 0; i < count; i++)
            {
                context.Courses.Add(courseGenerator.NewCourse());
            }

            context.SaveChanges();
        }

        private static void SeedHomeworks(StudentSystemContext context, int count)
        {
            var homeworkGenerator = new HomeworkGenerator();

            for (int i = 0; i < count; i++)
            {
                context.HomeworkSubmissions.Add(homeworkGenerator.NewHomework());
            }

            context.SaveChanges();
        }


        private void SeedStudentCourses(StudentSystemContext context, int count)
        {
            var homeworkGenerator = new StudentCourseGenerator();

            for (int i = 0; i < count; i++)
            {
                context.StudentCourses.Add(homeworkGenerator.NewStudentCourse());
            }

            context.SaveChanges();
        }
    }
}
