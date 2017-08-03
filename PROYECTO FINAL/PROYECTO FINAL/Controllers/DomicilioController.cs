using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PROYECTO_FINAL.Models;

namespace PROYECTO_FINAL.Controllers
{
     [Authorize(Roles = "Administrador")]
    public class DomicilioController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: /Domicilio/
        public ActionResult Index()
        {
            var domicilios = db.domicilios.Include(d => d.venta);
            return View(domicilios.ToList());
        }

        // GET: /Domicilio/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            domicilio domicilio = db.domicilios.Find(id);
            if (domicilio == null)
            {
                return HttpNotFound();
            }
            return View(domicilio);
        }

        // GET: /Domicilio/Create
        public ActionResult Create()
        {
            ViewBag.idventa = new SelectList(db.ventas, "idventa", "tipo_comprobante");
            return View();
        }

        // POST: /Domicilio/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="id,idventa,idcliente,direccion")] domicilio domicilio)
        {
            if (ModelState.IsValid)
            {
                db.domicilios.Add(domicilio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idventa = new SelectList(db.ventas, "idventa", "tipo_comprobante", domicilio.idventa);
            return View(domicilio);
        }

        // GET: /Domicilio/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            domicilio domicilio = db.domicilios.Find(id);
            if (domicilio == null)
            {
                return HttpNotFound();
            }
            ViewBag.idventa = new SelectList(db.ventas, "idventa", "tipo_comprobante", domicilio.idventa);
            return View(domicilio);
        }

        // POST: /Domicilio/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="id,idventa,idcliente,direccion")] domicilio domicilio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(domicilio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idventa = new SelectList(db.ventas, "idventa", "tipo_comprobante", domicilio.idventa);
            return View(domicilio);
        }

        // GET: /Domicilio/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            domicilio domicilio = db.domicilios.Find(id);
            if (domicilio == null)
            {
                return HttpNotFound();
            }
            return View(domicilio);
        }

        // POST: /Domicilio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            domicilio domicilio = db.domicilios.Find(id);
            db.domicilios.Remove(domicilio);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
