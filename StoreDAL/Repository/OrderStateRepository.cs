using Microsoft.EntityFrameworkCore;
using StoreDAL.Data;
using StoreDAL.Entities;
using StoreDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDAL.Repository
{
    public class OrderStateRepository : AbstractRepository, IOrderStateRepository
    {
        private readonly DbSet<OrderState> dbSet;
        public OrderStateRepository(StoreDbContext context) : base(context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(null);
            }
            dbSet = context.Set<OrderState>();
        }
        public void Add(OrderState entity)
        {
            dbSet.Add(entity);
            context.SaveChanges();
        }

        public void Delete(OrderState entity)
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

        public IEnumerable<OrderState> GetAll()
        {
            return dbSet.ToList();
        }

        public IEnumerable<OrderState> GetAll(int pageNumber, int RowCount)
        {
            return dbSet.Skip((pageNumber - 1) * RowCount).Take(RowCount).ToList();
        }

        public OrderState GetById(int id)
        {
            var x = dbSet.Find(id);
            if (x == null)
            {
                throw new ArgumentNullException(null);
            }
            return x;
        }

        public void Update(OrderState entity)
        {
            dbSet.Update(entity);
            context.SaveChanges();
        }
    }
}
