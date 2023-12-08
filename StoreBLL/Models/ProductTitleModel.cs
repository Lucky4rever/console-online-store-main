using System;
using System.Collections.Generic;


namespace StoreBLL.Models
{
    public class ProductTitleModel : AbstractModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }

        public ProductTitleModel(int id, string title, string description, int categoryId) : base(id)
        {
            this.Title = title;
            this.Description = description;
            this.CategoryId = categoryId;
        }
        public override string ToString()
        {
            return $"Id:{Id} Title:{Title} Description:{Description} CategoryId:{CategoryId}";
        }
    }
}
