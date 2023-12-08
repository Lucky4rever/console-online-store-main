using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StoreDAL.Entities
{
    [Table("order_states")]
    public class OrderState : BaseEntity
    {
        [Column("state_name")]
        public string StateName {get; set;}
        public virtual IList<CustomerOrder> Order { get; }
        public OrderState() : base()
        {
            this.Order = new List<CustomerOrder>();
            this.StateName = "";
        }
        public OrderState(int id,string stateName):base(id)
        {
            this.Order = new List<CustomerOrder>();
            this.StateName = stateName;
        }
    }
}
