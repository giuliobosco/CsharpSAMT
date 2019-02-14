using _03_Laurea.DA.Model;

namespace _03_Laurea.DA {
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class LaureaContext : DbContext {
        // Your context has been configured to use a 'LaureaContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // '_03_Laurea.DA.LaureaContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'LaureaContext' 
        // connection string in the application configuration file.
        public LaureaContext()
            : base("name=LaureaContext") {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Tesi> Tesi { get; set; }
        public virtual DbSet<Area> Aree { get; set; }
        public virtual DbSet<Formatore> Formatori { get; set; }
        public virtual DbSet<Tipo> Tipi { get; set; }
        public virtual DbSet<Studente> Studenti { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}