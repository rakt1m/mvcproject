using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mvcproject.BLL.Contracts;
using mvcproject.DAL.Contracts;

namespace mvcproject.BLL.Manager
{
    public class Manager<T> : IManager<T> where T : class
    {
        private readonly IRepository<T> _repository;

        public Manager(IRepository<T> repository)
        {
            _repository = repository;
        }
        public virtual bool Add(T entity)
        {
            return _repository.Add(entity);
        }

        public virtual ICollection<T> GetAll()
        {
            return _repository.GetAll();
        }

        public T GetById(long? id)
        {
            return _repository.GetById(id);
        }

        public virtual bool Remove(T entity)
        {
            return _repository.Remove(entity);
        }

        public virtual bool Update(T entity)
        {
            return _repository.Update(entity);
        }
    }
}
