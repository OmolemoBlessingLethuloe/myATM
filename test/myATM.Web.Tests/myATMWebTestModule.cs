using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using myATM.EntityFrameworkCore;
using myATM.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace myATM.Web.Tests
{
    [DependsOn(
        typeof(myATMWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class myATMWebTestModule : AbpModule
    {
        public myATMWebTestModule(myATMEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(myATMWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(myATMWebMvcModule).Assembly);
        }
    }
}