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

            Alumno alumno = new Alumno();
            alumno.Nombre = "Josue Guardado";
            Console.WriteLine("El ID antes de guardar {0}", alumno.AlumnoId);

            introduccionEF db = new introduccionEF();
            

            db.Alumnos.Add(alumno); //Insert

            db.SaveChanges(); //Envia los cambios / consultas

            Console.WriteLine("El ID despues de guardar {0}", alumno.AlumnoId);



        }
    }
}
