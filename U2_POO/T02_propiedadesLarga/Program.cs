using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02_propiedadesLarga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n**** BOTELLA ****\n");

            // creo una variable de tipo botella1
            Botella botella1 = new Botella();

            // seteo: invoco a la propiedad y asigno directamente un valor como si fuera una variable
            botella1.Capacidad = 200;

            // obtener el valor y lo asigno a una variable
            int capacidad = botella1.Capacidad;

            // muestro 
            Console.WriteLine($"Capacidad: {capacidad}");


            Console.ReadKey();
        }
    }
}
