﻿namespace P14_DeleteProjectById
{
    using P02_DatabaseFirst.Data;
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            using (var context = new SoftUniContext())
            {
                var projects = context.EmployeesProjects.Where(x => x.ProjectId == 2);

                context.EmployeesProjects.RemoveRange(projects);

                var project = context.Projects.Find(2);
                context.Projects.Remove(project);
                context.SaveChanges();

                var projectsToPrint = context.Projects.Take(10).ToArray();
                foreach (var p in projectsToPrint)
                {
                    Console.WriteLine(p.Name);
                }

            }
        }
    }
}
