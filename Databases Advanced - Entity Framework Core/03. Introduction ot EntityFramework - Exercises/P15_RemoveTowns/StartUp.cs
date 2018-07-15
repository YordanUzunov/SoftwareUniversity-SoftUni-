namespace P15_RemoveTowns
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
                string townName = Console.ReadLine();

                context.Employees
                    .Where(e => e.Address.Town.Name == townName)
                    .ToList()
                    .ForEach(e => e.AddressId = null);

                int addressesCount = context.Addresses
                    .Where(a => a.Town.Name == townName)
                    .Count();

                context.Addresses
                    .Where(a => a.Town.Name == townName)
                    .ToList()
                    .ForEach(a => context.Addresses.Remove(a));

                context.Towns
                    .Remove(context.Towns
                        .SingleOrDefault(t => t.Name == townName));

                context.SaveChanges();

                Console.WriteLine($"{addressesCount} {(addressesCount == 1 ? "address" : "addresses")} in {townName} {(addressesCount == 1 ? "was" : "were")} deleted");
            }
        }
    }
}
