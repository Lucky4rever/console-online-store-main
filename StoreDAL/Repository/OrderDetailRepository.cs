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
    public class OrderDetailRepository : AbstractRepository, IOrderDetailRepository
    {
        private readonly DbSet<OrderDetail> dbSet;
        public OrderDetailRepository(StoreDbContext context) : base(context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(null);
            }
            dbSet = context.Set<OrderDetail>();
        }
        public void Add(OrderDetail entity)
        {
            dbSet.Add(entity);
            context.SaveChanges();
        }

        public void Delete(OrderDetail entity)
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

        public IEnumerable<OrderDetail> GetAll()
        {
            return dbSet.ToList();
        }

        public IEnumerable<OrderDetail> GetAll(int pageNumber, int RowCount)
        {
            return dbSet.Skip((pageNumber - 1) * RowCount).Take(RowCount).ToList();
        }

        public OrderDetail GetById(int id)
        {
            var x = dbSet.Find(id);
            if (x == null)
            {
                throw new ArgumentNullException(null);
            }
            return x;
        }

        public void Update(OrderDetail entity)
        {
            dbSet.Update(entity);
            context.SaveChanges();
        }
    }
}
