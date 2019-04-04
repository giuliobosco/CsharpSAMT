using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Banca.DA.Models;

namespace Banca.DA.Services {
    class SQLServerValutaRepository : IValutaRepository {

        private readonly AppDbContext ctx;

        public SQLServerValutaRepository(AppDbContext context) {
            ctx = context;
        }

        public Valuta Get(int id) {
            return ctx.Valute.FirstOrDefault(a => a.Id == id);
        }

        public IEnumerable<Valuta> Get() {
            return ctx.Valute;
        }

        public void Delete(Valuta entity) {
            ctx.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            ctx.SaveChanges();
        }

        public Valuta Insert(Valuta entity) {
            ctx.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            ctx.SaveChanges();
            return entity;
        }

        public void Update(Valuta entity) {
            ctx.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            ctx.SaveChanges();
        }
    }
}
