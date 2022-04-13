using System.Threading.Tasks;
using Abp.Application.Services;
using myATM.Sessions.Dto;

namespace myATM.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
