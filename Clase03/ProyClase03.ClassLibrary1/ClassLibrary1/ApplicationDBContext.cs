using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext() : base("connBD")
        {

        }
        //Dbcontext sirve para configurar algunas de las caracteristicas que tendrá la BD

        public DbSet<Persona> Persona { get; set; }
        public DbSet<TipoDocumento> TipoDocumento { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Contacto> Contacto { get; set; }
    }
}
