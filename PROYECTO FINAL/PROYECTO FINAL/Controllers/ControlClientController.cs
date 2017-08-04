using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PROYECTO_FINAL.Models;
namespace PROYECTO_FINAL.Controllers
{
    public class ControlClientController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        //
        // GET: /ControlClient/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Vista()
        {
            return View();
        }

        public JsonResult ArticleList(string id = "")
        {
            db.Configuration.LazyLoadingEnabled = false;
            db.Configuration.ProxyCreationEnabled = false;

            var res = db.articuloes.Where(a => a.nombre.Contains(id)).Take(999999);
            return Json(res, JsonRequestBehavior.AllowGet);
        }

	}
}

