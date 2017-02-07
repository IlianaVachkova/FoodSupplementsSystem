using FoodSupplementsSystem.Data.Models;
using System.Data.Entity.Migrations;

namespace FoodSupplementsSystem.Data.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<FoodSupplementsSystem.Data.FoodSupplementsSystemDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(FoodSupplementsSystem.Data.FoodSupplementsSystemDbContext context)
        {
            var user = new User()
            {
                UserName = "Ana"
            };

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
        }
    }
}