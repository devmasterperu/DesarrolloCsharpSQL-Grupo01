namespace ClassLibrary1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ClassLibrary1.ApplicationDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ClassLibrary1.ApplicationDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            //Recomendación - debería ejecutarse por unica vez.
            context.TipoDocumento.AddOrUpdate(x => x.IdTipoDocumento,//expresión lamda que segun el ID se a colocar un nuevo registro
                new TipoDocumento { NombreDocumento = "DNI"},
                new TipoDocumento { NombreDocumento = "RUC"}
                );
        }
    }
}
