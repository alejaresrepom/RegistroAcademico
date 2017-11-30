using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistroAcademico.Controllers
{
    public class PensumAdministracionServiciosSaludController : Controller
    {
        //
        // GET: /PensumAdministracionServiciosSalud/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /PensumAdministracionServiciosSalud/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /PensumAdministracionServiciosSalud/Create
        public ActionResult CrearPensumAdministracionServiciosSalud()
        {
            return View();
        }

        //
        // POST: /PensumAdministracionServiciosSalud/Create
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
        // GET: /PensumAdministracionServiciosSalud/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /PensumAdministracionServiciosSalud/Edit/5
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
        // GET: /PensumAdministracionServiciosSalud/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /PensumAdministracionServiciosSalud/Delete/5
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
