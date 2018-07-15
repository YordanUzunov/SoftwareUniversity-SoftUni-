namespace P08_AddressesByTown
{
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
                var addresses = context.Addresses
                    .OrderByDescending(x => x.Employees.Count())
                    .ThenBy(x => x.Town.Name)
                    .ThenBy(x => x.AddressText)
                    .Select(x => new
                    {
                        AddressText = x.AddressText,
                        TownName = x.Town.Name,
                        Count = x.Employees.Count()
                    })
                    .Take(10)
                    .ToArray();

                using (StreamWriter sw = new StreamWriter("../SoftUniData.txt"))
                {
                    foreach (var a in addresses)
                    {
                        sw.WriteLine($"{a.AddressText}, {a.TownName} - {a.Count} employees");
                    }
                }
            }
        }
    }
}
