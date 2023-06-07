namespace theWorldOfHumans.Infrastructure
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using theWorldOfHumans.Data;

    public static class ApplicationBuilderExtensions
    {
        public static void ApplyMigrations(this IApplicationBuilder app)
        {
            using var services = app.ApplicationServices.CreateScope();

            var dbContext = services.ServiceProvider.GetService<theWorldOfHumansDbContext>();

            dbContext.Database.Migrate();
        }
    }
}
