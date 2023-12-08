using StoreDAL.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreBLL.Models
{
    public class CustomerOrderModel : AbstractModel
    {
        public string OrderDate { get; set; }
        public int CustomerId { get; set; }
        public int OrderStateId { get; set; }

        public CustomerOrderModel(int id, string orderDate, int customerId, int orderStateId):base(id) 
        {
            this.OrderDate = orderDate;
            this.CustomerId = customerId;
            this.OrderStateId = orderStateId;
        }
        public override string ToString()
        {
            return $"Id:{Id} Date:{OrderDate} CustomerId:{CustomerId} OrderStateId:{OrderStateId}";
        }
    }
}
