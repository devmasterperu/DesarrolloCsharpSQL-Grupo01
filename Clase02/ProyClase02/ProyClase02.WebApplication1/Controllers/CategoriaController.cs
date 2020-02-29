using ProyClase02.WebApplication1.Models.Conection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyClase02.WebApplication1.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categoria
        public ActionResult Index()
        {
            try
            {
                //ConectionBD db = new ConectionBD();
                List<tb_Categoria> listaCategoria;
                using (var db = new ConectionBD())
                {
                    listaCategoria = db.tb_Categoria.ToList();
                    return View(listaCategoria);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        public ActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Agregar(tb_Categoria cat)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            try
            {
                using (var db = new ConectionBD())
                {
                    db.tb_Categoria.Add(cat);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error", ex.Message);
                //throw;
                return View();
            }

        }
        public ActionResult Editar(int id)
        {
            try
            {
                using (var db = new ConectionBD())
                {
                    //tb_Categoria cat = db.tb_Categoria.Find(id);
                    tb_Categoria cat = db.tb_Categoria
                        .Where(x => x.idCategoria == id)// && x.nombreCategoria=="")
                        .FirstOrDefault();
                    return View(cat);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpPost]
        public ActionResult Editar(tb_Categoria p_cat)
        {
            try
            {
                using (var db = new ConectionBD())
                {
                    tb_Categoria cat = db.tb_Categoria.Find(p_cat.idCategoria);
                    cat.nombreCategoria = p_cat.nombreCategoria;

                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}