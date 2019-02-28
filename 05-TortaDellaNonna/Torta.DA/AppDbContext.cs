using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Torta.DA {
    public class AppDbContext : DbContext {
        public DbSet<Models.Torta> Torte { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\mssqllocaldb;"+
                "Database=TortaNonna.3AA;"+
                "AttachDbFilename=C:\\tmp\\TortaNonna.3AA.mdf;"+
                "integrated security=true"
                );
        }

    }
}
