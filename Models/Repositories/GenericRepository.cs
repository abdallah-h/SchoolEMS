using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SchoolEMS.Models.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AdminDashEntities _context = null;
        private DbSet<T> table = null;
        public GenericRepository()
        {
            _context = new AdminDashEntities();
            table = _context.Set<T>();
        }
        public GenericRepository(AdminDashEntities context)
        {
            _context = context;
            table = _context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return table.ToList();

        }
        public T GetById(int id)
        {
            return table.Find(id);
        }
        public T Add(T entity)
        {
            return table.Add(entity);
        }
        public void Update(T entity)
        {
            table.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            T oldData = table.Find(id);
            table.Remove(oldData);
        }
        public void Save()
        {
            _context.SaveChanges();
        }

        public void GetProxyCreationEnabled()
        {
            _context.Configuration.ProxyCreationEnabled = false;
        }
    }
}