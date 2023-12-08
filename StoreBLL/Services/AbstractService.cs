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
    public abstract class AbstractService
    {
        protected readonly IOrderStateRepository repository;
        protected OrderStateService(StoreDbContext context)
        {
            repository = new OrderStateRepository(context);
        }
    }
}
