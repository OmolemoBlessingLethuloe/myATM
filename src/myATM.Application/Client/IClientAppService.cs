using Abp.Application.Services;
using myATM.Clients.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myATM.Clients
{
    public interface IClientAppService : IAsyncCrudAppService<ClientDTO, int>
    {
    }
}
