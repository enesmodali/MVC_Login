namespace MVC_Login.Migrations
{
    using MVC_Login.Models.Data.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC_Login.Models.Data.Context.ProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MVC_Login.Models.Data.Context.ProjectContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            ApplicationUser kullanici = new ApplicationUser();
            kullanici.Email = "ba@ba.com";
            kullanici.Name = "Bilge Adam";
            kullanici.Password = "123";

            context.Users.AddOrUpdate(kullanici);


        }
    }
}
