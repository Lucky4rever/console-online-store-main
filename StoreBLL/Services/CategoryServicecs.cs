using StoreBLL.Interfaces;
using StoreBLL.Models;
using StoreDAL.Data;
using StoreDAL.Entities;
using StoreDAL.Interfaces;
using StoreDAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBLL.Services
{
    public class CategoryService : ICrud
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(StoreDbContext context)
        {
            this._categoryRepository = new CategoryRepository(context);
        }
        public void Add(AbstractModel model)
        {
            var x = (CategoryModel)model;
            this._categoryRepository.Add(new Category(x.Id, x.Name));
        }
        public void Delete(int modelId)
        {
            this._categoryRepository.DeleteById(modelId);
        }
        public IEnumerable<AbstractModel> GetAll()
        {
            return this._categoryRepository.GetAll().Select(x => new CategoryModel(x.Id, x.Name));
        }
        public AbstractModel GetById(int id)
        {
            var res = this._categoryRepository.GetById(id);
            return new CategoryModel(res.Id, res.Name);
        }
        public void Update(AbstractModel model)
        {
            var x = (CategoryModel)model;
            this._categoryRepository.Update(new Category(x.Id, x.Name));
        }
    }
}
