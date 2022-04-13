using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using myATM.Authorization.Roles;
using myATM.Authorization.Users;
using myATM.MultiTenancy;
using myATM.Clients;
using myATM.Accounts;

namespace myATM.EntityFrameworkCore
{
    public class myATMDbContext : AbpZeroDbContext<Tenant, Role, User, myATMDbContext>
    {
        /* Define a DbSet for each entity of the application */

        
        public myATMDbContext(DbContextOptions<myATMDbContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Account> Accounts { get; set; }

    }
}
