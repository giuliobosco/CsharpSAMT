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
            return ctx.Coffees.FirstOrDefault(c => c.CoffeeId == id);
            // return ctx.Coffees.Where(c => c.CoffeeId == id).FirstOrDefault();
        }

        public IEnumerable<Coffee> Get() {
            return ctx.Coffees;
        }

        public void Delete(Coffee entity) {
            ctx.Coffees.Remove(entity);
        }

        public Coffee Insert(Coffee entity) {
            int newId = ctx.Coffees.Max(c => c.CoffeeId) + 1;
            entity.CoffeeId = newId;
            ctx.Coffees.Add(entity);

            return entity;
        }

        public void Update(Coffee entity) {
            Coffee c = Get(entity.CoffeeId);

            c = entity;
        }
    }
}
