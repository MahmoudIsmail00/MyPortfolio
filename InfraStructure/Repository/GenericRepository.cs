using Core.Intrfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraStructure.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DataContext _context;
        private DbSet<T> table = null;

        public GenericRepository(DataContext context)
        {
            _context = context;
            table = context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(object id)
        {
            return table.Find(id);
        }

        public void Insert(T entity)
        {
            table.Add(entity);
        }

        public void Update(T entity)
        {
            table.Attach(entity); 
            _context.Entry(entity).State = EntityState.Modified;
        }
        public void Delete(object id)
        {
            T exists = table.Find(id);
            table.Remove(exists);
        }
    }
}
