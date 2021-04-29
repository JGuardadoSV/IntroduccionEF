using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion_EF
{
    // Entity Framework Code First / Model First / Database First

    [Table("Alumnos")]
    public class Alumno
    {
        public int AlumnoId { get; set; } //Primary Key y propiedad Identity
        [MinLength(3), MaxLength(25,ErrorMessage ="Máximo 25 caracteres")]
        [Column("Nombre_Alumno")]
        public string Nombre { get; set; }

        //Relacion 1 a muchos   /  Propiedad de navegacion
        public virtual Carrera Carrera { get; set; }
    }

    public class Carrera
    {
        [Key]
        public int IdCarrera { get; set; }
        [MinLength(3), MaxLength(25)] //Entitity Framework Data Annotations
        public string Nombre { get; set; }

    }

}
