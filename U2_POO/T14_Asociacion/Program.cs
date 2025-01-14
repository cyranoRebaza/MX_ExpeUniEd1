using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T14_Asociacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Asociacion: un auto  y su conductor (relacion general)
             Agregacion: un garahe y su autos (El garaje contiene autos, pero estos pueden existir sin el)
             Composicion: un auto y su motor (el motor es parte del auto y depende totalmente de el)
             */

            // Asociacion: Crear conductor y auto
            Conductor conductor = new Conductor("Lucho");
            Auto auto1 = new Auto("Ford", 180); // Auto con motor de 180 caballos
            Auto auto2 = new Auto("Toyota", 120); // segundo auto
            Auto auto3 = new Auto("Honda", 130); // tercer auto

            auto1.Conductor = conductor; // Asigno el conductor al auto

            // Agregacion: Crear un garaje y agregar autos
            Garaje garaje = new Garaje("Garaje David");
            
            // agregar varios autos usando el metodo un solo auto
            garaje.AgregarAuto(auto1);
            garaje.AgregarAuto(auto2);
            garaje.AgregarAuto(auto3);

            // Mostrar detalles
            Console.WriteLine("Detalles del auto con su conductor:\n");
            auto1.Mostrar();

            Console.WriteLine("\nDetalles de garaje con autos:\n");
            garaje.MostrarAutos();


            
        }
    }
}
