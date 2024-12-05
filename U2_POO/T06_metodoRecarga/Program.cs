using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T06_metodoRecarga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creo objeto botella con el constructor sobrecargado
            Botella botella1 = new Botella("Plastico", "Rojo");

            Console.WriteLine("antes de la recarga");

            // muestro la capacidad y la cantidad actual de la botella
            Console.WriteLine($"capacidad: {botella1.Capacidad}");
            Console.WriteLine($"cantidad actual: {botella1.CantidadActual}");

            // recargo
            botella1.Recargar();

            // despues de la recarga
            Console.WriteLine("despues de la recarga");

            Console.WriteLine($"capacidad: {botella1.Capacidad}");
            Console.WriteLine($"cantidad actual: {botella1.CantidadActual}");

            Console.ReadKey();
        }
    }
}
