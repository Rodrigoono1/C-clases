using ClasePrueba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno personaje = new Alumno();
            personaje.Nombre = "Martin";
            personaje.Apellido = "Guasd";

            Alumno ono = new Alumno { Nombre = "Ono", Apellido = "Rodrigo" };

            Alumno prueba = new Alumno("Jose", "Yegros");

            Console.WriteLine("Fin del programa, Presione cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
