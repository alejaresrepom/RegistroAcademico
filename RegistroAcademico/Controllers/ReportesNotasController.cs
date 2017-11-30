using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistroAcademico.Controllers
{
    public class ReportesNotasController : Controller
    {
        //
        // GET: /ReportesNotas/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /ReportesNotas/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /ReportesNotas/Create
        public ActionResult CrearReportesNotas()
        {
            return View();
        }

        //
        // POST: /ReportesNotas/Create
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
        // GET: /ReportesNotas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /ReportesNotas/Edit/5
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
        // GET: /ReportesNotas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /ReportesNotas/Delete/5
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
