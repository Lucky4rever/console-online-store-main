using System;
using System.Collections.Generic;


namespace StoreBLL.Models
{
    public class ProductModel : AbstractModel
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int ManufacturerId { get; set; }
        public int TitleId { get; set; }

        public ProductModel(int id, string description, decimal price, int manufacturerId, int titleId):base(id)
        {
            this.Description = description;
            this.Price = price;
            this.ManufacturerId = manufacturerId;
            this.TitleId = TitleId;
        }
        public override string ToString()
        {
            return $"Id:{Id} Description:{Description} Price:{Price} ManufacturerId:{ManufacturerId} TitleId:{TitleId}";
        }
    }
}
