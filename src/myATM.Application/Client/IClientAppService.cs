using Abp.Application.Services;
using myATM.Client.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myATM.Client
{
    public interface IClientAppService : IAsyncCrudAppService<ClientDTO, int>
    {
    }
}
