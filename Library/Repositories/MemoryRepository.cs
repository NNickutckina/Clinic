using System;
using System.Collections.Generic;
using System.Linq;
using Library.DomainModel;

namespace Library.Repositories
{
    public class MemoryRepository<T> : IRepository<T> where T : Entity
    {
        private Dictionary<Guid, T> _dictionay = new Dictionary<Guid, T>();

        public T Get(Guid id)
        {
            return _dictionay[id];
        }
        
        public void Add(T entity)
        {
            _dictionay.Add(entity.Identifier, entity);
        }

        public void Delete(T entity)
        {
            _dictionay.Remove(entity.Identifier);
        }

        public IQueryable<T> AsQueryable()
        {
            return _dictionay.Values.AsQueryable();
        }
    }
}
