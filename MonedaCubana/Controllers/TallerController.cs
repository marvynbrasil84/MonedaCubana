using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MonedaCubana.Services;
using System.Web.Services;
using MonedaCubana.Models;
namespace MonedaCubana.Controllers
{
    public class TallerController : Controller
    {
        private LogicaNegocioTaller ctrTaller = new LogicaNegocioTaller();
        private LogicaNegocioPlanEntrenamiento ctrPlan = new LogicaNegocioPlanEntrenamiento(); 
        // GET: Taller
        public ActionResult Index()
        {
            return View(ctrTaller.ListaTaller());
        }

        [WebMethod]
        public ActionResult Obtener_Plan_Entrenamiento()
        {
            return Json(new { data = ctrPlan.Lista_Programa_Entranamiento() });
        }

        [WebMethod]
        public JsonResult Planes_Entrenamiento()
        {
            List<String> resultado = ctrPlan.Nombre_Curso_Entrenamiento();
            return Json (new { data = resultado });
        }
        // GET: Taller/Create
        public ActionResult Create()
        {
            return View();
        }

        [WebMethod]
        public JsonResult Adicionar([Bind(Include = "Nombre,Periodo")] Taller taller)
        {
            bool resultado = ctrTaller.Adicionar(taller);
            return Json(new { data = resultado });
        }

        [WebMethod]
        public JsonResult Eliminar(String nombre)
        {
            bool resultado = ctrTaller.Eliminar(nombre);
            return Json(new { data = resultado });
        }

        [WebMethod]
        public JsonResult Modificar([Bind(Include = "Nombre,Periodo")] Taller taller)
        {
            bool resultado = ctrTaller.Modificar(taller);
            return Json(new { data = resultado });
        }
    }
}
