using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T13_interfaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

           - Animal
               - Animal domestico                    
                   - Canario
               - Animal salvaje
                   - Aguila
                   
            */

            // creo una lista de animales voladores, uso el tipo de dato Flyable
            Console.WriteLine("Coleccion de animales que pueden volar:");

            // no se puede crear una instancia Flyable pero si de una lista Iflyable
            List<IFlyable> listaVoladores = new List<IFlyable>();

            // agregar objetos canario y aguila a la lista
            listaVoladores.Add(new Canario());
            listaVoladores.Add(new Aguila());

            // iterar sobre la lista y llamar a Volar()
            foreach (IFlyable volador in listaVoladores)
            {
                volador.Volar();
            }
            Console.WriteLine();

            // usar polimorfismo para aceceder a comportamientos unicos
            foreach (IFlyable volador in listaVoladores)
            {
                // compruebo si el objeto volador es de tipo canario (chequeo de tipo y casting seguro con is)
                if (volador is Canario canario)
                {
                    canario.Cantar();
                }
                else if (volador is Aguila aguila)
                {
                    aguila.Cazar();
                }
            }
        }
    }
}
