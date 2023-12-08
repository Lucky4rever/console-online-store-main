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
    public class ManufacturerService : AbstractService, ICrud
    {
        private readonly IManufacturerRepository _manufacturerRepository;
        public ManufacturerService(StoreDbContext context)
        {
            this.repository = new ManufacturerRepository(context);
        }
        public void Add(AbstractModel model)
        {
            var x = (ManufacturerModel)model;
            repository.Add(new Manufacturer(x.Id, x.Name));
        }
        public void Delete(int modelId)
        {
            repository.DeleteById(modelId);
        }
        public IEnumerable<AbstractModel> GetAll()
        {
            return repository.GetAll().Select(x => new ManufacturerModel(x.Id, x.Name));
        }
        public AbstractModel GetById(int id)
        {
            var res = repository.GetById(id);
            return new ManufacturerModel(res.Id, res.Name);
        }
        public void Update(AbstractModel model)
        {
            var x = (ManufacturerModel)model;
            repository.Update(new Manufacturer(x.Id, x.Name));
        }
    }
}
