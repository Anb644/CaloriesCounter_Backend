using System.Threading.Tasks;
using Abp.Application.Services;
using CaloriesCounter.Authorization.Accounts.Dto;

namespace CaloriesCounter.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
