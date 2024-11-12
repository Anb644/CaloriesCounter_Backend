using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CaloriesCounter.Authorization;

namespace CaloriesCounter
{
    [DependsOn(
        typeof(CaloriesCounterCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class CaloriesCounterApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<CaloriesCounterAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(CaloriesCounterApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
