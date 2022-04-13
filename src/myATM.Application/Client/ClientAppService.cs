using Abp.Application.Services;
using Abp.Domain.Repositories;
using myATM.Client.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myATM.Client
{
    public class ClientAppService : AsyncCrudAppService<Client, ClientDTO, int>, IClientAppService
    {
        public ClientAppService(IRepository<Client, int> repository) : base(repository)
        {

        }
    }
}
