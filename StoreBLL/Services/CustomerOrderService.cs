﻿using StoreBLL.Interfaces;
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
    public class CustomerOrderService : AbstractService, ICrud
    {
        public CustomerOrderService(StoreDbContext context)
        { 
        }
        public void Add(AbstractModel model)
        {
            var x = (CustomerOrderModel)model;
            repository.Add(new CustomerOrder(x.Id, x.OrderDate, x.CustomerId, x.OrderStateId));
        }
        public void Delete(int modelId)
        {
            repository.DeleteById(modelId);
        }
        public IEnumerable<AbstractModel> GetAll()
        {
            return repository.GetAll().Select(x => new CustomerOrderModel(x.Id, x.OrderDate, x.CustomerId, x.OrderStateId));
        }
        public AbstractModel GetById(int id)
        {
            var res = repository.GetById(id);
            return new CustomerOrderModel(res.Id, res.OrderDate, res.CustomerId, res.OrderStateId);
        }
        public void Update(AbstractModel model)
        {
            var x = (CustomerOrderModel)model;
            repository.Update(new CustomerOrder(x.Id, x.OrderDate, x.CustomerId, x.OrderStateId));
        }
    }
}