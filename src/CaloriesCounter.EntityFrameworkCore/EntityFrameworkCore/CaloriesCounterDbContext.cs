using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using CaloriesCounter.Authorization.Roles;
using CaloriesCounter.Authorization.Users;
using CaloriesCounter.MultiTenancy;

namespace CaloriesCounter.EntityFrameworkCore
{
    public class CaloriesCounterDbContext : AbpZeroDbContext<Tenant, Role, User, CaloriesCounterDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public CaloriesCounterDbContext(DbContextOptions<CaloriesCounterDbContext> options)
            : base(options)
        {
        }
    }
}
