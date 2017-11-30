using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistroAcademico.Models
{
    public class Estudiante
    {
        
        public long IdEstudiante { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public Departamento Departamento { get; set; }
        public Ciudad Ciudad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string CorreoElectronico { get; set; }
    }
}