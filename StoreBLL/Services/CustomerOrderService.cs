using StoreBLL.Interfaces;
using StoreBLL.Models;
using StoreDAL.Data;
using StoreDAL.Entities;
using StoreDAL.Interfaces;
using StoreDAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBLL.Services
{
    public class CustomerOrderService : ICrud
    {
        private readonly ICustomerOrderRepository _customerOrderRepository;
        public CustomerOrderService(StoreDbContext context)
        {
            this._customerOrderRepository = new CustomerOrderRepository(context);
        }
        public void Add(AbstractModel model)
        {
            var x = (CustomerOrderModel)model;
            _customerOrderRepository.Add(new CustomerOrder(x.Id, x.OrderDate, x.CustomerId, x.OrderStateId));
        }
        public void Delete(int modelId)
        {
            _customerOrderRepository.DeleteById(modelId);
        }
        public IEnumerable<AbstractModel> GetAll()
        {
            return _customerOrderRepository.GetAll().Select(x => new CustomerOrderModel(x.Id, x.OrderDate, x.CustomerId, x.OrderStateId));
        }
        public AbstractModel GetById(int id)
        {
            var res = _customerOrderRepository.GetById(id);
            return new CustomerOrderModel(res.Id, res.OrderDate, res.CustomerId, res.OrderStateId);
        }
        public void Update(AbstractModel model)
        {
            var x = (CustomerOrderModel)model;
            _customerOrderRepository.Update(new CustomerOrder(x.Id, x.OrderDate, x.CustomerId, x.OrderStateId));
        }
    }
}
