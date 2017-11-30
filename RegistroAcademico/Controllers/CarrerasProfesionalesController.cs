using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistroAcademico.Controllers
{
    public class CarrerasProfesionalesController : Controller
    {
        //
        // GET: /CarrerasProfesionales/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /CarrerasProfesionales/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /CarrerasProfesionales/Create
        public ActionResult CrearCarrerasProfesionales()
        {
            return View();
        }

        //
        // POST: /CarrerasProfesionales/Create
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
        // GET: /CarrerasProfesionales/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /CarrerasProfesionales/Edit/5
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
        // GET: /CarrerasProfesionales/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /CarrerasProfesionales/Delete/5
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
