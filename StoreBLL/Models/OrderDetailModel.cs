using System;
using System.Collections.Generic;


namespace StoreBLL.Models
{
    public class OrderDetailModel : AbstractModel
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public int ProductAmount { get; set; }

        public OrderDetailModel(int id, int orderId, int productId, decimal price, int amount) : base(id)
        {
            this.OrderId = orderId;
            this.ProductId = productId;
            this.Price = price;
            this.ProductAmount = amount;
        }
        public override string ToString()
        {
            return $"Id:{Id} OrderId:{OrderId} ProductId:{ProductId} Price:{Price} Product Amount:{ProductAmount}";
        }
    }
}
