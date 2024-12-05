using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T07_sobrecargaMetodo
{
    internal class Persona
    {
        // atributos
        private string nombre;

        // constructor
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        // metodo saludar()
        public string Saludar()
        {
            return $"hola soy {nombre}";
        }

        // metodo sobrecargado saludar( tipoDato parametro) 
        public string Saludar(string otroNombre)
        {
            return $"hola {otroNombre}, soy {nombre}";
        }
    }
}
