using System;
using Microsoft.EntityFrameworkCore;
using _05_TortaDellaNonna.DA.Models;

namespace _05_TortaDellaNonna.DA {
    public class AppDbContext : DbContext {

        public DbSet<Torta> Torte { get; set; }

        public AppDbContext() {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\mssqllocaldb;" +
                "DataBase=TortaNonna;" + 
                "AttachDbFilename=/Users/Shared/TortaNonna.mdf;" +
                "Trusted_Connection=true"
                );
        }
    }
}
