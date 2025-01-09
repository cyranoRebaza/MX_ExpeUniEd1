using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T13_interfaz
{
    // Aguila hereda de animalSalvaje e Implementa la Interfaz Flyable
    internal class Aguila : AnimalSalvaje, IFlyable 
    {
        // IFlyable:me obliga a que implemente el metodo volar
        public string Volar()
        {
            return "Vuela como una Aguila...";
        }

        // metodo de aguila
        public void Cazar()
        {
            Console.WriteLine("El aguila esta cazando");
        }
    }
}
