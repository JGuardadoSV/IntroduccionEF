using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion_EF
{
    //Contexto, se debe de llamar igual que la cadena de conexión
    public class introduccionEF:DbContext
    {
        //Todas las entidades que formarán parte de nuestra base de datos

        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Carrera> Carreras { get; set; }


    }
}
