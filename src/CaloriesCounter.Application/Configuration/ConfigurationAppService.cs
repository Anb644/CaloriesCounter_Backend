using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using CaloriesCounter.Configuration.Dto;

namespace CaloriesCounter.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : CaloriesCounterAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
