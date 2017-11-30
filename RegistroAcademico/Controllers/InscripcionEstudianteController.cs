using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistroAcademico.Controllers
{
    public class InscripcionEstudianteController : Controller
    {
        //
        // GET: /InscripcionEstudiante/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /InscripcionEstudiante/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /InscripcionEstudiante/Create
        public ActionResult CrearInscripcionEstudiante()
        {
            return View();
        }

        //
        // POST: /InscripcionEstudiante/Create
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
        // GET: /InscripcionEstudiante/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /InscripcionEstudiante/Edit/5
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
        // GET: /InscripcionEstudiante/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /InscripcionEstudiante/Delete/5
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
