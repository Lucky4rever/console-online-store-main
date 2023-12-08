using StoreDAL.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace StoreDAL.Entities
{
    [Table("categories")]
    public class Category : BaseEntity
    {
        [Column("category_name")]
        public string Name { get; set; }
        public virtual IList<ProductTitle> Titles { get; }
        public Category():base()
        {
            this.Name = "";
            this.Titles = new List<ProductTitle>();
        }
        public Category(int id, string name) : base(id)
        {
            this.Name = name;
            this.Titles = new List<ProductTitle>();
        }
    }
}
