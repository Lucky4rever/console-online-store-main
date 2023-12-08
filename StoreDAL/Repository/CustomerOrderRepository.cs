using StoreDAL.Entities;
using StoreDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreDAL.Data;
using Microsoft.EntityFrameworkCore;

namespace StoreDAL.Repository
{
    public class CustomerOrderRepository : AbstractRepository, ICustomerOrderRepository
    {
        private readonly DbSet<CustomerOrder> dbSet;
        public CustomerOrderRepository(StoreDbContext context) : base(context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(null);
            }
            dbSet = context.Set<CustomerOrder>();
        }
        public void Add(CustomerOrder entity)
        {
            dbSet.Add(entity);
            context.SaveChanges();
        }

        public void Delete(CustomerOrder entity)
        {
            dbSet.Remove(entity);
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
            return dbSet.ToList();
        }

        public IEnumerable<CustomerOrder> GetAll(int pageNumber, int RowCount)
        {
            return dbSet.Skip((pageNumber - 1) * RowCount).Take(RowCount).ToList();
        }

        public CustomerOrder GetById(int id)
        {
            var x = dbSet.Find(id);
            if (x == null)
            {
                throw new ArgumentNullException(null);
            }
            return x;
        }

        public void Update(CustomerOrder entity)
        {
            dbSet.Update(entity);
            context.SaveChanges();
        }
    }
}
