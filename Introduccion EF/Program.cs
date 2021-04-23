using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion_EF
{
    class Program
    {
        static void Main(string[] args)
        {
            introduccionEF db = new introduccionEF();

            //INSERT
            Carrera carrera = new Carrera();
            //select * from carreras where idcarrera=2
            carrera = db.Carreras.Where(x => x.IdCarrera == 2).First();

            Alumno alumno = new Alumno();
            alumno.Nombre = "Pedro Perez Perez 5";
            alumno.Carrera = carrera; // pasando el valor de la llave foranea 
            db.Alumnos.Add(alumno); //Insert

            // two ways binding

            db.SaveChanges(); //Envia los cambios / consultas

         
            

            //SELECT
            //introduccionEF db = new introduccionEF();
            //LINQ Lenguaje de consulta .net
            //Expresiones Lambdas

            // Un alumno
          //  Alumno alumno = new Alumno();

            /* alumno = (
                           from i in db.Alumnos 
                           where i.AlumnoId == 3
                           select i

                       ).First();*/
            
            //expresion lambdas
           // alumno = db.Alumnos.Where(x => x.AlumnoId == 1).First();
         //   Console.WriteLine("El nombre del alumno es {0} y id {1}", alumno.Nombre, alumno.AlumnoId);
            /*
            
            //UPDATE
            alumno.Nombre = "Maria Hernandez";
            db.Alumnos.AddOrUpdate(alumno);
            db.SaveChanges();

             Console.WriteLine("El nombre del alumno es {0} y id {1}", alumno.Nombre,alumno.AlumnoId);
            */

            //Delete
            /*
            db.Alumnos.Remove(alumno);
            db.SaveChanges();
            */
           

        }
    }
}
