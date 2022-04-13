using Abp.Application.Services;
using myATM.Accounts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myATM.Accounts
{
    public interface IAccountAppServices : IAsyncCrudAppService<AccountDto, int>
    {
    }
}
