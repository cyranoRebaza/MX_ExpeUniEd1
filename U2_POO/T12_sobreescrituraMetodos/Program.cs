using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace T12_sobreescrituraMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
            - Animal
                - Animal domestico 
                    - Gato
                    - Perro
                    - Canario
                - Animal salvaje
                    - Aguila
                    - Pez
                    - tigre

             */

            Console.WriteLine("Todo Animal domestico: \n");

            // creo un objeto de tipo animal domestico
            AnimalDomestico animal1 = new AnimalDomestico();
            animal1.Nombre = "Depende del dueño"; // asigno un nombre

            // invoco al metodo ToString() sobreescrito
            Console.WriteLine(animal1.ToString());

            // invo al metodo Comunicarse()
            Console.WriteLine(animal1.Comunicarse());

            Console.WriteLine("\n*********************************\n");

            Console.WriteLine("El gato es un animal domestico\n");

            // creo un objeto tipo gato
            Gato gato1 = new Gato();
            gato1.Nombre = "Michi"; // asigno un nombre

            // invoco al metodo ToString() sobreescrito
            Console.WriteLine(gato1.ToString());

            // invoco al metodo Comunicarse()
            Console.WriteLine(gato1.Comunicarse());

            Console.WriteLine("\n*********************************\n");

            Console.WriteLine("El Perro es un animal domestico\n");

            // creo un objeto tipo perro
            Perro perro1 = new Perro();
            perro1.Nombre = "Mota"; // asigno un nombre

            // invoco al metodo ToString() sobreescrito
            Console.WriteLine(perro1.ToString());

            // invoco al metodo Comunicarse()
            Console.WriteLine(perro1.Comunicarse());

            Console.WriteLine("\n*********************************\n");

            // creo una lista de animales
            List<Animal> animales = new List<Animal>();
            
            animales.Add(gato1); // referenciado al objeto gato1 
            animales.Add(perro1);
            animales.Add(new Pez()); // referenciando directamente al objeto en la lista
            animales.Add(new Canario());
            animales.Add(new Aguila());

            // recorro la lista 
            foreach (Animal item in animales)
            {
                // polimorfismo: ante el estimulo Comunicarse() cada animal se comunica como corresponde
                Console.WriteLine(item.Comunicarse()); 
            }

            Console.ReadKey();
        }
    }
}
