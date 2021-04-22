using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion_EF
{
    class Program
    {
        static void Main(string[] args)
        {

            //INSERT

            /** // quitar comentarios para probar esta porcion de codigo
            Alumno alumno = new Alumno();
            alumno.Nombre = "Josue Guardado";
            Console.WriteLine("El ID antes de guardar {0}", alumno.AlumnoId);

            introduccionEF db = new introduccionEF();
            
            // two ways binding

            db.Alumnos.Add(alumno); //Insert

            db.SaveChanges(); //Envia los cambios / consultas

            Console.WriteLine("El ID despues de guardar {0}", alumno.AlumnoId);
            */

            //SELECT
            introduccionEF db = new introduccionEF();
            //LINQ Lenguaje de consulta .net
            //Expresiones Lambdas

            // Un alumno
            Alumno alumno = new Alumno();

            alumno = (
                          from i in db.Alumnos 
                          where i.AlumnoId == 3 
                          select i
                      ).First();

            Console.WriteLine("El nombre del alumno es {0} y id {1}", alumno.Nombre,alumno.AlumnoId);

        }
    }
}
