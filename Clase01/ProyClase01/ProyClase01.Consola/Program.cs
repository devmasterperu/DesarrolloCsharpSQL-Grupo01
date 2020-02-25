using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyClase01.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Array (Mtrices o Arreglos)
      son estructuras que contienn valores del mismo tipo (int, string, double, etc)    */
            // declaración inicial 
            //int[] miMatriz;
            //iniciación
            // miMatriz = new int[4];
            //declarar e inicializar
            //int[] miMatriz2 = new int[4];

            #region Arreglos
            //Agregar información en arreglo
            //Modo 1
            //int[] miMatriz = new int[4];
            //miMatriz[0] = 2;
            //miMatriz[1] = 10;
            //miMatriz[2] = 3;
            //miMatriz[3] = 15;

            ////Modo 2
            //int[] arrayNumeros = { 2, 10, 3, 15 };

            ////Recorrer un arreglo

            //Console.WriteLine("Recorrido con FOR");
            //for (int i = 0; i < arrayNumeros.Length; i++)
            //{
            //    Console.WriteLine(arrayNumeros[i]);
            //}

            //Console.WriteLine("Recorrido con FOREACH");
            //foreach (var item in arrayNumeros)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Arreglos con Clase y manejo de errores
            //try
            //{
            //    Persona Ana = new Persona("Ana", 20);

            //    Persona[] persona = new Persona[2];
            //    persona[0] = new Persona("Hervey", 26);
            //    persona[1] = Ana;
            //    for (int i = 0; i < persona.Length; i++)
            //    {
            //        persona[i].imprimirDatos();
            //        //Console.WriteLine(persona[i]);
            //    }
            //    persona[3].imprimirDatos(); //se fuerza al error

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Se Presentó un error");
            //    //Console.WriteLine(ex);
            //    //throw;
            //}
            #endregion

            #region Listas (Coleccion de datos)
            /*Permiten almacenar elementos genéricos
             * no tiene limitaciones como los Arrays, pero genera mayor consumo de recursos
             * se puede realizar la operaciones de ordenar, buscar, añadir
             */
            //int[] arrayNumeros = { 2, 10, 3, 8, 40 };
            //List<int> listaDatos = new List<int>();

            ////Agregar datos en lista mediante en mpetodo Add
            //for (int i = 0; i < arrayNumeros.Length; i++)
            //{
            //    listaDatos.Add(arrayNumeros[i]);
            //}
            ////Mostrar datos de un List
            //for (int i = 0; i < listaDatos.Count; i++)
            //{
            //    Console.WriteLine(listaDatos[i]);
            //}

            /*Elaborar un programa que ingrese los 
             * valores, si es cero termina su 
             * ejecución y muestre los valores 
             * ingresados*/
            //Console.ReadLine();
            //string campo;
            //List<string> listaDatos = new List<string>();
            //do
            //{
            //    Console.Write("Inrese información: ");
            //    campo = Console.ReadLine();
            //    listaDatos.Add(campo);

            //} while (campo != "0");
            //Console.WriteLine("\nLos datos ingresados son");
            //foreach (var item in listaDatos)
            //{
            //    Console.WriteLine(item);
            //}

            //Lista con Clase

            //Persona objP = new Persona();//uso del constructor sin sobrecarga
            //objP.Nombre = "Karina";
            //objP.Edad = 20;

            //Persona objP2 = new Persona("Manuel", 10);//uso del constructor sobrecargado

            //List<Persona> listarPersona = new List<Persona>();
            //listarPersona.Add(new Persona("Pedro", 18));//uso del constructor sobrecargado
            //listarPersona.Add(new Persona { Nombre = "Mariaela", Edad = 25 });//uso del constructor sin sobrecarga
            //listarPersona.Add(objP);
            //listarPersona.Add(objP2);

            ////Listar los datos del objeto
            //Console.WriteLine("Lista con FOR");
            //for (int i = 0; i < listarPersona.Count; i++)
            //{
            //    Console.WriteLine(listarPersona[i].Nombre + " " + listarPersona[i].Edad);
            //}
            //Console.WriteLine("\nLista con FOREACH");
            //foreach (var item in listarPersona)
            //{
            //    Console.WriteLine(item.Nombre +" " + item.Edad);
            //}
            #endregion

            #region Diccionarios (Colección de datos)
            //Dictionary<int, string> datos = new Dictionary<int, string>();
            //datos.Add(1, "Lunes");
            //datos.Add(2, "Martes");
            //datos.Add(3, "Miercoles");
            //datos.Add(4, "Jueves");
            //datos.Add(5, "Viernes");
            //datos.Add(6, "Sábado");
            //datos.Add(7, "Domingo");

            ////Recorrido de dictionary con FOR            
            //Console.WriteLine("Llenado de datos con FOR");
            //for (int i = 1; i <= datos.Count; i++)
            //{
            //    Console.WriteLine(datos[i]);
            //}
            //Console.WriteLine("\nLlenado de datos con FOREACH");
            //foreach (var item in datos)
            //{
            //    Console.WriteLine(item);
            //}

            //Dictionary<string, string> datos = new Dictionary<string, string>();
            //datos.Add("A", "Lunes");
            //datos.Add("B", "Martes");
            //datos.Add("C", "Miercoles");
            //datos.Add("D", "Jueves");
            //datos.Add("E", "Viernes");
            //datos.Add("F", "Sábado");
            //datos.Add("G", "Domingo");

            //Console.WriteLine(datos["A"]);
            //Console.WriteLine(datos["D"]);
            //Console.WriteLine(datos["G"]);


            /*Elaborar un algoritmo, que al ingresar un valor entre el 1 y 7, 
            muestre en pantalla el día de la semana*/
            //Console.Write("Ingrese valor: ");
            //int valor = Convert.ToInt32(Console.ReadLine());
            ////Convert.Int32 nos transformará ese nulo a 0, evitando la excepción.
            ////int.parse nos devolverá una excepción de que estamos recibiendo un dato nulo.
            //int valor2 = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("El nombre del día es: " + datos[valor]);

            #endregion

            /* EJERCICIO 1
             * Teniendo en cuenta que la hora hombre es de 10 soles y al día se trabaja 8 horas,
             * esto equivale a un costo de 80 S/. x día. Por ello se requiere elaborar un diccionario 
             * con la siguiente información que compete a la hora extra.
             * El cálculo se realizará si excede las 8 horas, caso contrario solo se realizará el 
             * cálculo al costo por hora hombre.
             *      * 1 a 3, precio por hora extra 12
             *      * 4 a 5, precio por hora extra 13
             *      * 6, precio por hora extra 15
             * Se debe ingresar por pantalla la cantidad de horas trabajadas y se deberá mostrar:
             * horas trabajadas normales, costo horas trabajadas normales, horas extras, costo horas extras 
             * y pago total a realizar.
             */
            //Dictionary<int, int> listaCostoExtra = new Dictionary<int, int>();
            //listaCostoExtra.Add(1, 12);
            //listaCostoExtra.Add(2, 12);
            //listaCostoExtra.Add(3, 12);
            //listaCostoExtra.Add(4, 13);
            //listaCostoExtra.Add(5, 13);
            //listaCostoExtra.Add(6, 15);
            //Console.Write("Ingrese horas trabajadas: ");
            //int horas = Convert.ToInt32(Console.ReadLine());
            //int horasExtra = horas - 8;
            //if (horasExtra <= 0)
            //{
            //    Console.WriteLine("Horas Trabajadas: " + horas);
            //    Console.WriteLine("Costo Horas Trabajadas: " + horas * 10 + " S/.");
            //    Console.WriteLine("Horas Extras: 0");
            //    Console.WriteLine("Costo Horas Extras: 0 S/.");
            //    Console.WriteLine("------------------------");
            //    Console.WriteLine("Pago a realizar es de " + (horas * 10) + " S/.");
            //}
            //else
            //{
            //    Console.WriteLine("Horas Trabajadas: " + 8);
            //    int costoHorasT = 8 * 10;
            //    Console.WriteLine("Costo Horas Trabajadas: " + costoHorasT + " S/.");
            //    int costo = listaCostoExtra[horasExtra];
            //    Console.WriteLine("Horas Extras: " + horasExtra);
            //    int costoHorasE = horasExtra * costo;
            //    Console.WriteLine("Costo Horas Extras: " + costoHorasE + " S/.");
            //    Console.WriteLine("------------------------");
            //    Console.WriteLine("Pago a realizar es de " + (costoHorasT + costoHorasE) + " S/.");
            //}

            /*Luego de haber calculado el costo de hora normal y hora extra, se requiere 
             * almacenar datos del trabajador(codigo, nombre, horas de trabajo y pago total a realizar)
             - Crear una lista que pueda almacenar los datos de los trabajadores ingresados 
             por pantalla, excepto pago total a realizar que debe ser calculado
             */
            Dictionary<int, int> listaCostoExtra = new Dictionary<int, int>();
            listaCostoExtra.Add(1, 12);
            listaCostoExtra.Add(2, 12);
            listaCostoExtra.Add(3, 12);
            listaCostoExtra.Add(4, 13);
            listaCostoExtra.Add(5, 13);
            listaCostoExtra.Add(6, 15);
            int numMenu;
            string rpta;
            List<TrabajadorBEAN> listaTrabaj = new List<TrabajadorBEAN>();
            //TrabajadorBEAN trabajador = new TrabajadorBEAN();//Error común al programar, crear siempre todos los objetos al iniciar
            TrabajadorBEAN trabajador;
            do
            {
                Console.Clear();
                Console.WriteLine("Menú Trabajadores");
                Console.WriteLine("1 - Ingresar Datos Trabajadores");
                Console.WriteLine("2 - Listar Datos Trabajadores");
                Console.WriteLine("----------------------------------");
                Console.Write("Ingrese número del menú: ");
                numMenu = Convert.ToInt32(Console.ReadLine());
                switch (numMenu)
                {
                    case 1:
                        trabajador = new TrabajadorBEAN();
                        Console.Write("\nIngrese Código: ");
                        trabajador.Codigo = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingrese Nombre: ");
                        trabajador.Nombre = Console.ReadLine();
                        Console.Write("Ingrese Horas de Trabajo: ");

                        int horas = Convert.ToInt32(Console.ReadLine());
                        trabajador.HorasTrabajo = horas;
                        int horasExtra = horas - 8;
                        if (horasExtra <= 0)
                        {
                            trabajador.PagoTotal = (horas * 10);
                        }
                        else
                        {
                            int costoHorasT = 8 * 10;
                            int costo = listaCostoExtra[horasExtra];
                            int costoHorasE = horasExtra * costo;
                            trabajador.PagoTotal = (costoHorasT + costoHorasE);
                        }

                        listaTrabaj.Add(trabajador);
                        break;
                    case 2:
                        Console.WriteLine("\nLista de trabajadores");
                        Console.WriteLine("--------------------------------");
                        foreach (var item in listaTrabaj)
                        {
                            Console.WriteLine(item.Codigo + "  " + item.Nombre + "  " + item.HorasTrabajo + "  " + item.PagoTotal);
                        }
                        break;
                    default:
                        break;
                }
                Console.Write("\n¿Desea continuar(S/N)?");
                rpta = Console.ReadLine();
            } while (rpta == "S" || rpta == "s");
        }
    }
    class TrabajadorBEAN
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int HorasTrabajo { get; set; }
        public int PagoTotal { get; set; }
    }
}
