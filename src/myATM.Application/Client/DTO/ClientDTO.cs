using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myATM.Client.DTO
{
    [AutoMapFrom(typeof(Client))]
    public class ClientDTO : EntityDto<int>
    {
        public string Name { get; set; }
        public int Pin { get; set; }
    }
}
