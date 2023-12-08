using StoreDAL.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreBLL.Models
{
    public class CustomerOrderModel : AbstractModel
    {
        public string Name { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public int OrderStateId { get; set; }

        public CustomerOrderModel(int id, string name, DateTime orderDate, int customerId, int orderStateId):base(id) 
        {
            this.Name = name;
            this.OrderDate = orderDate;
            this.CustomerId = customerId;
            this.OrderStateId = orderStateId;
        }
        public override string ToString()
        {
            return $"Id:{Id} Name:{Name} Date:{OrderDate} CustomerId:{CustomerId} OrderStateId:{OrderStateId}";
        }
    }
}
