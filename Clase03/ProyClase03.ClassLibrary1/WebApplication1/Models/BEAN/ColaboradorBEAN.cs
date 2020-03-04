using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.BEAN
{
    public class ColaboradorBEAN
    {
        public int IdColaborador { get; set; }
        public string NombreColaborador { get; set; }
        public string ApellidoColaborador { get; set; }
        public string NumDocColaborador { get; set; }
        public string NombreRol { get; set; }
        public string NombreTipoDoc { get; set; }
    }
}