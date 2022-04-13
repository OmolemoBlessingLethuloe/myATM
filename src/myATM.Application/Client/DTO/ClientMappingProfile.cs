using AutoMapper;
using myATM.Clients;
using myATM.Clients.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myATM.Clients.DTO
{
    class ClientMappingProfile : Profile
    {
        public ClientMappingProfile()
        {
            CreateMap<ClientDTO, Client>();
        }
    }
}
