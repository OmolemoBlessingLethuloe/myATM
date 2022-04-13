using Abp.Application.Services;
using Abp.Domain.Repositories;
using myATM.Clients;
using myATM.Clients.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myATM.Clients
{
    public class ClientAppService : AsyncCrudAppService<Client, ClientDTO, int>, IClientAppService
    {
        public ClientAppService(IRepository<Client, int> repository) : base(repository)
        {

        }
    }
}
