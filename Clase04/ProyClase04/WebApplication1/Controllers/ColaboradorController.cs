using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.BEAN;
using WebApplication1.Models.DAO;

namespace WebApplication1.Controllers
{
    public class ColaboradorController : Controller
    {
        // GET: Colaborador
        public ActionResult Index()
        {
            ColaboradorDAO colDAO = new ColaboradorDAO();
            List<ColaboradorBEAN> lista = colDAO.listaColaborador();
            return View(lista);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            ColaboradorDAO colDAO = new ColaboradorDAO();
            ColaboradorBEAN coBEAN = colDAO.datosColaborador(id);

            return View(coBEAN);
        }

        [HttpPost]
        public ActionResult Edit(ColaboradorBEAN colBEAN)
        {
            ColaboradorDAO colDAO = new ColaboradorDAO();
            bool respuesta = colDAO.editarColaborador(colBEAN);
            if (respuesta)
            {
                //que me retorne a la vista del listado
                return RedirectToAction("Index");
            }
            else
            {
                //me muestre la ventana de error.
                return View();
            }
        }
        [HttpGet]
        public ActionResult Agregar()
        {
            ColaboradorDAO colDAO = new ColaboradorDAO();
            List<RolBEAN> listaRol = colDAO.listaRoles();
            ViewBag.ListaRol = listaRol;
            return View();
        }
        [HttpPost]
        public ActionResult Agregar(ColaboradorBEAN colBEAN)
        {
            ColaboradorDAO colDAO = new ColaboradorDAO();
            bool rpta = colDAO.agregarColaborador(colBEAN);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            ColaboradorDAO colDAO = new ColaboradorDAO();
            bool rpta = colDAO.deleteColaborador(id);
            return RedirectToAction("Index");
        }
    }
}