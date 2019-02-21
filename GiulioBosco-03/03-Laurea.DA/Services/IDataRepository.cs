using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Laurea.DA.Services {
    interface IDataRepository<T> {
        T Get(int index);

        IEnumerable<T> Get();

        void Insert(T element);

        void Delete(T element);

        void Update(T element);

    }
}
