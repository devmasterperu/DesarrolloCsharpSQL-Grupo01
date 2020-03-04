using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [Table("tbContacto")]
    public class Contacto
    {
        [Key]
        [Column(Order = 1)]
        public int IdPersona { get; set; }
        [Key]
        [Column(Order = 2)]
        public int IdCliente { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaRegistro2 { get; set; }

        public List<Persona> Persona { get; set; }
        public List<Cliente> Cliente { get; set; }
    }
}
