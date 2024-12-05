using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04_constructoresDesctructores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n**** BOTELLA 2 ****\n");

            // creo una varible de tipo botella
            Botella botella1 = new Botella("Rojo", "Plastico");

            // seteo el atributo capacidad
            botella1.Capacidad = 200;

            // leer los atributos de la botella y guardarlos en una variable
            int valorCapacidad = botella1.Capacidad;
            string valorMaterial =  botella1.Material;
            string valorColor = botella1.Color;
            int valorCantidadActual = botella1.CantidadActual;

            // mostrar los valores de cada atributo
            Console.WriteLine($"Material: {valorMaterial}");
            Console.WriteLine($"Color: {valorColor}");
            Console.WriteLine($"Capacidad: {valorCapacidad}");
            Console.WriteLine($"Cantidad actual: {valorCantidadActual}");

        }
    }
}
