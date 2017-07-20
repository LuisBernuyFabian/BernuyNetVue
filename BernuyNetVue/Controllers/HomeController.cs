using BernuyNetVue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BernuyNetVue.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Personas()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetPersonas()
        {
            try
            {
                IEnumerable<Persona> personaLista = new List<Persona>()
                {
                    new Persona { Id = 1, Nombre = "Juan", Dni = "44110022" },
                    new Persona { Id = 2, Nombre = "Ana", Dni = "54993300" },
                    new Persona { Id = 3, Nombre = "Rolando", Dni = "00114477" },
                    new Persona { Id = 4, Nombre = "Maria", Dni = "88441144" },
                };
                return Json(new { Error = false, personaLista = personaLista }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(new { Error = true, Mensaje = "Ocurrió un error: " + e.ToString() }, JsonRequestBehavior.AllowGet);
            }
        }
    }
    
}