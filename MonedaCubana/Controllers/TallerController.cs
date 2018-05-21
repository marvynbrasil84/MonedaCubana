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
        private List<String> periodos;
        // GET: Taller
        public ActionResult Index()
        {
            return View(ctrTaller.ListaTaller());
        }

        //GET: Trabajador/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Taller taller = ctrTaller.ObtenerTaller_Nombre(id);
            if (taller == null)
            {
                return HttpNotFound();
            }

            //todo: Cambiar para evitar llamada innecesaria a la BD
            ViewBag.Periodos = ctrPlan.Nombre_Curso_Entrenamiento();
            ViewBag.Taller = taller;
            
            return View();
        }

        [WebMethod]
        public ActionResult Obtener_Plan_Entrenamiento()
        {
            return Json(new { data = ctrPlan.Lista_Programa_Entranamiento() });
        }

        [WebMethod]
        public JsonResult Planes_Entrenamiento()
        {
            periodos = ctrPlan.Nombre_Curso_Entrenamiento();
            return Json (new { data = periodos });
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
        public JsonResult Eliminar(int ID)
        {
            bool resultado = ctrTaller.Eliminar(ID);
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
