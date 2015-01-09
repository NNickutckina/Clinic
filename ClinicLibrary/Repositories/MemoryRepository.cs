using System;
using System.Collections.Generic;
using System.Linq;
using ClinicLibrary.DomainModel;
using ClinicLibrary.Context;
using System.Data.Entity;

namespace ClinicLibrary.Repositories
{
    public class MemoryRepository<T> : IRepository<T> where T : Entity
    {
        private ClinicContext _context;

        public MemoryRepository(ClinicContext context)
        {
            _context = context;
        }

        public DbSet<T> Values
        {
            get { return _context.Set<T>(); }
        }

        public T Get(Guid id)
        {
            return Values.Find(id);
        }

        public void Add(T entity)
        {
            Values.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            Values.Remove(entity);
            _context.SaveChanges();
        }

        public IQueryable<T> AsQueryable()
        {
            return Values.AsQueryable();
        }
    }
}
