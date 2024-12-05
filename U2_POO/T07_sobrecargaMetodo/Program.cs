using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T07_sobrecargaMetodo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creo variable de tipo persona con el constructor sobrecargado
            Persona persona1 = new Persona("Cyrano");

            // saludo a  todos --> invoco el metodo Saludar();
            Console.WriteLine(persona1.Saludar());

            // saludo al profesor --> invoco el metodo Saludar sobrecargado
            Console.WriteLine(persona1.Saludar("Maxi"));
        }
    }
}
