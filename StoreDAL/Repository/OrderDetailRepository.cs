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
    public class OrderDetailRepository : AbstractRepository, IOrderDetailRepository
    {
        private readonly DbSet<OrderDetail> dbSet;
        public OrderDetailRepository(StoreDbContext context) : base(context)
        {
            dbSet = context.Set<OrderDetail>();
        }
        public void Add(OrderDetail entity)
        {
            dbSet.OrderDetails.Add(entity);
            context.SaveChanges();
        }

        public void Delete(OrderDetail entity)
        {
            dbSet.OrderDetails.Remove(entity);
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
            return dbSet.OrderDetails.ToList();
        }

        public IEnumerable<OrderDetail> GetAll(int pageNumber, int rowCount)
        {
            return dbSet.OrderDetails.Skip((pageNumber - 1) * rowCount).Take(rowCount).ToList();
        }

        public OrderDetail GetById(int id)
        {
            return dbSet.OrderDetails.Find(id);
        }

        public void Update(OrderDetail entity)
        {
            dbSet.OrderDetails.Update(entity);
            context.SaveChanges();
        }
    }
}
