namespace MiniORM.App
{
    using Data;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            const string connectionString = @"Server=.;DataBase=MiniORM;Integrated Security=True";

            var context = new SoftUniDbContext(connectionString);

            ;
        }
    }
}
