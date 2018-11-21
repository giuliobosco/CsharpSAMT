using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08_CoffeeShop.DA.Model;

namespace _08_CoffeeShop.DA.Service {
    public class CoffeeDataRepository : IDataRepository<Coffee> {
        private DataContext ctx;

        public CoffeeDataRepository() {
            ctx = new DataContext();
        }

        public Coffee Get(int id) {
            throw new NotImplementedException();
        }

        public IEnumerable<Coffee> Get() {
            return ctx.Coffees;
        }

        public void Delete(Coffee entity) {
            throw new NotImplementedException();
        }

        public Coffee Insert(Coffee entity) {
            throw new NotImplementedException();
        }

        public void Update(Coffee entity) {
            throw new NotImplementedException();
        }
    }
}
