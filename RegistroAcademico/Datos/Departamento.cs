using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RegistroAcademico.Datos
{
    [Table("Departamentos")]
    public class Departamento
    {

        public Departamento()
        {
            this.Estudiantes = new HashSet<Estudiante>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdDepartamento { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Estudiante> Estudiantes { get; set; }
    }
}