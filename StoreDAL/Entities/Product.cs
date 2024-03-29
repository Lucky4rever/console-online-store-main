﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDAL.Entities
{
    [Table("products")]
    public class Product:BaseEntity
    {
        [ForeignKey("product_title_id")]
        [Column("product_title_id")]
        public int TitleId { get; set; }
        [ForeignKey("product_manufacturer_id")]
        [Column("manufacturer_id")]
        public int ManufacturerId { get; set; }
        [Column("unit_price")]
        public decimal UnitPrice { get; set; }
        [Column("comment")]
        public string Description { get; set; }
        public ProductTitle Title { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public virtual IList<OrderDetail> OrderDetails { get; }
        public Product() : base()
        {
            this.Title = new();
            this.Manufacturer = new();
            this.OrderDetails = new List<OrderDetail>();
            this.Description = "";
        }
        public Product(int id, int titleId, int manufacturerId, string description, decimal price) : base(id)
        {
            this.Title = new();
            this.Manufacturer = new();
            this.OrderDetails = new List<OrderDetail>();
            this.TitleId = titleId;
            this.ManufacturerId = manufacturerId;
            this.Description = description;
            this.UnitPrice=price;
        }
    }
}
