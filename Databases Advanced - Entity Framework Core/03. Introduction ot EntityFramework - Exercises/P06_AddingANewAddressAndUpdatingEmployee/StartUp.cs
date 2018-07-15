namespace P06_AddingANewAddressAndUpdatingEmployee
{
    using P02_DatabaseFirst.Data;
    using P02_DatabaseFirst.Data.Models;
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            using (var context = new SoftUniContext())
            {
                var address = new Address()
                {
                    AddressText = "Vitoshka 15",
                    TownId = 4
                };

                context.Employees
                    .Single(e => e.LastName == "Nakov")
                    .Address = address;

                context.SaveChanges();

                context.Employees
                    .OrderByDescending(e => e.Address.AddressId)
                    .Take(10)
                    .Select(e => e.Address.AddressText)
                    .ToList()
                    .ForEach(text => Console.WriteLine(text));
            }
        }
    }
}
