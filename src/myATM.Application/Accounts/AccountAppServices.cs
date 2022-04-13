using Abp.Application.Services;
using Abp.Domain.Repositories;
using myATM.Accounts.Dto;
using myATM.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myATM.Accounts
{
    public class AccountAppServices : AsyncCrudAppService<Account,AccountDto, int>, IAccountAppServices
    {
        public AccountAppServices(IRepository<Account, int> repository) : base(repository)
        {
        }
    }
}
