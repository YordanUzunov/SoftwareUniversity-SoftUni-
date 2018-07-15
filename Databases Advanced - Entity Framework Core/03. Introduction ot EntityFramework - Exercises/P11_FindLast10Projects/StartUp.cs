namespace P11_FindLast10Projects
{
    using P02_DatabaseFirst.Data;
    using System;
    using System.Globalization;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            using (var context = new SoftUniContext())
            {
                context.Projects.
                    OrderByDescending(p => p.StartDate)
                    .Take(10)
                    .Select(p => new { p.Name, p.Description, p.StartDate })
                    .OrderBy(p => p.Name)
                    .ToList()
                    .ForEach(p => Console.WriteLine($"{p.Name}{Environment.NewLine}{p.Description}{Environment.NewLine}" +
                    $"{p.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)}"));
            }
        }
    }
}
