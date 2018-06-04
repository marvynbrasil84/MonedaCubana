using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MonedaCubana.Models;
using MonedaCubana.Services;

namespace MonedaCubana.Controllers
{
    public class AlumnoController : Controller
    {
        //private ApplicationDBContext db = new ApplicationDBContext();
        private LogicaNegocioPersonal ctr = new LogicaNegocioPersonal();
        private LogicaNegocioGrupo ctrGrupo = new LogicaNegocioGrupo();
        // GET: Alumno
        public ActionResult Index()
        {
            /*var alumno = db.Alumno.Include(a => a.Grupo).Include(a => a.Persona);
            return View(alumno.ToList());*/
            
            return View(ctr.obtenerAlumnos());
        }

        // GET: Alumno/Details/5
        public ActionResult Details(long? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //Alumno alumno = db.Alumno.Find(id);
            //if (alumno == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(alumno);
            return View();
        }

        // GET: Alumno/Create
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.NombreGrupo = ctrGrupo.ObtenerNombreGrupos();
            //ViewBag.CI = new SelectList(db.Persona, "CI", "Militancia");
            return View();
        }

        // POST: Alumno/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public JsonResult Adicionar([Bind(Include = "CI,Telefono_Padre,Telefono_Madre,Nombre_Padre,Nombre_Madre,Categoria,Foto,NombreGrupo")] Alumno alumno,
            [Bind(Include = "CI,Militancia,Raza,Sexo,Nivel_Escolar,Fecha_Nacimiento,Direccion,Telefono,Correo,Lugar_Nacimiento,Nacionalidad,Nombre," +
                             "Primer_Apellido, Segundo_Apellido,Provincia, Municipio, Fecha_Inicio_Contrato, Fecha_Fin_Contrato, Numero_Contrato")] Persona persona)
        {
            if (ModelState.IsValid)
            {
                if (ctr.Adicionar_Alumno(persona, alumno))
                {
                    return Json (new { data= true }) ;
                }
                else
                {
                    return Json(new { data = false });
                }
            }

            return Json(new { data = false });
        }

        // GET: Alumno/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                Alumno alumno = ctr.Obtener_Alumno(id);

                if(alumno != null)
                {
                    ViewBag.Alumno = alumno;
                }
                
            }
            return View();
        }

        // POST: Alumno/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        
        public ActionResult Modificar([Bind(Include = "CI,Telefono_Padre,Telefono_Madre,Nombre_Padre,Nombre_Madre,Categoria,Foto,NombreGrupo")] Alumno alumno,
                                      [Bind(Include = "CI,Militancia,Raza,Sexo,Nivel_Escolar,Fecha_Nacimiento,Direccion,Telefono,Correo,Lugar_Nacimiento,Nacionalidad,Nombre," +
                                      "Primer_Apellido, Segundo_Apellido,Provincia, Municipio, Fecha_Inicio_Contrato, Fecha_Fin_Contrato, Numero_Contrato")] Persona persona)
        {
            //if (ModelState.IsValid)
            //{
            //    db.Entry(alumno).State = EntityState.Modified;
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}
            //ViewBag.NombreGrupo = new SelectList(db.Grupo, "NombreGrupo", "Sesion", alumno.NombreGrupo);
            //ViewBag.CI = new SelectList(db.Persona, "CI", "Militancia", alumno.CI);
            //return View(alumno);
            return View();
        }

        // GET: Alumno/Delete/5
        public ActionResult Delete(long? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //Alumno alumno = db.Alumno.Find(id);
            //if (alumno == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(alumno);
            return View();
        }

        // POST: Alumno/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            //Alumno alumno = db.Alumno.Find(id);
            //db.Alumno.Remove(alumno);
            //db.SaveChanges();
            return RedirectToAction("Index");
        }

       
    }
}
