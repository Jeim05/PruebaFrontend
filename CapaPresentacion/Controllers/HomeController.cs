using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapaPresentacion.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Card card = new BLL_Card().ObtenerCards().FirstOrDefault();
            return View(card);
        }

        [HttpGet]
        public JsonResult ObtenerDatos()
        {
            List<Card> list = new List<Card>();
            list = new BLL_Card().ObtenerCards();

            return Json(new {data = list}, JsonRequestBehavior.AllowGet);
        }

    }
}