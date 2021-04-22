using System.Collections.Generic;

namespace SchoolEMS.Models.Repositories
{
    public interface IGenericRepository<T> where T:class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        T Add(T entity);
        void Update(T entity);
        void Delete(int id);
        void Save();
        void GetProxyCreationEnabled();
    }
}
