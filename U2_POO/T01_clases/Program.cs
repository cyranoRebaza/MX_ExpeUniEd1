using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01_clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n**** PERSONA ****\n");
            
            // creo una variable persona1 de tipo persona con el objeto Persona(constructor)
            Persona persona1 = new Persona();

            // setear los datos de la clase Persona 
            persona1.SetEdad(20);
            persona1.SetSueldo(1000);
            persona1.SetNombre("Juan");

            // obtener y mostrar el valor de los atributos de la clase Persona
            Console.WriteLine($"Nombre: {persona1.GetNombre()}");
            Console.WriteLine($"Edad: {persona1.GetEdad()}");
            Console.WriteLine($"Sueldo: {persona1.GetSueldo()}");

           

            Console.ReadKey();

        }
    }
}
