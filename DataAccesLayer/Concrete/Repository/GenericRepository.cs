using DataAccesLayer.Abstract;
using DataAccesLayer.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class, new()
    {
        AgricultureContext context = new AgricultureContext();
        DbSet<T> _object;

        public GenericRepository()
        {
            _object = context.Set<T>();
        }

        public void Add(T t)
        {
            _object.Add(t);
            context.SaveChanges();
        }

        public void Delete(T t)
        {
            _object.Remove(t);
            context.SaveChanges();
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public List<T> GetListAll()
        {
            return _object.ToList();
        }

        public void Update(T t)
        {
            _object.Update(t);
            context.SaveChanges();
        }
    }
}
