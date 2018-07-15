namespace P13_FindEmployeesByFirstNameStartingWithSa
{
    using Microsoft.EntityFrameworkCore;
    using P02_DatabaseFirst.Data;
    using System;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            using (var context = new SoftUniContext())
            {
                var employees = context.Employees.Where(x => EF.Functions.Like(x.FirstName, "Sa%"))
                                                 .Select(x => new
                                                 {
                                                     x.FirstName,
                                                     x.LastName,
                                                     x.JobTitle,
                                                     x.Salary
                                                 })
                                                 .OrderBy(x => x.FirstName)
                                                 .ThenBy(x => x.LastName)
                                                 .ToArray();

                using (StreamWriter sw = new StreamWriter("../SoftUniData.txt"))
                {
                    foreach (var e in employees)
                    {
                        sw.WriteLine($"{e.FirstName} {e.LastName} - {e.JobTitle} - (${e.Salary:F2})");
                    }
                }             
            }
        }
    }
}
