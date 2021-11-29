namespace SulsApp
{
    using Microsoft.EntityFrameworkCore;
    using SIS.HTTP;
    using SIS.MvcFramework;
    using SulsApp.Services;
    using System.Collections.Generic;

    public class Startup : IMvcApplication
    {
        public void ConfigureServices(IServiceCollection serviceCollection) // Usage: Dependancy Injection.
        {
            serviceCollection.Add<IUsersService, UsersService>();
            serviceCollection.Add<IProblemsService, ProblemsService>();
            serviceCollection.Add<ISubmissionService, SubmissionService>();
        }

        public void Configure(IList<Route> routeTable) // Registrate the routes.
        {
            // Middlewear...
            var db = new ApplicationDbContext();
            db.Database.Migrate();
        }
    }
}