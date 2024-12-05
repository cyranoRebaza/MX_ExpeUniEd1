using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T05_metodos
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

        // metodos Saludar();
        public string Saludar()
        {
            return $"mi nombre es: {nombre}";
        }

    }
}
