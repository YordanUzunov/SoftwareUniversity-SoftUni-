namespace Pub.Services
{
    using Microsoft.EntityFrameworkCore;

    using Pub.Data;
    using Pub.Services.Contracts;

    public class DbInitializerService : IDbInitializerService
    {
        private readonly PubContext context;

        public DbInitializerService(PubContext context)
        {
            this.context = context;
        }

        public void InitializeDatabase()
        {
            this.context.Database.Migrate();
        }
    }
}
