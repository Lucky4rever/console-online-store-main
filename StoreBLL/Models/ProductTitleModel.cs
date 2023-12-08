using System;
using System.Collections.Generic;


namespace StoreBLL.Models
{
    public class ProductTitleModel : AbstractModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }

        public ProductTitleModel(int id, string title, string description, decimal price, string image):base(id)
        {
            this.Title = title;
            this.Description = description;
            this.Price = price;
            this.Image = image;
        }
        public override string ToString()
        {
            return $"Id:{Id} {Name}";
        }
    }
}
