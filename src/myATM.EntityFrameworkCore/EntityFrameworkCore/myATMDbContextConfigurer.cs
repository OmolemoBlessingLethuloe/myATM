using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace myATM.EntityFrameworkCore
{
    public static class myATMDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<myATMDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<myATMDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
