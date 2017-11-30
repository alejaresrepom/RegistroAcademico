using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistroAcademico.Controllers
{
    public class PensumController : Controller
    {
        //
        // GET: /Pensum/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Pensum/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Pensum/Create
        public ActionResult CrearPensum()
        {
            return View();
        }

        //
        // POST: /Pensum/Create
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
        // GET: /Pensum/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Pensum/Edit/5
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
        // GET: /Pensum/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Pensum/Delete/5
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
