using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MonedaCubana.Services;

namespace MonedaCubana.Controllers
{
    public class ProfesorAsignaturaController : Controller
    {
        private LogicaNegocioProfesorAsignatura ctr = new LogicaNegocioProfesorAsignatura();
        private LogicaNegocioPersonal ctrPersonal = new LogicaNegocioPersonal();
        private LogicaNegocioTaller ctrTaller = new LogicaNegocioTaller();
        private LogicaNegocioPlanEntrenamiento ctrCurso = new LogicaNegocioPlanEntrenamiento();
        // GET: General
        public ActionResult Index()
        {
            ViewBag.Talleres = ctrTaller.ListaTaller();
            ViewBag.Cursos = ctrCurso.Nombre_Curso_Entrenamiento();
            return View(ctrPersonal.ObtenerProfesores());
        }
    }
}