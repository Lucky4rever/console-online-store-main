using StoreDAL.Entities;
using StoreDAL.Interfaces;
using StoreBLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreBLL.Models;
using StoreDAL.Data;

namespace StoreBLL.Services
{
    public class UserService : AbstractService, ICrud
    {
        public UserService(StoreDbContext context) : base(context)
        {
        }
        public void Add(AbstractModel model)
        {
            var x = (UserModel)model;
            repository.Add(new User
            {
                Id = x.Id,
                Name = x.Name,
                Surname = x.Surname,
                Email = x.Email,
                Password = x.Password,
                RoleId = x.RoleId
            });
        }
        public void Delete(int modelId)
        {
            repository.DeleteById(modelId);
        }
        public IEnumerable<AbstractModel> GetAll()
        {
            return repository.GetAll().Select(x=>new UserRoleModel(x.Id,x.RoleName));
        }
        public AbstractModel GetById(int id)
        {
            var res = repository.GetById(id);
            return new UserModel
            {
                Id = res.Id,
                Name = res.Name,
                Surname = res.Surname,
                Email = res.Email,
                Password = res.Password,
                RoleId = res.RoleId
            };
        }
        public void Update(AbstractModel model)
        {
            var x = (UserModel)model;
            repository.Update(new User
            {
                Id = x.Id,
                Name = x.Name,
                Surname = x.Surname,
                Email = x.Email,
                Password = x.Password,
                RoleId = x.RoleId
            });
        }
    }
}
