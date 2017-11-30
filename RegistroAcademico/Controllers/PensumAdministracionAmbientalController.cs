using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistroAcademico.Controllers
{
    public class PensumAdministracionAmbientalController : Controller
    {
        //
        // GET: /PensumAdministracionAmbiental/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /PensumAdministracionAmbiental/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /PensumAdministracionAmbiental/Create
        public ActionResult CrearPensumAdministracionAmbiental()
        {
            return View();
        }

        //
        // POST: /PensumAdministracionAmbiental/Create
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
        // GET: /PensumAdministracionAmbiental/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /PensumAdministracionAmbiental/Edit/5
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
        // GET: /PensumAdministracionAmbiental/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /PensumAdministracionAmbiental/Delete/5
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
