using System;
using System.Collections.Generic;


namespace StoreBLL.Models
{
    public class ProductModel : AbstractModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int ManufacturerId { get; set; }
        public int CategoryId { get; set; }

        public ProductModel(int id, string name, decimal price, int manufacturerId, int categoryId):base(id)
        {
            this.Name = name;
            this.Price = price;
            this.ManufacturerId = manufacturerId;
            this.CategoryId = categoryId;
        }
        public override string ToString()
        {
            return $"Id:{Id} Name:{Name} Price:{Price} ManufacturerId:{ManufacturerId} CategoryId:{CategoryId}";
        }
    }
}
