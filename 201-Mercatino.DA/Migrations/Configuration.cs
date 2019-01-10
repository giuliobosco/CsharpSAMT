using _101_Mercatino.Models;

namespace _201_Mercatino.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<_201_Mercatino.MercatinoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(_201_Mercatino.MercatinoContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Mercatini.AddOrUpdate(
                m => m.Luogo, 
                new Mercatino() { Luogo = "Strasburgo", Nazione = "Francia" },
                new Mercatino() { Luogo = "Berlino", Nazione = "Germania" },
                new Mercatino() { Luogo = "Milano", Nazione = "Italia" }
            );
        }
    }
}
