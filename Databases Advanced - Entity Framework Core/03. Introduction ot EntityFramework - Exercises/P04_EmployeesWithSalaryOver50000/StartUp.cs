namespace P04_EmployeesWithSalaryOver50000
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
                    .Where(x => x.Salary > 50000)
                    .Select(x => new { x.FirstName })
                    .OrderBy(x => x.FirstName)
                    .ToList()
                    .ForEach(x => Console.WriteLine(x.FirstName)); 
            }
        }
    }
}
