using System.Threading.Tasks;
using CaloriesCounter.Configuration.Dto;

namespace CaloriesCounter.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
