using MonedaCubana.Models;
using MonedaCubana.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;

namespace MonedaCubana.Controllers
{
    public class AlumnoTallerController : Controller
    {

        private LogicaNegocioAlumnoAsignatura ctr = new LogicaNegocioAlumnoAsignatura();
        private LogicaNegocioPersonal ctrPersonal = new LogicaNegocioPersonal();
        private LogicaNegocioGrupo ctrGrupo = new LogicaNegocioGrupo();
        // GET: AlumnoTaller


        public ActionResult Index()
        {
            ViewBag.NombreGrupo = ctrGrupo.ObtenerNombreGrupos();
            //ViewBag.Cursos = ctrCurso.Nombre_Curso_Entrenamiento();
            return View(ctrPersonal.obtenerAlumnos());
        }
        [WebMethod]
        public ActionResult Asignar([Bind(Include = "CI,TallerID")] Asignatura_Alumno asignacion, string accion)
        {
            ctr.Asignar_Alumno_Asignatura(asignacion, accion);
            return View();
        }

        [WebMethod]
        public ActionResult TalleresporAlumno(long CI)
        {
            // var lista = new List<Taller>();
            var result = ctr.TalleresporAlumno(CI);
            return PartialView("Taller", result);
        }

        public ActionResult Taller()
        {
            return View();
        }
    }
}