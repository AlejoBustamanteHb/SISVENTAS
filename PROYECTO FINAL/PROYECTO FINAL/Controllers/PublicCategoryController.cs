using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PROYECTO_FINAL.Models;

namespace PROYECTO_FINAL.Controllers
{
   // [Authorize]
    public class PublicCategoryController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        //
        // GET: /PublicCategory/
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult CategoryList ( string id = "")
        {
            db.Configuration.LazyLoadingEnabled = false;
            db.Configuration.ProxyCreationEnabled = false;

            var res = db.categorias.Where(a => a.nombre.Contains(id)).Take(78921);
            return Json(res, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Tecnologia()
        {
            return View();
        }
        public ActionResult Aseo()
        {
            return View();
        }
        public ActionResult Belleza()
        {
            return View();
        }
        public ActionResult Insumos()
        {
            return View();
        }
        public ActionResult Alimentos()
        {
            return View();
        }
        public ActionResult Papeleria()
        {
            return View();
        }
        public ActionResult Ropa()
        {
            return View();
        }
        public ActionResult Panaderia()
        {
            return View();
        }
        public ActionResult Instrumentos_Musicales()
        {
            return View();
        }
        public ActionResult Herramientas_Construccion()
        {
            return View();
        }
	}
}