using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T09_herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creo un objeto/variable de tipo Persona
            Persona persona1 = new Persona();

            // creo un objeto/variable de tipo Developer que hereda atributos de Persona
            Developer developer1 = new Developer();
        }
    }
}
