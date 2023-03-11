using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            Persona p1 = new Persona("Fer");
            p1.fijarEdad(20);

            Console.WriteLine("La edad del pibe es: " + p1.darEdad());

            Botella b1 = new Botella("Roja", "Plastico");
          

          
        }
    }
}