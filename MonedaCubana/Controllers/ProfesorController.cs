using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MonedaCubana.Models;
using System.Web.Services;
using MonedaCubana.Services;
using System.Net;

namespace MonedaCubana.Controllers
{
    public class ProfesorController : Controller
    {
        //private ApplicationDBContext db = new ApplicationDBContext();
        private LogicaNegocioPersonal ctr = new LogicaNegocioPersonal();
        // GET: Profesor
        public ActionResult Index()
        {
            return View(ctr.ObtenerProfesores());
        }

        // GET: Profesor/Create
        public ActionResult Create()
        {

            return View();
        }

        [WebMethod]
        //[ValidateAntiForgeryToken]
        public JsonResult Adicionar([Bind(Include = "CI,Categoria_Docente,Categoria_Cientifica,Salario")] Profesor profesor,
            [Bind(Include = "CI,Militancia,Raza,Sexo,Nivel_Escolar,Fecha_Nacimiento,Direccion,Telefono,Correo,Lugar_Nacimiento,Nacionalidad,Nombre")] Persona persona)

        {
            if (ModelState.IsValid)
            {
                bool resultado = ctr.AdicionarProfesor(persona, profesor);
                return Json(new { data = resultado });
            }
            return Json(new { data = false });
        }

        [WebMethod]
        //[ValidateAntiForgeryToken]
        public JsonResult Modificar([Bind(Include = "CI,Categoria_Docente,Categoria_Cientifica,Salario")] Profesor profesor,
            [Bind(Include = "CI,Militancia,Raza,Sexo,Nivel_Escolar,Fecha_Nacimiento,Direccion,Telefono,Correo,Lugar_Nacimiento,Nacionalidad,Nombre")] Persona persona)

        {
            if (ModelState.IsValid)
            {
                bool resultado = ctr.ModificarProfesor(persona, profesor);
                return Json(new { data = resultado });
            }
            return Json(new { data = false });
        }

        [WebMethod]
        //[ValidateAntiForgeryToken]
        public JsonResult Eliminar(long id)

        {
            if (ModelState.IsValid)
            {
                bool resultado = ctr.EliminarProfesor(id);
                return Json(new { data = resultado });
            }
            return Json(new { data = false });
        }

        //GET: Trabajador/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profesor profesor = ctr.ObtenerProfesor_CI(id);//db.Trabajador.Find(id);
            if (profesor == null)
            {
                return HttpNotFound();
            }
            //ViewBag.CI_Trabajado = new SelectList(db.Persona, "CI", "Militancia", trabajador.CI);
            ViewBag.Profesor = profesor;

            return View();
        }


    }
}