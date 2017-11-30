using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistroAcademico.Controllers
{
    public class ReporteNotasConstanciaController : Controller
    {
        //
        // GET: /ReporteNotasConstancia/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /ReporteNotasConstancia/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /ReporteNotasConstancia/Create
        public ActionResult CrearReporteNotasConstancia()
        {
            return View();
        }

        //
        // POST: /ReporteNotasConstancia/Create
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
        // GET: /ReporteNotasConstancia/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /ReporteNotasConstancia/Edit/5
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
        // GET: /ReporteNotasConstancia/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /ReporteNotasConstancia/Delete/5
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
