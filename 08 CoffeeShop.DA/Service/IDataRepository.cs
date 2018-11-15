using _08_CoffeeShop.DA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_CoffeeShop.DA.Service {
    public interface IDataRepository<T> {
        T Get(int id);

        IEnumerable<T> Get();

        void Delete(T entity);

        T Insert(T entity);

        void Update(T entity);
    }
}
