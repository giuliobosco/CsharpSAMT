using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _09_RSI.DA.Model;

namespace _09_RSI.DA.Service {
    public class FilmDataRepository : IDataRepository<Film> {

        private static DataContext ctx;

        public FilmDataRepository() {
            ctx = new DataContext();
        }

        public Film Get(int id) {
            return ctx.Films.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Film> Get() {
            return ctx.Films;
        }

        public void Delete(Film entity) {
            ctx.Films.Remove(entity);
        }

        public Film Insert(Film entity) {
            int newId = ctx.Films.Max(c => c.Id) + 1;
            entity.Id = newId;
            ctx.Films.Add(entity);

            return entity;
        }

        public void Update(Film entity) {
            Film film = Get(entity.Id);

            film = entity;
        }
    }
}
