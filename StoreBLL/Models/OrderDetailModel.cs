using System;
using System.Collections.Generic;


namespace StoreBLL.Models
{
    public class OrderDetailModel : AbstractModel
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public OrderDetailModel(int id, int orderId, int productId, int quantity):base(id)
        {
            this.OrderId = orderId;
            this.ProductId = productId;
            this.Quantity = quantity;
        }
        public override string ToString()
        {
            return $"Id:{Id} OrderId:{OrderId} ProductId:{ProductId} Quantity:{Quantity}";
        }
    }
}
