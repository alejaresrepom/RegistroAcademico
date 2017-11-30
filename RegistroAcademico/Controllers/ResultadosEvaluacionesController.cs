using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistroAcademico.Controllers
{
    public class ResultadosEvaluacionesController : Controller
    {
        //
        // GET: /ResultadosEvaluaciones/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /ResultadosEvaluaciones/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /ResultadosEvaluaciones/Create
        public ActionResult CrearResultadosEvaluaciones()
        {
            return View();
        }

        //
        // POST: /ResultadosEvaluaciones/Create
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

        //
        // GET: /ResultadosEvaluaciones/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /ResultadosEvaluaciones/Edit/5
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

        //
        // GET: /ResultadosEvaluaciones/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /ResultadosEvaluaciones/Delete/5
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
