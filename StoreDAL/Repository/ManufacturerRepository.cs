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
    public class ManufacturerRepository : AbstractRepository, IManufacturerRepository
    {
        private readonly DbSet<Manufacturer> dbSet;
        public ManufacturerRepository(StoreDbContext context) : base(context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(null);
            }
            dbSet = context.Set<Manufacturer>();
        }
        public void Add(Manufacturer entity)
        {
            dbSet.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Manufacturer entity)
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

        public IEnumerable<Manufacturer> GetAll()
        {
            return dbSet.ToList();
        }

        public IEnumerable<Manufacturer> GetAll(int pageNumber, int RowCount)
        {
            return dbSet.Skip((pageNumber - 1) * RowCount).Take(RowCount).ToList();
        }

        public Manufacturer GetById(int id)
        {
            var x = dbSet.Find(id);
            if (x == null)
            {
                throw new ArgumentNullException(null);
            }
            return x;
        }

        public void Update(Manufacturer entity)
        {
            dbSet.Update(entity);
            context.SaveChanges();
        }
    }
}
