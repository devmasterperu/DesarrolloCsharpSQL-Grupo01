using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyClase01.Consola
{
    public class Persona
    {
        //string nombre;
        //int edad;

        //public Persona() //Constructor sin carga de información
        //{
        //}

        //public Persona(string nombre, int edad)//constructor sobre cargado
        //{
        //    this.nombre = nombre;
        //    this.edad = edad;
        //}

        //public void imprimirDatos()
        //{
        //    Console.WriteLine(nombre + " " + edad);
        //}
        /*private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        */

        /*metodos abreviados prop y propfull
         * atributo; son las variables para acceder a las propiedades
         * propiedad; son loss atributos de la clase, es decir los estados
         * */
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona()
        {

        }
        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
    }
}
