using StoreDAL.Entities;
using StoreDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreDAL.Data;

namespace StoreDAL.Repository
{
    public class CustomerOrderRepository : AbstractRepository, ICustomerOrderRepository
    {
        private readonly DbSet<CustomerOrder> dbSet;
        public CustomerOrderRepository(StoreDbContext context) : base(context)
        {
            dbSet = context.Set<CustomerOrder>();
        }
        public void Add(CustomerOrder entity)
        {
            dbSet.CustomerOrders.Add(entity);
            context.SaveChanges();
        }

        public void Delete(CustomerOrder entity)
        {
            dbSet.CustomerOrders.Remove(entity);
            context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var entity = dbSet.Find(id);
            if (entity != null)
            {
                dbSet.Remove(entity);
                context.SaveChanges();
            }
        }

        public IEnumerable<CustomerOrder> GetAll()
        {
            return dbSet.CustomerOrders.ToList();
        }

        public IEnumerable<CustomerOrder> GetAll(int pageNumber, int rowCount)
        {
            return dbSet.CustomerOrders.Skip((pageNumber - 1) * rowCount).Take(rowCount).ToList();
        }

        public CustomerOrder GetById(int id)
        {
            return dbSet.CustomerOrders.Find(id);
        }

        public void Update(CustomerOrder entity)
        {
            dbSet.CustomerOrders.Update(entity);
            context.SaveChanges();
        }
    }
}
