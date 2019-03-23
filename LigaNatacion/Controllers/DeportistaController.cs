using LigaNatacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LigaNatacion.Controllers
{
    public class DeportistaController : Controller
    {
        

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Crear()
        {
            var tiposDocumento = new List<SelectListItem>();
            tiposDocumento.Add(new SelectListItem(){
                Text  = "Cédula de Ciudadanía",
                Value = "1"
            });
            tiposDocumento.Add(new SelectListItem(){
                Text  = "Tarjeta de Identidad",
                Value = "2"
            });
            ViewBag.TiposDocumento = tiposDocumento;

            return View(new Deportista());
        }

        [HttpPost]
        public ActionResult Crear(Deportista deportista)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Actualizar(Deportista deportista)
        {
            return View();
        }
    }
}
