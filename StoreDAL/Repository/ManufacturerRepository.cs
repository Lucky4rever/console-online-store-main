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
    public class ManufacturerRepository : AbstractRepository, IManufacturerRepository
    {
        private readonly DbSet<Manufacturer> dbSet;
        public ManufacturerRepository(StoreDbContext context) : base(context)
        {
            dbSet = context.Set<Manufacturer>();
        }
        public void Add(Manufacturer entity)
        {
            dbSet.Manufacturers.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Manufacturer entity)
        {
            dbSet.Manufacturers.Remove(entity);
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
            return dbSet.Manufacturers.ToList();
        }

        public IEnumerable<Manufacturer> GetAll(int pageNumber, int rowCount)
        {
            return dbSet.Manufacturers.Skip((pageNumber - 1) * rowCount).Take(rowCount).ToList();
        }

        public Manufacturer GetById(int id)
        {
            return dbSet.Manufacturers.Find(id);
        }

        public void Update(Manufacturer entity)
        {
            dbSet.Manufacturers.Update(entity);
            context.SaveChanges();
        }
    }
}
