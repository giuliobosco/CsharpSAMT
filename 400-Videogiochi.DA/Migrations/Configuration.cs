using _400_Videogiochi.DA.Model;

namespace _400_Videogiochi.DA.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<_400_Videogiochi.DA.VideoGiochiContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(_400_Videogiochi.DA.VideoGiochiContext context)
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

            context.VideoGiochi.AddOrUpdate(
                m => m.Nome,
                new VideoGioco() {Nome = "CounterStrike"},
                new VideoGioco() {Nome = "Fortnite"}
                );
        }
    }
}
