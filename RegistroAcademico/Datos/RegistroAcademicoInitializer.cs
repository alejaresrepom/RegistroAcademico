using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAcademico.Datos
{
    public class RegistroAcademicoInitializer: DropCreateDatabaseIfModelChanges<RegistroAcademicoContext>
    {
        protected override void Seed(RegistroAcademicoContext context)
        {
            context.TiposDocumento.Add(new TipoDocumento() { Nombre = "Tarjeta de identidad", IdTipoDocumento = 1 });
            context.TiposDocumento.Add(new TipoDocumento() { Nombre = "Cedula de ciudadania", IdTipoDocumento = 2 });
            context.TiposDocumento.Add(new TipoDocumento() { Nombre = "Cedula de extranjeria", IdTipoDocumento = 3 });
            context.Ciudades.Add(new Ciudad() { Nombre = "Leticia", IdCiudad = 1 });
            context.Ciudades.Add(new Ciudad() { Nombre = "Medellin", IdCiudad = 2 });
            context.Ciudades.Add(new Ciudad() { Nombre = "Arauca", IdCiudad = 3 }); 
            context.Departamentos.Add(new Departamento() { Nombre = "Amazonas", IdDepartamento = 1 });
            context.Departamentos.Add(new Departamento() { Nombre = "Antioquia", IdDepartamento = 2 });
            context.Departamentos.Add(new Departamento() { Nombre = "Casanare", IdDepartamento = 3 });
            base.Seed(context);
        }
    }
}