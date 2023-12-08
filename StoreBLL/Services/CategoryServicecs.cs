using StoreBLL.Interfaces;
using StoreBLL.Models;
using StoreDAL.Data;
using StoreDAL.Entities;
using StoreDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBLL.Services
{
    public class CategoryService : AbstractService, ICrud
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(StoreDbContext context)
        { 
        
        }
        public void Add(AbstractModel model)
        {
            var x = (CategoryModel)model;
            repository.Add(new Category(x.Id, x.Name));
        }
        public void Delete(int modelId)
        {
            repository.DeleteById(modelId);
        }
        public IEnumerable<AbstractModel> GetAll()
        {
            return repository.GetAll().Select(x => new CategoryModel(x.Id, x.Name));
        }
        public AbstractModel GetById(int id)
        {
            var res = repository.GetById(id);
            return new CategoryModel(res.Id, res.Name);
        }
        public void Update(AbstractModel model)
        {
            var x = (CategoryModel)model;
            repository.Update(new Category(x.Id, x.Name));
        }
    }
}
