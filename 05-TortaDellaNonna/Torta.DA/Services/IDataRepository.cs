using System;
using System.Collections.Generic;
using System.Text;

namespace Torta.DA.Services {
    public interface IDataRepository<T> {
        T Get(int id);

        IEnumerable<T> Get();

        T Insert(T entity);

        void Delete(T entity);

        void Update(T entity);
    }
}
