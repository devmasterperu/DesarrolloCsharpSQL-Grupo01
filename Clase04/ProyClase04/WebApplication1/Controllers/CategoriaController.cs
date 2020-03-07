using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.BEAN;
using WebApplication1.Models.DAO;

namespace WebApplication1.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categoria
        public ActionResult ListaCategoria()
        {
            CategoriaDAO catDAO = new CategoriaDAO();
            List<CategoriaBEAN> lista = new List<CategoriaBEAN>();
            lista = catDAO.listaCategorias();
            return View(lista);
        }
    }
}