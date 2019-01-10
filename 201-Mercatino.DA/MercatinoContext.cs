using _101_Mercatino.Models;

namespace _201_Mercatino {
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MercatinoContext : DbContext {
        // Your context has been configured to use a 'MercatinoContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // '_201_Mercatino.MercatinoContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'MercatinoContext' 
        // connection string in the application configuration file.
        public MercatinoContext()
            : base("name=MercatinoContext") {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public virtual DbSet<Mercatino> Mercatini { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}