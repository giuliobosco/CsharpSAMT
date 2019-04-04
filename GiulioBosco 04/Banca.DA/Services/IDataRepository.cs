using System;
using System.Collections.Generic;
using System.Text;

namespace Banca.DA.Services {
    public interface IDataRepository<T> {
        T Get(int id);
        IEnumerable<T> Get();
        void Delete(T entity);
        T Insert(T entity);
        void Update(T entity);
    }
}
