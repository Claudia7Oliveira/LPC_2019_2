using System.Collections.Generic;

namespace ContasEF.Models
{
    public interface IRepository<T> where T : DefId
    {
        T Get(int id);
        IEnumerable<T> Get();
        void Insert(T obj);
        void Update(T obj);
        void Delete(int id);

    }
}