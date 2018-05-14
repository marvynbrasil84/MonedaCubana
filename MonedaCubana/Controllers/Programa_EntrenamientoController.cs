using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MonedaCubana.Services;
using MonedaCubana.Models;
using System.Web.Helpers;
using System.Web.Services;

namespace MonedaCubana.Controllers
{
    public class Programa_EntrenamientoController : Controller
    {
        private LogicaNegocioPlanEntrenamiento Prog_Ent = new LogicaNegocioPlanEntrenamiento();
        // GET: Programa_Entrenamiento
        public ActionResult Index()
        {
            return View(Prog_Ent.Lista_Programa_Entranamiento());
        }

        [WebMethod]
        public JsonResult Adicionar(Programa_Entrenamiento prog)
        {
            if(ModelState.IsValid)
            {
                bool resultado = Prog_Ent.Adicionar(prog);
                return Json(new { data = resultado });
            }

            return Json(new { data = false });
        }

        [WebMethod]
        public JsonResult Modificar(Programa_Entrenamiento prog)
        {
            if (ModelState.IsValid)
            {
                bool resultado = Prog_Ent.Modificar(prog);
                return Json(new { data = resultado });
            }

            return Json(new { data = false });
        }

        [WebMethod]
        public JsonResult Eliminar(String periodo)
        {
            bool resultado = Prog_Ent.Eliminar(periodo);
            return Json(new { data = resultado });
        }
        // GET: Programa_Entrenamiento/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Programa_Entrenamiento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Programa_Entrenamiento/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Programa_Entrenamiento/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Programa_Entrenamiento/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Programa_Entrenamiento/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Programa_Entrenamiento/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}
