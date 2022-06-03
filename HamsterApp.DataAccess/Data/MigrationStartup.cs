using HamsterApp.Entities.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HamsterApp.DataAccess.Data
{
    public class MigrationStartup<TContext> : IStartupFilter where TContext : IdentityDbContext<ApiUser>
    {
        public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
        {
            return app =>
            {
                using (var scope = app.ApplicationServices.CreateScope())
                {
                    foreach (var context in scope.ServiceProvider.GetServices<TContext>())
                    {
                        context.Database.SetCommandTimeout(160);
                        context.Database.Migrate();
                    }
                }
                next(app);
            };
        }
    }
}
