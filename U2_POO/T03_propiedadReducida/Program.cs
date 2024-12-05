using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03_propiedadReducida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               primer lote con 10 registros de productos, cada producto tiene:
                  - Codigo de Articulo( 3 digitos no correlativos)
                  - Precio 
                  - Codigo de Marca (1 a 10)
              Segundo lote con las ventas de la semana, cada ventas tiene:
                  - Codigo de Articulo
                  - Cantidad
                  - Codigo de cliente (1 a 100)
              Este lote corta con codigo de cliente cero
               */

            // para guardar un articulo
            Articulo articulo1 = new Articulo();

            // creo un vector de articulos de tipo articulo (para guardar 10 articulos)
            Articulo[] articulos = new Articulo[10];

            // cargar el vector con los 10 articulos
            for (int i = 0; i < articulos.Length; i++)
            {
                articulos[i] = new Articulo();

                Console.WriteLine("\n **** Ingrese los datos del producto ****\n");

                Console.Write("Codigo:");
                articulos[i].CodigoArticulo =int.Parse(Console.ReadLine());

                Console.Write("Precio:");
                articulos[i].Precio = float.Parse(Console.ReadLine());

                Console.Write("Codigo de Marca:");
                articulos[i].CodidoMarca = int.Parse(Console.ReadLine());
            }

            
            // creo un vector de ventas de tipo ventas
            Venta ventas = new Venta();

            // para cargar las ventas
            Console.Write("\n*** Ingrese la venta ***\n");
            Console.Write("Codigo de cliente (1 a 100):");
            ventas.CodigoCliente = int.Parse(Console.ReadLine());

            while (ventas.CodigoCliente != 0)
            {
                Console.Write("Codigo de articulo:");
                ventas.CodigoArticulo = int.Parse(Console.ReadLine());

                Console.Write("Cantidad:");
                ventas.Cantidad = int.Parse(Console.ReadLine());

                //trabajamos...

                //pido nuevamente el cliente
                Console.Write("\n*** Ingrese la venta ***\n");
                Console.Write("Codigo de cliente:");
                ventas.CodigoCliente = int.Parse(Console.ReadLine());

            }



        }
    }
}
