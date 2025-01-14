using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T14_Asociacion
{
    internal class Motor
    {
        // Atributos privados
        private int potencia;

        // Propiedades publicas
        public int Potencia
        {
            get { return potencia; }
            set { potencia = value; }
        }

        // Constructor
        public Motor(int potencia)
        {
            this.potencia = potencia;
        }

        // Metodo para mostrar detalles del motor
        public void MostrarDetalle()
        {
            Console.WriteLine($"Motor con potencia de {Potencia} caballos");
        }

    }
}
