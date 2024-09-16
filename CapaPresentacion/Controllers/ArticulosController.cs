using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapaPresentacion.Controllers
{
    public class ArticulosController : Controller
    {
        // GET: Articulos
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public JsonResult ObtenerArticulos()
        {
            List<Articulo> list = new List<Articulo>();
            list = new BLL_Articulo().ObtenerArticulos();

            return Json(new { data = list }, JsonRequestBehavior.AllowGet);
        }
    }
}