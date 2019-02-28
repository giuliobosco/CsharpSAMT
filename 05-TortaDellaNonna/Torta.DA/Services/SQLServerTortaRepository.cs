using System;
using System.Collections.Generic;
using System.Text;

namespace Torta.DA.Services {
    public class SQLServerTortaRepository : ITortaRepository {
        private AppDbContext ctx;

        public SQLServerTortaRepository() {
            ctx = new AppDbContext();
        }

        public Models.Torta Get(int id) {
            throw new NotImplementedException();
        }

        public IEnumerable<Models.Torta> Get() {
            return ctx.Torte;
        }

        public Models.Torta Insert(Models.Torta entity) {
            throw new NotImplementedException();
        }

        public void Delete(Models.Torta entity) {
            throw new NotImplementedException();
        }

        public void Update(Models.Torta entity) {
            throw new NotImplementedException();
        }
    }
}
