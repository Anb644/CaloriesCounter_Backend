using Abp.Application.Services;
using CaloriesCounter.MultiTenancy.Dto;

namespace CaloriesCounter.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

