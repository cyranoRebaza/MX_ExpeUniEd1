using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T14_Asociacion
{
    internal class Conductor
    {
        // Atributos privados
        private string nombre;

        // Propiedades publicas
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        // Constructor 
        public Conductor(string nombre)
        {
            this.nombre = nombre;
        }

        // Metodo para mostrar informacion del conductor
        public void MostrarDetalles()
        {
            Console.WriteLine($"Conductor: {Nombre}");
        }
         


        
    }
}
