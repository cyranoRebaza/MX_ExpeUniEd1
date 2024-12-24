using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T08_claseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creo una variable de tipo string donde guardo un valor ingresado por el ususario
            Console.WriteLine("Ingrese su nombre: ");
            string nombre = Console.ReadLine();

            // muestro el nombre el pantalla
            string saludo = $" hola como estas {nombre}";
            Console.WriteLine(saludo);

            // cuantos caracteres tiene la variable nombre
            int cantidadCaracteres = nombre.Length;
            Console.WriteLine($"la cantidad de caracteres es: {cantidadCaracteres}");

            // transformo la variable nombre a mayusculas
            nombre = nombre.ToUpper();
            Console.WriteLine($"con el metodo ToUpper() transformo a mayunsculas: {nombre}");

            // transformo la variable nombre a minuscula
            nombre = nombre.ToLower();
            Console.WriteLine($"con el metodo ToLower() transformo a minuscula: {nombre}");

            // cambio un caracter por otro
            nombre = nombre.Replace('a', 'e');
            Console.WriteLine($"con el metodo ToReplace() intercambio caracteres a por e: {nombre}");

            // cambio un fragmento entero por otro
            saludo = saludo.Replace("hola", "hello");
            Console.WriteLine($"con el metodo Repleace() intercambio el framento hola por hello: {saludo}");
            


        }
    }
}
