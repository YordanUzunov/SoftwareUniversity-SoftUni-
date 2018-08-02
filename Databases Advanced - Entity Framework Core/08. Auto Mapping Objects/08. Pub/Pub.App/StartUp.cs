namespace Pub.App
{
    using System;
    using AutoMapper.QueryableExtensions;
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    using Pub.App.Core;
    using Pub.App.Core.Contracts;
    using Pub.App.Core.Controllers;
    using Pub.Data;
    using Pub.Services;
    using Pub.Services.Contracts;   

    public class StartUp
    {
        public static void Main()
        {
            var service = ConfigureService();
            IEngine engine = new Engine(service);
            engine.Run();
        }

        private static IServiceProvider ConfigureService()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddDbContext<PubContext>(opts => opts.UseSqlServer(Configuration.ConnectionString));

            serviceCollection.AddAutoMapper(conf => conf.AddProfile<PubProfile>());

            serviceCollection.AddTransient<IDbInitializerService, DbInitializerService>();

            serviceCollection.AddTransient<ICommandInterpreter, CommandInterpreter>();

            serviceCollection.AddTransient<IEmployeeController, EmployeeController>();

            serviceCollection.AddTransient<IManagerController, ManagerController>();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            return serviceProvider;
        }
    }
}
