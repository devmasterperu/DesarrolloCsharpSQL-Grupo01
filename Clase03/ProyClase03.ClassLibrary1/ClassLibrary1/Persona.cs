using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [Table("tbPersona")]
    public class Persona
    {
        [Key]
        public int IdPersona { get; set; }
        [Required] //se especifica que el campo es requerido
        [StringLength(50)] //especifica el tamño del campo
        public string Nombre{ get; set; }
        [Required]
        public string Apellidos { get; set; }
        [StringLength(250)]
        public string Direccion { get; set; }
        public int Edad { get; set; }
        public int IdTipoDocumento { get; set; }


        public TipoDocumento TipoDocumento { get; set; }
        public Contacto Contacto { get; set; }
    }
}
