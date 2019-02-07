using _01_Laurea.DA.Model;

namespace _01_Laurea.DA {
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class LaureeModel : DbContext {
        // Your context has been configured to use a 'LaureeModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // '_01_Laurea.DA.LaureeModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'LaureeModel' 
        // connection string in the application configuration file.
        public LaureeModel()
            : base("name=LaureeModel") {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Area> Aree { get; set; }
        public virtual DbSet<Formatore> Formatori { get; set; }
        public virtual DbSet<Studente> Studenti { get; set; }
        public virtual DbSet<Tesi> Tesi { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}