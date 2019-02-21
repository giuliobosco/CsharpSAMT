using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_Laurea.DA.Model;

namespace _03_Laurea.DA.Services {
    public class AreaRepository : IDataRepository<Area> {
        private LaureaContext ctx;

        public AreaRepository() {
            ctx = new LaureaContext();
        }
        public void Delete(Area element) {
            ctx.Entry(element).State = System.Data.Entity.EntityState.Deleted;
            ctx.SaveChanges();
        }

        public Area Get(int index) {
            return ctx.Aree.FirstOrDefault(a => a.Id == index);
        }

        public IEnumerable<Area> Get() {
            return ctx.Aree;
        }

        public void Insert(Area element) {
            ctx.Entry(element).State = System.Data.Entity.EntityState.Added;
            ctx.SaveChanges();
        }

        public void Update(Area element) {
            ctx.Entry(element).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();
        }
    }
}
