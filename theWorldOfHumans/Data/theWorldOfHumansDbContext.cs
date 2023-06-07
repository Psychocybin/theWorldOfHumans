namespace theWorldOfHumans.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using theWorldOfHumans.Data.Models;

    public class theWorldOfHumansDbContext : IdentityDbContext<User>
    {
        public theWorldOfHumansDbContext(DbContextOptions<theWorldOfHumansDbContext> options)
            : base(options)
        {
        }
    }
}
