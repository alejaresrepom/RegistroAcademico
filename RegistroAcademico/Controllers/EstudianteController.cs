using RegistroAcademico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistroAcademico.Controllers
{
      public class EstudianteController : Controller
    {

        public static Datos.RegistroAcademicoContext contexto = new Datos.RegistroAcademicoContext(); 
       

        public ActionResult Index()
        {
            List<Estudiante> estudiantes = contexto.Estudiantes.OrderBy(e => e.IdEstudiante).Select(e => new Estudiante()
             {
                 IdEstudiante = e.IdEstudiante,
                 PrimerApellido = e.PrimerApellido,
                 SegundoApellido = e.SegundoApellido,
                 PrimerNombre = e.PrimerNombre,
                 SegundoNombre = e.SegundoNombre,
                 NumeroDocumento = e.NumeroDocumento,
                 TipoDocumento = new TipoDocumento() { Nombre = e.TipoDocumento.Nombre },
                 Ciudad = new Ciudad() { Nombre = e.Ciudad.Nombre },
                 Departamento = new Departamento() { Nombre = e.Departamento.Nombre },
                 Telefono = e.Telefono,
                 Direccion = e.Direccion,
                 CorreoElectronico = e.CorreoElectronico,

             }).ToList();

            return View(estudiantes);
        }

     
        public ActionResult Details(int id)
        {
            return View();
        }
      
        //
        // GET: /Estudiante/

       
        //
        // GET: /Estudiante/Details/5
      

        //
        // GET: /Estudiante/Crear

        public ActionResult Crear()

        {
            Estudiante estudiante = new Estudiante();

            var tiposDocumento = contexto.TiposDocumento.OrderBy(t => t.Nombre).Select(t => new TipoDocumento()
            {
                IdTipoDocumento = t.IdTipoDocumento,
                Nombre = t.Nombre
            }).ToList();
            

            ViewBag.TiposDocumento =
                tiposDocumento.Select(x => new SelectListItem
                {
                    Text = x.Nombre,
                    Value = x.IdTipoDocumento.ToString()
                });
            

            var ciudades = contexto.Ciudades.OrderBy(c => c.Nombre).Select(c => new Ciudad()
            {
                IdCiudad = c.IdCiudad,
                Nombre = c.Nombre
            }).ToList();
       
           

            ViewBag.Ciudades =
                ciudades.Select(x => new SelectListItem
                {
                    Text = x.Nombre,
                    Value = x.IdCiudad.ToString()
                });



            var departamentos = contexto.Departamentos.OrderBy(d => d.Nombre).Select(d => new Departamento()
            {
                IdDepartamento = d.IdDepartamento,
                Nombre = d.Nombre
            }).ToList();
          
            ViewBag.Departamentos =
                departamentos.Select(x => new SelectListItem
                {
                    Text = x.Nombre,
                    Value = x.IdDepartamento.ToString()
                });

            return View(estudiante);

        }

        [HttpPost]
        public JsonResult CrearAJAX(Estudiante estudiante)
        {
            try
            {
                contexto.Estudiantes.Add(new Datos.Estudiante() { IdTipoDocumento= estudiante.TipoDocumento.IdTipoDocumento, IdCiudad= estudiante.Ciudad.IdCiudad, IdDepartamento= estudiante.Departamento.IdDepartamento,
                PrimerNombre = estudiante.PrimerNombre, SegundoNombre = estudiante.SegundoNombre, NumeroDocumento = estudiante.NumeroDocumento, PrimerApellido =
                estudiante.PrimerApellido, SegundoApellido = estudiante.SegundoApellido, CorreoElectronico = estudiante.CorreoElectronico, FechaNacimiento = estudiante.FechaNacimiento.Value, Direccion = estudiante.Direccion, Telefono = estudiante.Telefono,
                });
                contexto.SaveChanges();
                var json = Json(new { mensaje = "" });
                return json;               
            }
            catch (Exception ex)
            {
                return Json(new { mensaje = ex.Message });
            }
        }

        [HttpPost]
        public ActionResult Crear(Estudiante estudiante)
        {
            
                contexto.Estudiantes.Add(new Datos.Estudiante()
                {
                    IdTipoDocumento = estudiante.TipoDocumento.IdTipoDocumento,
                    IdCiudad = estudiante.Ciudad.IdCiudad,
                    IdDepartamento = estudiante.Departamento.IdDepartamento,
                    PrimerNombre = estudiante.PrimerNombre,
                    SegundoNombre = estudiante.SegundoNombre,
                    NumeroDocumento = estudiante.NumeroDocumento,
                    PrimerApellido =
                    estudiante.PrimerApellido,
                    SegundoApellido = estudiante.SegundoApellido,
                    CorreoElectronico = estudiante.CorreoElectronico,
                    FechaNacimiento = estudiante.FechaNacimiento.Value,
                    Direccion = estudiante.Direccion,
                    Telefono = estudiante.Telefono,
                });

                contexto.SaveChanges();

                var tiposDocumento = contexto.TiposDocumento.OrderBy(t => t.Nombre).Select(t => new TipoDocumento()
                {
                    IdTipoDocumento = t.IdTipoDocumento,
                    Nombre = t.Nombre
                }).ToList();


                ViewBag.TiposDocumento =
                    tiposDocumento.Select(x => new SelectListItem
                    {
                        Text = x.Nombre,
                        Value = x.IdTipoDocumento.ToString()
                    });


                var ciudades = contexto.Ciudades.OrderBy(c => c.Nombre).Select(c => new Ciudad()
                {
                    IdCiudad = c.IdCiudad,
                    Nombre = c.Nombre
                }).ToList();



                ViewBag.Ciudades =
                    ciudades.Select(x => new SelectListItem
                    {
                        Text = x.Nombre,
                        Value = x.IdCiudad.ToString()
                    });



                var departamentos = contexto.Departamentos.OrderBy(d => d.Nombre).Select(d => new Departamento()
                {
                    IdDepartamento = d.IdDepartamento,
                    Nombre = d.Nombre
                }).ToList();

                ViewBag.Departamentos =
                    departamentos.Select(x => new SelectListItem
                    {
                        Text = x.Nombre,
                        Value = x.IdDepartamento.ToString()
                    });

                return View(estudiante);
        }

        //
        // GET: /Estudiante/Edit/5
          
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Estudiante/Edit/5
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
        // GET: /Estudiante/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Estudiante/Delete/5
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
