using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePrueba
{
    public class Alumno
    {
        public String Nombre { get; set;}
        public String Apellido { get; set; }
        public int MyProperty { get; set; }
        public Alumno(){

        }
        public Alumno(String nombre, String apellido) {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }
    }   
}
