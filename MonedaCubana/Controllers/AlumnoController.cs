using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MonedaCubana.Models;

namespace MonedaCubana.Controllers
{
    public class AlumnoController : Controller
    {
        private ApplicationDBContext db = new ApplicationDBContext();

        // GET: Alumno
        public ActionResult Index()
        {
            var alumno = db.Alumno.Include(a => a.Grupo).Include(a => a.Persona);
            return View(alumno.ToList());
        }

        // GET: Alumno/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alumno alumno = db.Alumno.Find(id);
            if (alumno == null)
            {
                return HttpNotFound();
            }
            return View(alumno);
        }

        // GET: Alumno/Create
        public ActionResult Create()
        {
            ViewBag.Nombre = new SelectList(db.Grupo, "Nombre", "Sesion");
            ViewBag.CI_Alumno = new SelectList(db.Persona, "CI", "Militancia");
            return View();
        }

        // POST: Alumno/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CI,Telefono_Padre,Telefono_Madre,Nombre_Padre,Nombre_Madre,Categoria,Foto,Nombre")] Alumno alumno)
        {
            if (ModelState.IsValid)
            {
                db.Alumno.Add(alumno);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Nombre = new SelectList(db.Grupo, "Nombre", "Sesion", alumno.Nombre);
            ViewBag.CI_Alumno = new SelectList(db.Persona, "CI", "Militancia", alumno.CI);
            return View(alumno);
        }

        // GET: Alumno/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alumno alumno = db.Alumno.Find(id);
            if (alumno == null)
            {
                return HttpNotFound();
            }
            ViewBag.Nombre = new SelectList(db.Grupo, "Nombre", "Sesion", alumno.Nombre);
            ViewBag.CI_Alumno = new SelectList(db.Persona, "CI", "Militancia", alumno.CI);
            return View(alumno);
        }

        // POST: Alumno/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CI_Alumno,Telefono_Padre,Telefono_Madre,Nombre_Padre,Nombre_Madre,Categoria,Foto,Nombre")] Alumno alumno)
        {
            if (ModelState.IsValid)
            {
                db.Entry(alumno).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Nombre = new SelectList(db.Grupo, "Nombre", "Sesion", alumno.Nombre);
            ViewBag.CI_Alumno = new SelectList(db.Persona, "CI", "Militancia", alumno.CI);
            return View(alumno);
        }

        // GET: Alumno/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alumno alumno = db.Alumno.Find(id);
            if (alumno == null)
            {
                return HttpNotFound();
            }
            return View(alumno);
        }

        // POST: Alumno/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Alumno alumno = db.Alumno.Find(id);
            db.Alumno.Remove(alumno);
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
