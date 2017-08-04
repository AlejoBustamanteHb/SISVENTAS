using PROYECTO_FINAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PROYECTO_FINAL.Controllers
{
    [Authorize(Roles = "Administrador")]
    public class AdminController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        //
        // GET: /Admin/
        public ActionResult ListaClientes()
        {
            return View();
        }

        public JsonResult ListPersons()
        {
            return Json(db.personas.ToList(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult ListaProveedores()
        {
            return View();
        }
	}
}