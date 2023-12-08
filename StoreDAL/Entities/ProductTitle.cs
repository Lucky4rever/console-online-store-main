using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreDAL.Entities
{
    [Table("product_titles")]
    public class ProductTitle : BaseEntity
    {
        [Column("product_title")]
        public string Title { get; set; }
        [ForeignKey("product_category_id")]
        [Column("category_id")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public virtual IList<Product> Products { get; }

        public ProductTitle() : base()
        {
            this.Category = new();
            this.Products = new List<Product>();
            this.Title = "";
        }
        public ProductTitle(int id, string title, int categoryId) : base(id)
        {
            this.Category = new();
            this.Products = new List<Product>();
            this.Title = title;
            this.CategoryId = categoryId;
        }
    }
}
