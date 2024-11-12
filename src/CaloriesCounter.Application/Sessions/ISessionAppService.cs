using System.Threading.Tasks;
using Abp.Application.Services;
using CaloriesCounter.Sessions.Dto;

namespace CaloriesCounter.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
