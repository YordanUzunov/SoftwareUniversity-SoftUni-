namespace P03_EmployeesFullInformation
{
    using P02_DatabaseFirst.Data;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            using (SoftUniContext context = new SoftUniContext())
            {
                var employees = context.Employees
                    .OrderBy(x => x.EmployeeId)
                    .Select(x => new
                    {
                        FirstName = x.FirstName,
                        LastName = x.LastName,
                        MiddleName = x.MiddleName,
                        JobTitle = x.JobTitle,
                        Salary = x.Salary
                    })
                    .ToArray();

                using (StreamWriter sw = new StreamWriter("../Employees.txt"))
                {
                    foreach (var e in employees)
                    {
                        sw.WriteLine($"{e.FirstName} {e.LastName} {e.MiddleName} {e.JobTitle} {e.Salary:F2}");
                    }
                }
            }
        }
    }
}
