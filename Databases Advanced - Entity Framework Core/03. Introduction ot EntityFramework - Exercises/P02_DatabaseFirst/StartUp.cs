namespace P02_DatabaseFirst
{
    using P02_DatabaseFirst.Data;
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            using (SoftUniContext context = new SoftUniContext())
            {
                var employees = context.Employees.ToArray();

                foreach (var e in employees)
                {
                    Console.WriteLine(e.FirstName);
                }               
            }
        }
    }
}
