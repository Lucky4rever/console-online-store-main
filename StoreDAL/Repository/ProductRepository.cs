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
    public class ProductRepository : AbstractRepository, IProductRepository
    {
        private readonly DbSet<Product> dbSet;
        public ProductRepository(StoreDbContext context) : base(context)
        {
            dbSet = context.Set<Product>();
        }
        public void Add(Product entity)
        {
            dbSet.Products.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Product entity)
        {
            dbSet.Products.Remove(entity);
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

        public IEnumerable<Product> GetAll()
        {
            return dbSet.Products.ToList();
        }

        public IEnumerable<Product> GetAll(int pageNumber, int rowCount)
        {
            return dbSet.Products.Skip((pageNumber - 1) * rowCount).Take(rowCount).ToList();
        }

        public Product GetById(int id)
        {
            return dbSet.Products.Find(id);
        }

        public void Update(Product entity)
        {
            dbSet.Products.Update(entity);
            context.SaveChanges();
        }
    }
}