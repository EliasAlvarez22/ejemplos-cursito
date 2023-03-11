using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForm
{
    class Persona
    {
        private int edad;
        private float sueldo;
        private string nombre;

        public Persona(string nombre) 
        {
            this.nombre = nombre;
        }    
        public void fijarEdad(int e)
        {
            edad = e;
        }
        
        public int darEdad()
        {
            return edad;
        }

        public string Saludar()
        {
            return "Hola soy " + nombre;
        }
    }


}
