using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CaloriesCounter.Configuration;
using CaloriesCounter.EntityFrameworkCore;
using CaloriesCounter.Migrator.DependencyInjection;

namespace CaloriesCounter.Migrator
{
    [DependsOn(typeof(CaloriesCounterEntityFrameworkModule))]
    public class CaloriesCounterMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public CaloriesCounterMigratorModule(CaloriesCounterEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(CaloriesCounterMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                CaloriesCounterConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CaloriesCounterMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
