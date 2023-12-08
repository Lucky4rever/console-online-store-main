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
    public class CategoryRepository : AbstractRepository, ICategoryRepository
    {
        private readonly DbSet<Category> dbSet;
        public CategoryRepository(StoreDbContext context) : base(context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(null);
            }
            dbSet = context.Set<Category>();
        }
        public void Add(Category entity)
        {
            dbSet.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Category entity)
        {
            dbSet.Remove(entity);
            context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            dbSet.Remove(GetById(id));
            context.SaveChanges();
        }

        public IEnumerable<Category> GetAll()
        {
            return dbSet.ToList();
        }

        public IEnumerable<Category> GetAll(int pageNumber, int RowCount)
        {
            return dbSet.Skip((pageNumber - 1) * RowCount).Take(RowCount).ToList();
        }

        public Category GetById(int id)
        {
            var x = dbSet.Find(id);
            if (x == null)
            {
                throw new ArgumentNullException(null);
            }
            return x;
        }

        public void Update(Category entity)
        {
            dbSet.Update(entity);
            context.SaveChanges();
        }
    }
}
