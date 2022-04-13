using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using myATM.Clients;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myATM.Accounts.Dto
{
    [AutoMapFrom(typeof(Account))]
    public class AccountDto : EntityDto<int>
    {
        public int ClientId { get; set; }
        public string AccountType { get; set; }
        public decimal AvailableBalance { get; set; }
        public string AccountNo { get; set; }
    }
}
