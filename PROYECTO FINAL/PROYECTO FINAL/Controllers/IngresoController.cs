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
    public class IngresoController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: /Ingreso/
        public ActionResult Index()
        {
            return View(db.ingresoes.ToList());
        }

        // GET: /Ingreso/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ingreso ingreso = db.ingresoes.Find(id);
            if (ingreso == null)
            {
                return HttpNotFound();
            }
            return View(ingreso);
        }

        // GET: /Ingreso/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Ingreso/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="idingreso,idproveedor,tipo_comprobante,serie_comprobante,num_comprobante,fecha_hora,impuesto,estado,detalle_Ingreso,valor_ingreso")] ingreso ingreso)
        {
            if (ModelState.IsValid)
            {
                db.ingresoes.Add(ingreso);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ingreso);
        }

        // GET: /Ingreso/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ingreso ingreso = db.ingresoes.Find(id);
            if (ingreso == null)
            {
                return HttpNotFound();
            }
            return View(ingreso);
        }

        // POST: /Ingreso/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="idingreso,idproveedor,tipo_comprobante,serie_comprobante,num_comprobante,fecha_hora,impuesto,estado,detalle_Ingreso,valor_ingreso")] ingreso ingreso)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ingreso).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ingreso);
        }

        // GET: /Ingreso/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ingreso ingreso = db.ingresoes.Find(id);
            if (ingreso == null)
            {
                return HttpNotFound();
            }
            return View(ingreso);
        }

        // POST: /Ingreso/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ingreso ingreso = db.ingresoes.Find(id);
            db.ingresoes.Remove(ingreso);
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
