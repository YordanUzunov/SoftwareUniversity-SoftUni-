namespace P05_EmployeesFromResearchAndDevelopment
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
                context.Employees
                    .Where(e => e.Department.Name == "Research and Development")
                    .OrderBy(e => e.Salary)
                    .ThenByDescending(e => e.FirstName)
                    .Select(e => new { e.FirstName, e.LastName, DepartmentName = e.Department.Name, e.Salary })
                    .ToList()
                    .ForEach(e => Console.WriteLine($"{e.FirstName} {e.LastName} from {e.DepartmentName} - ${e.Salary:f2}"));
            }
        }
    }
}
