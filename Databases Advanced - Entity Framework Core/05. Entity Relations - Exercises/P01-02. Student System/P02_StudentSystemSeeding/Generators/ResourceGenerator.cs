namespace P02_StudentSystemSeeding.Generators
{
    using P01_StudentSystem.Data;
    using P01_StudentSystem.Data.Models;
    using P01_StudentSystem.Data.Models.Enums;
    using System;

    public class ResourceGenerator
    {
        private static readonly Random rnd = new Random();
        private static readonly string[] resources = { "Syllabus", "MainMaterial", "AdditionalMaterial",
            "Lectures", "HomeworkExercises", "FAQ", "Basics", "Advanced", "NextLevelStuff", "CaseStudies" };
        private static readonly string[] domains = { "mail.bg", "abv.bg", "gmail.com", "hotmail.com", "softuni.bg", "students.softuni.bg" };
        private static int[] enums = { 0, 1, 2, 3 };

        internal Resource NewResource()
        {
            var resourceName = resources[rnd.Next(0, resources.Length)];

            var resource = new Resource()
            {
                Name = resourceName,
                Url = resourceName + "." + domains[rnd.Next(0, domains.Length)],
                ResourceType = (ResourceType)enums[rnd.Next(0, enums.Length)],
                CourseId = rnd.Next(1, 100)
            };

            return resource;
        }
    }
}
