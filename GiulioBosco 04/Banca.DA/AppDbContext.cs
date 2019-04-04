using System;
using System.Collections.Generic;
using System.Text;
using Banca.DA.Models;
using Microsoft.EntityFrameworkCore;

namespace Banca.DA {
    public class AppDbContext : DbContext {
        public DbSet<Valuta> Valute { get; set; }

        public AppDbContext() : base() {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;" +
                                        "Database=Amici.3AA;" +
                                        "AttachDbFilename=c:\\tmp\\amici.3AA.mdf;" +
                                        "Trusted_Connection=true");
        }

    }
}
