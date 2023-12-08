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
    public class UserRoleRepository : AbstractRepository, IUserRoleRepository
    {
        private readonly DbSet<UserRole> dbSet;
        public UserRoleRepository(StoreDbContext context) : base(context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(null);
            }
            dbSet = context.Set<UserRole>();
        }
        public void Add(UserRole entity)
        {
            dbSet.Add(entity);
            context.SaveChanges();
        }

        public void Delete(UserRole entity)
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

        public IEnumerable<UserRole> GetAll()
        {
            return dbSet.ToList();
        }

        public IEnumerable<UserRole> GetAll(int pageNumber, int RowCount)
        {
            return dbSet.Skip((pageNumber - 1) * RowCount).Take(RowCount).ToList();
        }

        public UserRole GetById(int id)
        {
            var x = dbSet.Find(id);
            if (x == null)
            {
                throw new ArgumentNullException(null);
            }
            return x;
        }

        public void Update(UserRole entity)
        {
            dbSet.Update(entity);
            context.SaveChanges();
        }
    }
}
