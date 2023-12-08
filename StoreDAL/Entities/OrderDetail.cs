using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreDAL.Entities
{
    [Table("customer_order_details")]
    public class OrderDetail : BaseEntity
    {
        [ForeignKey("customer_order_id")]
        [Column("customer_order_id")]
        public int OrderId { get; set; }
        [ForeignKey("product_id")]
        [Column("product_id")]
        public int ProductId { get; set; }
        [Column("price")]
        public decimal Price { get; set; }
        [Column("product_amount")]
        public int ProductAmount { get; set; }
        public CustomerOrder Order { get; set; }
        public Product Product { get; set; }

        public OrderDetail() : base() { }
        public OrderDetail(int id, int orderId, int productId, decimal price, int amount) : base(id)
        {
            this.OrderId = orderId;
            this.ProductId = productId;
            this.Price = price;
            this.ProductAmount = amount;
        }
    }
}
