using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RegistroAcademico.Datos
{
    [Table("Ciudades")]
    public class Ciudad
    {

        public Ciudad()
        {
            this.Estudiantes = new HashSet<Estudiante>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdCiudad { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Estudiante> Estudiantes { get; set; }
    }
}