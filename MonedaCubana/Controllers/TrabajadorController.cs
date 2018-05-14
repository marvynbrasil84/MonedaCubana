using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MonedaCubana.Models;
using System.Web.Services;
using MonedaCubana.Services;
using System.Web.Helpers;
using Newtonsoft.Json;

namespace MonedaCubana.Controllers
{
    public class TrabajadorController : Controller
    {
        //private ApplicationDBContext db = new ApplicationDBContext();
        private LogicaNegocioPersonal ctr = new LogicaNegocioPersonal();
        // GET: Trabajador
        public ActionResult Index()
        {
            //var trabajador = db.Trabajador.Include(t => t.Persona);
            //return View(trabajador.ToList());
            return View(ctr.ObtenerTrabajadores());
        }

       /* [WebMethod]
        //[System.Web.Script.Services.ScriptMethod(ResponseFormat = System.Web.Script.Services.ResponseFormat.Json)]
        public List<Trabajador> Planes_Entrenamiento()
        {
            return 
        }*/

        // GET: Trabajador/Details/5
        //public ActionResult Details(long? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Trabajador trabajador = db.Trabajador.Find(id);
        //    if (trabajador == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(trabajador);
        //}

        // GET: Trabajador/Create
        public ActionResult Create()
        {
            //ViewBag.CI_Trabajado = new SelectList(db.Persona, "CI", "Militancia");
            return View();
        }

        // POST: Trabajador/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [WebMethod]
        //[ValidateAntiForgeryToken]
        public JsonResult Adicionar(/*String CI, String Nombre, String Sexo, String Nivel_Escolar,
            String Fecha_Nacimiento,String Telefono,String Lugar_Nacimiento,String Nacionalidad,
            String Militancia,String Direccion,String Correo,String Ocupacion,String Salario*/
            [Bind(Include = "CI,Ocupacion,Salario")] Trabajador trabajador,
            [Bind(Include = "CI,Militancia,Raza,Sexo,Nivel_Escolar,Fecha_Nacimiento,Direccion,Telefono,Correo,Lugar_Nacimiento,Nacionalidad,Nombre")] Persona persona) 

        {
            if (ModelState.IsValid)
            {
                bool resultado = ctr.AdicionarTrabajador(persona, trabajador);
                return Json(new { data = resultado });
            }
            return Json(new { data = false });
        }

        [WebMethod]
        [ValidateAntiForgeryToken]
        public JsonResult Modificar([Bind(Include = "CI,Ocupacion,Salario")] Trabajador trabajador,
            [Bind(Include = "CI,Militancia,Raza,Sexo,Nivel_Escolar,Fecha_Nacimiento,Direccion,Telefono,Correo,Lugar_Nacimiento,Nacionalidad,Nombre")] Persona persona)

        {
            if (ModelState.IsValid)
            {
                bool resultado = ctr.ModificarTrabajador(persona, trabajador);
                return Json(new { data = resultado }); 
            }
            return Json(new { data = false });
        }

        [WebMethod]
        //[ValidateAntiForgeryToken]
        public JsonResult Eliminar(int CI)

        {
           bool resultado = ctr.EliminarTrabajador(CI);
           return Json(new { data = resultado });
            
        }

        // GET: Trabajador/Edit/5
        //public ActionResult Edit(long? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Trabajador trabajador = db.Trabajador.Find(id);
        //    if (trabajador == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    ViewBag.CI_Trabajado = new SelectList(db.Persona, "CI", "Militancia", trabajador.CI);
        //    return View(trabajador);
        //}

        //// POST: Trabajador/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "CI_Trabajado,Ocupacion,Salario")] Trabajador trabajador)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(trabajador).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    ViewBag.CI_Trabajado = new SelectList(db.Persona, "CI", "Militancia", trabajador.CI);
        //    return View(trabajador);
        //}

        //// GET: Trabajador/Delete/5
        //public ActionResult Delete(long? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Trabajador trabajador = db.Trabajador.Find(id);
        //    if (trabajador == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(trabajador);
        //}

        //// POST: Trabajador/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(long id)
        //{
        //    Trabajador trabajador = db.Trabajador.Find(id);
        //    db.Trabajador.Remove(trabajador);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
