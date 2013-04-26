namespace krabdev.Migrations
{
    using krabdev.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<krabdev.Models.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(krabdev.Models.Context context)
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
            context.FAQs.AddOrUpdate(
                p => p.Question,
                new FAQ { Question = "Question n1", Anwser = "Anwser n1" },
                new FAQ { Question = "Question n2", Anwser = "Anwser n2" },
                new FAQ { Question = "Question n3", Anwser = "Anwser n3" }
            );
        }
    }
}
