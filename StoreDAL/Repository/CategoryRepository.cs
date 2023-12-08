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
    public class CategoryRepository : AbstractRepository, ICategoryRepository
    {
        private readonly DbSet<Category> dbSet;
        public CategoryRepository(StoreDbContext context) : base(context)
        {
            dbSet = context.Set<Category>();
        }
        public void Add(Category entity)
        {
            dbSet.Categories.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Category entity)
        {
            dbSet.Categories.Remove(entity);
            context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            dbSet.Categories.Remove(GetById(id));
            context.SaveChanges();
        }

        public IEnumerable<Category> GetAll()
        {
            return dbSet.Categories.ToList();
        }

        public IEnumerable<Category> GetAll(int pageNumber, int rowCount)
        {
            return dbSet.Categories.Skip((pageNumber - 1) * rowCount).Take(rowCount).ToList();
        }

        public Category GetById(int id)
        {
            return dbSet.Categories.Find(id);
        }

        public void Update(Category entity)
        {
            dbSet.Categories.Update(entity);
            context.SaveChanges();
        }
    }
}
