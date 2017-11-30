using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistroAcademico.Controllers
{
    public class ConstanciaController : Controller
    {
        //
        // GET: /Constancia/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Constancia/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Constancia/Create
        public ActionResult CrearConstancia()
        {
            return View();
        }

        //
        // POST: /Constancia/Create
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
        // GET: /Constancia/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Constancia/Edit/5
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
        // GET: /Constancia/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Constancia/Delete/5
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
