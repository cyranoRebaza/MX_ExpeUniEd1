using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T10_herencia2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             - clase base Vehiculo
                - Auto
                    - AutoDeportivo
                    - AutoUrbano
                - Camioneta
                - Moto
             */

            // creo un objeto de tipo Vehiculo
            Vehiculo vehiculo1 = new Vehiculo();

            // creo un objeto de tipo Camioneta
            Camioneta camioneta1 = new Camioneta();

            // puedo guardar un objeto Camioneta en un variable tipo Vehiculo
            Vehiculo vehiculo2 = new Camioneta(); // porque --> una camioneta "ES" un vehiculo

        }
    }
}
