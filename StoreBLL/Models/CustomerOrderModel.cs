using StoreDAL.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreBLL.Models
{
    public class CustomerOrderModel : AbstractModel
    {
        public string OperationTime { get; set; }
        public int CustomerId { get; set; }
        public int OrderStateId { get; set; }

        public CustomerOrderModel(int id, string operationTime, int customerId, int orderStateId):base(id) 
        {
            this.OperationTime = operationTime;
            this.CustomerId = customerId;
            this.OrderStateId = orderStateId;
        }
        public override string ToString()
        {
            return $"Id:{Id} Operation time:{OperationTime} CustomerId:{CustomerId} OrderStateId:{OrderStateId}";
        }
    }
}
