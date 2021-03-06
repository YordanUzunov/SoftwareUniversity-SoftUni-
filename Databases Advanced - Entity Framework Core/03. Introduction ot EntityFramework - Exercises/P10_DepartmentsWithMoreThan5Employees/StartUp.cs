﻿namespace P10_DepartmentsWithMoreThan5Employees
{
    using P02_DatabaseFirst.Data;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            using (var context = new SoftUniContext())
            {
                var departments = context.Departments
                    .Where(x => x.Employees.Count > 5)
                    .OrderBy(x => x.Employees.Count)
                    .ThenBy(x => x.Name)
                    .Select(x => new
                    {
                        DepartmentName = x.Name,
                        ManagerName = x.Manager.FirstName + " " + x.Manager.LastName,
                        Employees = x.Employees.Select(s => new
                        {
                            s.FirstName,
                            s.LastName,
                            s.JobTitle
                        })
                        .OrderBy(s => s.FirstName)
                        .ThenBy(s => s.LastName)
                    })
                    .ToArray();

                using (StreamWriter sw = new StreamWriter("../SoftUniData.txt"))
                {
                    foreach (var d in departments)
                    {
                        sw.WriteLine($"{d.DepartmentName} - {d.ManagerName}");

                        foreach (var e in d.Employees)
                        {
                            sw.WriteLine($"{e.FirstName} {e.LastName} - {e.JobTitle}");
                        }

                        sw.WriteLine("----------");
                    }
                }
            }
        }
    }
}
