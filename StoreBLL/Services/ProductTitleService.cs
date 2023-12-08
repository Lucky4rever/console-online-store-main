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
    public class ProductTitleService : AbstractService, ICrud
    {
        private readonly IProductTitleRepository repository;
        public ProductTitleService(StoreDbContext context) : base(context)
        {
            this.repository = new ProductTitleRepository(context);
        }

        public void Add(AbstractModel model)
        {
            var x = (ProductTitleModel)model;
            repository.Add(new ProductTitle(x.Id, x.Title, x.Description, x.Price, x.Image));
        }
        public void Delete(int modelId)
        {
           repository.DeleteById(modelId);
        }
        public IEnumerable<AbstractModel> GetAll()
        {
            return repository.GetAll().Select(x => new ProductTitleModel(x.Id, x.Title, x.Description, x.Price, x.Image));
        }
        public AbstractModel GetById(int id)
        {
            var res = repository.GetById(id);
            return new ProductTitleModel(res.Id, res.Title, res.Description, res.Price, res.Image);
        }
        public void Update(AbstractModel model)
        {
            var x = (ProductTitleModel)model;
            repository.Update(new ProductTitle(x.Id, x.Title, x.Description, x.Price, x.Image));
        }
    }
}
