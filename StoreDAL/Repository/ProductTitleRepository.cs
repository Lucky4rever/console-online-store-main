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
    public class ProductTitleRepository : AbstractRepository, IProductTitleRepository
    {
        private readonly DbSet<ProductTitle> dbSet;
        public ProductTitleRepository(StoreDbContext context) : base(context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(null);
            }
            dbSet = context.Set<ProductTitle>();
        }
        public void Add(ProductTitle entity)
        {
            dbSet.Add(entity);
            context.SaveChanges();
        }

        public void Delete(ProductTitle entity)
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

        public IEnumerable<ProductTitle> GetAll()
        {
            return dbSet.ToList();
        }

        public IEnumerable<ProductTitle> GetAll(int pageNumber, int RowCount)
        {
            return dbSet.Skip((pageNumber - 1) * RowCount).Take(RowCount).ToList();
        }

        public ProductTitle GetById(int id)
        {
            var x = dbSet.Find(id);
            if (x == null)
            {
                throw new ArgumentNullException(null);
            }
            return x;
        }

        public void Update(ProductTitle entity)
        {
            dbSet.Update(entity);
            context.SaveChanges();
        }
    }
}
