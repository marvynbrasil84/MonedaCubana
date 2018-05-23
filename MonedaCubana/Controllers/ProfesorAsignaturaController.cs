using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;
using MonedaCubana.Services;
using MonedaCubana.Models;
using System.Web.Services;

namespace MonedaCubana.Controllers
{
    public class ProfesorAsignaturaController : Controller
    {
        private LogicaNegocioProfesorAsignatura ctr = new LogicaNegocioProfesorAsignatura();
        private LogicaNegocioPersonal ctrPersonal = new LogicaNegocioPersonal();
        private LogicaNegocioTaller ctrTaller = new LogicaNegocioTaller();
        //private LogicaNegocioPlanEntrenamiento ctrCurso = new LogicaNegocioPlanEntrenamiento();
        // GET: General
        public ActionResult Index()
        {
            ViewBag.Talleres = ctrTaller.ListaTaller();
            //ViewBag.Cursos = ctrCurso.Nombre_Curso_Entrenamiento();
            return View(ctrPersonal.ObtenerProfesores());
        }
        [WebMethod]
        public ActionResult Asignar(/*long CI, int TallerID*/[Bind(Include = "CI,TallerID")] Asignatura_Profesor asignacion, string accion)
        {
            ctr.Asignar_Profesor_Asignatura(asignacion, accion);
            return View();
        }

        [WebMethod]
        public ActionResult TalleresporProfesor(long CI)
        {
           // var lista = new List<Taller>();
            var result = ctr.TalleresporProfesor(CI);
            return PartialView("Taller", result);
        }

        public ActionResult Taller()
        {
            return View();
        }
        //[WebMethod]
        //public JsonResult TalleresporProfesor()
        //{
        //    var lista = ctrTaller.ListaTaller();


        //    return Json(lista);
        //}

    }
}