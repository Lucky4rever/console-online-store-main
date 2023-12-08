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
    public class OrderDetailService : AbstractService, ICrud
    {
        public OrderDetailService(StoreDbContext context)
        {
        }

        public void Add(AbstractModel model)
        {
            var x = (OrderDetailModel)model;
            repository.Add(new OrderDetail(x.Id, x.OrderId, x.ProductId, x.Quantity));
        }
        public void Delete(int modelId)
        {
            repository.DeleteById(modelId);
        }
        public IEnumerable<AbstractModel> GetAll()
        {
            return repository.GetAll().Select(x => new OrderDetailModel(x.Id, x.OrderId, x.ProductId, x.Quantity));
        }
        public AbstractModel GetById(int id)
        {
            var res = repository.GetById(id);
            return new OrderDetailModel(res.Id, res.OrderId, res.ProductId, res.Quantity);
        }
        public void Update(AbstractModel model)
        {
            var x = (OrderDetailModel)model;
            repository.Update(new OrderDetail(x.Id, x.OrderId, x.ProductId, x.Quantity));
        }
    }
}
