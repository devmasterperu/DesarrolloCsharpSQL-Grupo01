using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.BEAN;
using WebApplication1.Models.DAO;

namespace WebApplication1.Controllers
{
    public class TipoDocumentoController : Controller
    {
        // GET: TipoDocumento
        public ActionResult Index()
        {
            TipoDocumentoDAO tpDAO = new TipoDocumentoDAO();
            List<TipoDocumentoBEAN> lista = tpDAO.listaTipoDocumentos();

            return View(lista);
        }
    }
}