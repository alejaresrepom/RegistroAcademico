using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistroAcademico.Datos
{
    public class Estudiante
    {
        [Key]
        public long IdEstudiante { get; set; }
       
        public string NumeroDocumento { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public virtual Departamento Departamento { get; set; }
        public virtual Ciudad Ciudad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string CorreoElectronico { get; set; }
        public int IdTipoDocumento { get; set; }
        public int IdCiudad { get; set; }
        public int IdDepartamento { get; set; }

        public virtual TipoDocumento TipoDocumento { get; set; }
       
    }
}