using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using myATM.Authorization;

namespace myATM
{
    [DependsOn(
        typeof(myATMCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class myATMApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<myATMAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(myATMApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
