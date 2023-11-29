using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntitiyLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        private readonly IServıceDal _serviceDal;

        public ServiceManager(IServıceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void Add(Service t)
        {
            _serviceDal.Add(t);
        }

        public void Delete(Service t)
        {
            _serviceDal.Delete(t);
        }

        public Service GetById(int id)
        {
            return _serviceDal.GetById(id);
        }

        public List<Service> GetListAll()
        {
            return _serviceDal.GetListAll();
        }

        public void Insert(Service t)
        {
            _serviceDal.Add(t);
        }

        public void Update(Service t)
        {
            _serviceDal.Update(t);
        }
    }
}
