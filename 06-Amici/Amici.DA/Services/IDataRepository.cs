using System;
using System.Collections.Generic;
using System.Text;

namespace Amici.DA.Services {
    public interface IDataRepository<T> {
        T Get(int id);

        IEnumerable<T> Get();

        void Insert(T element);

        void Delete(T element);

        void Update(T element);
    }
}
