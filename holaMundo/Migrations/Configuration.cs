namespace holaMundo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<holaMundo.Models.ConfigContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(holaMundo.Models.ConfigContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Profesion.AddOrUpdate(x => x.id, new Models.Profesion()
            {
                id = 1,
                nombre = "No tengo profesión"
            });

            context.Profesion.AddOrUpdate(x => x.id, new Models.Profesion()
            {
                id = 2,
                nombre = "Ingenieria de sistemas"
            });

            context.Profesion.AddOrUpdate(x => x.id, new Models.Profesion()
            {
                id = 3,
                nombre = "Ingenieria de Hidraulica"
            });

            context.Profesion.AddOrUpdate(x => x.id, new Models.Profesion()
            {
                id = 4,
                nombre = "Ingenieria de minas"
            });

            context.Profesion.AddOrUpdate(x => x.id, new Models.Profesion()
            {
                id = 5,
                nombre = "Ingenieria de software"
            });

            context.User.AddOrUpdate(x => x.id, new Models.User()
            {
                id = 1,
                nombre = "Faby",
                email = "freitte@gmail.com",
                apellido = "ffreite",
                add = DateTime.Now,
                ProfesionFk = 1

            });
        }
    }
}
