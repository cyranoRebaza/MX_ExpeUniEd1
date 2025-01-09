using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T13_interfaz
{
    // canario hereda de animalDomestico e Implementa la Interfaz Flyable
    internal class Canario : AnimalDomestico, IFlyable 
    {
        // IFlyable:me obliga a que implemente el metodo volar
        public string Volar()
        {
            return "vuela como un canario...";
        }

        // metodo de canario
        public void Cantar()
        {
            Console.WriteLine("El canario esta cantando");
        }


    }
}
