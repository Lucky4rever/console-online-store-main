using StoreBLL.Interfaces;
using StoreBLL.Models;
using StoreDAL.Data;
using StoreDAL.Entities;
using StoreDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBLL.Services
{
    public class ProductService : AbstractService, ICrud
    {
        private readonly IProductServiceRepository repository;
        public ProductService(StoreDbContext context) : base(context)
        {
            this.repository = new ProductServiceRepository(context);
        }

        public void Add(AbstractModel model)
        {
            var x = (ProductModel)model;
            repository.Add(new Product(x.Id, x.Name, x.Price, x.ManufacturerId, x.CategoryId));
        }
        public void Delete(int modelId)
        {
            repository.DeleteById(modelId);
        }
        public IEnumerable<AbstractModel> GetAll()
        {
            return repository.GetAll().Select(x => new ProductModel(x.Id, x.Name, x.Price, x.ManufacturerId, x.CategoryId));
        }
        public AbstractModel GetById(int id)
        {
            var res = repository.GetById(id);
            return new ProductModel(res.Id, res.Name, res.Price, res.ManufacturerId, res.CategoryId);
        }
        public void Update(AbstractModel model)
        {
            var x = (ProductModel)model;
            repository.Update(new Product(x.Id, x.Name, x.Price, x.ManufacturerId, x.CategoryId));
        }
    }
}
