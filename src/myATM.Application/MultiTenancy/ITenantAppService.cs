using Abp.Application.Services;
using myATM.MultiTenancy.Dto;

namespace myATM.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

