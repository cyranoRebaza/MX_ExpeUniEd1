using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T05_metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creo una variable persona de tipo Persona
            Persona persona1 = new Persona("Pepe");

            // invoco al metodo saludar()
            string saludo = persona1.Saludar();

            // muestro saludo
            Console.WriteLine(saludo);

            Console.ReadKey();

        }
    }
}
