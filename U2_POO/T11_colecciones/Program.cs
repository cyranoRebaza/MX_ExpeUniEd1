using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T11_colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creo tres objetos tipo camioneta
            Camioneta c1 = new Camioneta();
            Camioneta c2 = new Camioneta();
            Camioneta c3 = new Camioneta();

            // asigno un color a cada camioneta
            c1.Color = "Amarillo";
            c2.Color = "Rojo";
            c3.Color = "Blanco";
            
            // creo un objeto tipo <ListaCamioneta>
            List<Camioneta> ListaCamionetas = new List<Camioneta>();

            // agrego tres camionetas a la lista de camionetas
            ListaCamionetas.Add(c1);
            ListaCamionetas.Add (c2);
            ListaCamionetas.Add(c3);

            // muestro la cantidad de camionetas
            Console.WriteLine($"La cantidad de camionetas es: {ListaCamionetas.Count}");

            // muestro los colores de la camioneta
            Console.WriteLine($"El color de la camioneta c1 es: {ListaCamionetas[0].Color}");
            Console.WriteLine($"El color de la camioneta c2 es: {ListaCamionetas[1].Color}");
            Console.WriteLine($"El color de la camioneta c3 es: {ListaCamionetas[2].Color}");

            // remuevo un elemento de la lista de camionetas
            ListaCamionetas.Remove(c3);

            // muestro la nueva cantidad de ListaCamionetas
            Console.WriteLine($"La cantidad de camionetas es: {ListaCamionetas.Count}");

            // recorro la coleccion de camionetas usando foreach
            Console.WriteLine("\nEl color de todas las camionetas es: (usando foreach)");

            foreach (Camioneta item in ListaCamionetas)
            {
                Console.WriteLine($"Color: {item.Color}");
            }

            // recorro la coleccion de camionetas usando for
            Console.WriteLine("\nEl color de todas las camionetas es: (usando for)");
            for (int i = 0; i < ListaCamionetas.Count; i++)
            {
                Camioneta item = ListaCamionetas[i];
                Console.WriteLine($"Color: {item.Color}");
            }
        }
    }
}
