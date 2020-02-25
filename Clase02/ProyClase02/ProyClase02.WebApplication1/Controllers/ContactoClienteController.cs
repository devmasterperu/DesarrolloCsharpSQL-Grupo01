using ProyClase02.WebApplication1.Models.BEAN;
using ProyClase02.WebApplication1.Models.Conection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyClase02.WebApplication1.Controllers
{
    public class ContactoClienteController : Controller
    {
        // GET: ContactoCliente
        public ActionResult Index()
        {
            try
            {
                using (var db = new ConectionBD())
                {
                    var lista = from cc in db.tb_ContactoCliente
                                join c in db.tb_Colaborador on cc.idColaborador equals c.idColaborador
                                join cl in db.tb_Cliente on cc.idCliente equals cl.idCliente
                                join p in db.tb_Producto on cc.idProducto equals p.idProducto
                                select new ContactoClienteBEAN
                                {
                                    idContactabilidad = cc.idContactabilidad,
                                    idColaborador = cc.idColaborador,
                                    NombreColaborador = c.nombreColaborador + " "+ c.apellidoColaborador,
                                    fechaContactoCliente = cc.fechaContactoCliente,
                                    idCliente = cc.idCliente,
                                    NombreCliente = cl.nombreCliente + " "+ cl.apellidosCliente,
                                    NombreProducto = p.nombreProducto
                                };

                    //List < tb_ContactoCliente > listContac = db.tb_ContactoCliente.ToList();
                    List<ContactoClienteBEAN> listContac = lista.ToList();
                    return View(listContac);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public ActionResult Agregar()
        {
            //Envio de información desde Controller a View
            //Model
            //ViewBag
            //List<tb_Producto> listProd;
            using (var db = new ConectionBD())
            {
                //listProd = db.tb_Producto.ToList();
                //ViewBag.ListaProductos = listProd;

                var items = new List<SelectListItem>();
                items = db.tb_Producto.Select(
                    c => new SelectListItem()
                    {
                        Value = c.idProducto.ToString(),
                        Text = c.nombreProducto
                    }).ToList();
                ViewBag.ListaProductos = items;
            }
            return View();
        }
        [HttpPost]
        public ActionResult Agregar(tb_ContactoCliente cc)
        {
           
            return View();
        }
    }
}