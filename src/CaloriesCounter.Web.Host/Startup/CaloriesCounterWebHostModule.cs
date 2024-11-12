using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CaloriesCounter.Configuration;

namespace CaloriesCounter.Web.Host.Startup
{
    [DependsOn(
       typeof(CaloriesCounterWebCoreModule))]
    public class CaloriesCounterWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public CaloriesCounterWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CaloriesCounterWebHostModule).GetAssembly());
        }
    }
}
