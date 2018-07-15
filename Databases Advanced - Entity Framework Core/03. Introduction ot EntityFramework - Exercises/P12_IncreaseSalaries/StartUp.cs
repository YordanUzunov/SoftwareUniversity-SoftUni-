namespace P12_IncreaseSalaries
{
    using P02_DatabaseFirst.Data;
    using P02_DatabaseFirst.Data.Models;
    using System;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            using (var context = new SoftUniContext())
            {
                string[] departments = new string[] { "Engineering", "Tool Design", "Marketing", "Information Services" };

                var employees = context.Employees
                    .Where(x => departments.Any(s => s == x.Department.Name))
                    .OrderBy(x => x.FirstName)
                    .ThenBy(x => x.LastName)
                    .ToArray();

                using (StreamWriter sw = new StreamWriter("../SoftUniData.txt"))
                {
                    foreach (var e in employees)
                    {
                        e.Salary *= 1.12m;
                        sw.WriteLine($"{e.FirstName} {e.LastName} (${e.Salary:F2})");
                    }
                }
                context.SaveChanges();
            }
        }
    }
}
