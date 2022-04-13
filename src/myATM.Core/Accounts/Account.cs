using Abp.Domain.Entities;
using myATM.Clients;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myATM.Accounts
{
    public class Account : Entity
    {
        [ForeignKey("ClientId")]
        public Client Client { get; set; }
        public int ClientId  { get; set; }
        public string AccountType { get; set; } 
        public decimal AvailableBalance { get; set; }
        public string AccountNo { get; set; }


    }
}
