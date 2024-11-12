using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace CaloriesCounter.EntityFrameworkCore
{
    public static class CaloriesCounterDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CaloriesCounterDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<CaloriesCounterDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
