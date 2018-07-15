namespace P07_EmployeesAndProjects
{
    using P02_DatabaseFirst.Data;
    using System;
    using System.Globalization;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            using (var context = new SoftUniContext())
            {
                var employees = context.Employees
                    .Where(e => e.EmployeesProjects
                        .Any(ep => ep.Project.StartDate.Year >= 2001 && ep.Project.StartDate.Year <= 2003))
                    .Select(e => new
                    {
                        EmployeeName = e.FirstName + " " + e.LastName,
                        ManagerName = e.Manager.FirstName + " " + e.Manager.LastName,
                        Projects = e.EmployeesProjects.Select(s => new
                        {
                            ProjectName = s.Project.Name,
                            StartDate = s.Project.StartDate,
                            EndDate = s.Project.EndDate
                        }).ToArray()
                    })
                    .Take(30)
                    .ToArray();

                using (StreamWriter sw = new StreamWriter("../SoftUniData.txt"))
                {
                    foreach (var e in employees)
                    {
                        sw.WriteLine($"{e.EmployeeName} - Manager: {e.ManagerName}");

                        foreach (var p in e.Projects)
                        {
                            sw.WriteLine($"--{p.ProjectName} - {p.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)} " +
                                $"- {p.EndDate?.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture) ?? "not finished"}");
                        }
                    }
                }
            }        
        }
    }
}
