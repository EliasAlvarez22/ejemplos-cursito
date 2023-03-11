using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForm
{
    internal class Botella
    {
        //ATRIBUTOS
        private int capacidad;
        private string color;
        private string material;
        private int cantidadActual;

        public Botella(string color, string material)
        {
            this.color = color;
            this.material = material;
            capacidad = 100;
            cantidadActual = 0;
        }

        public Botella() 
        {

        }

        public string Material
        { 
            get { return material; } 
        }

        //PROPIEDAD
        // public int Capacidad
        // {
        //    get { return capacidad; }
        //    set { capacidad = value; }
        //}

        //METODO

        public float recargar()
        {
            cantidadActual = 100;
            return 50;
        }
    }   
}
