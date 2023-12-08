using StoreDAL.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreBLL.Models
{
    public class CategoryModel : AbstractModel
    {
        public string Name { get; set; }
        public CategoryModel(int id, string name):base(id) 
        {
            this.Name = name;
        }
        public override string ToString()
        {
            return $"Id:{Id} {Name}";
        }
    }
}
