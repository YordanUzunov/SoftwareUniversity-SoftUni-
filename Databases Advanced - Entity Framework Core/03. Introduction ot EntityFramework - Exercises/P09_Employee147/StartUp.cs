namespace P09_Employee147
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
                var employee = context.Employees.
                        Where(e => e.EmployeeId == 147)
                        .Select(e => new
                        {
                            e.FirstName,
                            e.LastName,
                            e.JobTitle,
                            Projects = e.EmployeesProjects
                                .Select(ep => ep.Project.Name)
                                .OrderBy(p => p)
                                .ToList()
                        })
                        .First();

                Console.WriteLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}{Environment.NewLine}{String.Join(Environment.NewLine, employee.Projects)}");
            }
        }
    }
}

