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
    }
}